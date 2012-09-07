using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using XReactor;
using System.Net.Sockets;
using XReactor.XUtil;

namespace XServer.XServerSockets
{
    public delegate void OnLoginRequest(LoginRequest lr);
    public delegate void OnUserInfoRequest(UserInfoRequest uir);
    public delegate void OnGamePermRequest(GamePermRequest gpr);
    class XClient
    {
        public OnLoginRequest OnReceivedOnLoginRequest;
        public OnUserInfoRequest OnReceivedUserInfoRequest;
        public OnGamePermRequest OnReceivedOnGamePermRequest;
        Socket m_ClientSocket;
        byte[] m_Buffer = new byte[1024];

        public Socket ClientSocket
        {
            get { return m_ClientSocket; }
            set { m_ClientSocket = value; }
        }

        public XClient(Socket nClientSocket)
        {
            this.m_ClientSocket = nClientSocket;
            OnReceivedOnLoginRequest += new OnLoginRequest(ProcessLoginRequest);
        }

        void ProcessLoginRequest(LoginRequest LR)
        {
            Console.WriteLine("A Client Requested For Login[" + LR.Name + "] with Password [" + LR.Password + "]");
            //
            // BURADA LOGIN ISLEMLERI YER ALMASI LAZIM
            //
            LoginRequestResponse.Builder builder = new LoginRequestResponse.Builder();
            builder.SetLogincode( LoginCode.LOGIN_SUCCESS);
            builder.SetUsername ( LR.Name);
            builder.Usertype = UserType.ADMIN;
            SendBytes(CreateCommand(XCommunicateEnum.LoginRequestResponse, builder.Build().ToByteArray()));
            Console.WriteLine("Login Request Responsed \n ================================================\n" + builder.Build().ToString());
        }

        public void StartRelay()
        {
            this.ClientSocket.BeginReceive(m_Buffer, 0, m_Buffer.Length, SocketFlags.None, new AsyncCallback(OnReceive), null);
        }

        void OnReceive(IAsyncResult ar)
        {
            int ret = ClientSocket.EndReceive(ar);
            if (ret <= 0)
            {
                //Kapatma
                return;
            }            
            ExtractBuffer(m_Buffer, ret);
            this.ClientSocket.BeginReceive(m_Buffer, 0, m_Buffer.Length, SocketFlags.None, new AsyncCallback(OnReceive), null);

        }

        private void ExtractBuffer(byte[] m_Buffer, int ret)
        {
            byte[] SizedBuffer = new byte[ret-4];           
            Array.Copy(m_Buffer, 4, SizedBuffer, 0, SizedBuffer.Length);    
            if (m_Buffer[0] == (byte)XCommunicateEnum.Header)
            {
                XCommunicateEnum command = (XCommunicateEnum)m_Buffer[1];
                switch (command)
                {        
                    case XCommunicateEnum.LoginRequest:
                        if (OnReceivedOnLoginRequest != null)                         
                        OnReceivedOnLoginRequest(LoginRequest.ParseFrom(SizedBuffer));         
                        break;                   
                    case XCommunicateEnum.UserInfoRequest:
                        if (OnReceivedUserInfoRequest != null)
                            OnReceivedUserInfoRequest(UserInfoRequest.ParseFrom(SizedBuffer));
                        break;                  
                    case XCommunicateEnum.GamePermRequest:
                        if (OnReceivedOnGamePermRequest != null)
                            OnReceivedOnGamePermRequest(GamePermRequest.ParseFrom(SizedBuffer));
                        break;                 
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Buffer");
            }
            m_Buffer = new byte[1024];
        }
     
        /// <summary>
        /// Ham Komut Paketi Oluşturur
        /// </summary>
        /// <param name="Command">Gönderilecek Komutun Türü</param>
        /// <param name="data">Komutun Datası</param>
        private byte[] CreateCommand(XCommunicateEnum Command, byte[] data)
        {
            byte[] temp = new byte[4 + data.Length];
            byte[] size = BitConverter.GetBytes((ushort)data.Length);

            temp[0] = (byte)XCommunicateEnum.Header;
            temp[1] = (byte)Command;
            data.CopyTo(temp, 4);
            size.CopyTo(temp, 2);

            return temp;
        }
        /// <summary>
        /// Veriyi Bastaki 2 bytedan Ayrıştırır
        /// </summary>
        /// <param name="data">Ham Veri</param>
        /// <returns>Saf Komut Paketi Döndürür</returns>
        private byte[] GetCommand(byte[] data)
        {
            byte[] command = new byte[data.Length-2];
            Array.Copy(data, 2, command, 0, command.Length);
            Console.WriteLine(command[0]+command[1]+command[2]);
            return command;
        }
        
        /// <summary>
        /// İstemci Sockete Veri yolla
        /// </summary>
        /// <param name="data">Yollanacak Veri</param>
        private void SendBytes(byte[] data)
        {
            this.ClientSocket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(OnSend), null);
        }

        void OnSend(IAsyncResult ar)
        {            
            ClientSocket.EndSend(ar);
        }
       
        /// <summary>
        /// İstemciyi yoket
        /// </summary>
        public void Dispose()
        {
            this.ClientSocket = null;
               
        }      

        
    }
    public enum XCommunicateEnum : byte
    {
        Header = 254,
        LoginRequest = 2,
        LoginRequestResponse = 3,
        UserInfoRequest = 4,
        UserInfoRequestResponse = 5,
        GamePermRequest = 6,
        GamePermRequestResponse = 7,
    }
}
