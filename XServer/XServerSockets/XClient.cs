using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using XReactor;
using System.Net.Sockets;
using XReactor.XUtil;

namespace XServer.XServerSockets
{
    public delegate void DestroyDelegate(XClient nXClient);
    public delegate void OnLoginRequest(LoginRequest lr);
    public delegate void OnUserInfoRequest(UserInfoRequest uir);
    public delegate void OnGamePermRequest(GamePermRequest gpr);
    public class XClient : IDisposable
    {
        XProcessor xp;
        public OnLoginRequest OnReceivedOnLoginRequest;
        public OnUserInfoRequest OnReceivedUserInfoRequest;
        public OnGamePermRequest OnReceivedOnGamePermRequest;
        public DestroyDelegate OnDisconnect;
        Socket m_ClientSocket;
        private string m_Username;

        public string Username
        {
            get { return m_Username; }
            set { m_Username = value; }
        }

        byte[] m_Buffer = new byte[1024];

        public Socket ClientSocket
        {
            get { return m_ClientSocket; }
            set { m_ClientSocket = value; }
        }

        public XClient(Socket nClientSocket)
        {
            this.m_ClientSocket = nClientSocket;
            
            
        }

        void ProcessLoginRequest(LoginRequest LR)
        {
            
        }

        public void StartRelay()
        {
            xp = new XProcessor(this);
            xp.RegEvents();
            this.ClientSocket.BeginReceive(m_Buffer, 0, m_Buffer.Length, SocketFlags.None, new AsyncCallback(OnReceive), null);
        }

        void OnReceive(IAsyncResult ar)
        {
            try
            {

                int ret = ClientSocket.EndReceive(ar);
                if (ret <= 0)
                {
                    Dispose();
                    return;
                }
                ExtractBuffer(m_Buffer, ret);
                this.ClientSocket.BeginReceive(m_Buffer, 0, m_Buffer.Length, SocketFlags.None, new AsyncCallback(OnReceive), null);
            }
            catch
            {
                Dispose();
            }



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
        public void SendBytes(byte[] data)
        {
            this.ClientSocket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(OnSend), null);
        }

        void OnSend(IAsyncResult ar)
        {
            try
            {
                int length = ClientSocket.EndSend(ar);
                if (length > 0)
                    return;
            }
            catch
            {

            }
            Dispose();
        }
       
        /// <summary>
        /// İstemciyi yoket
        /// </summary>
        public void Dispose()
        {
            // Bitir
            try
            {
                this.ClientSocket.Shutdown(SocketShutdown.Both);
            }
            catch
            {

            }
            if (this.ClientSocket != null)
            {
                this.ClientSocket.Close();
            }
            this.ClientSocket = null;
            if (OnDisconnect != null)
            {
                OnDisconnect(this);
            }
            
            

               
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
