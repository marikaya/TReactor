using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XReactor;

namespace XServer.XServerSockets
{
    class XProcessor
    {
        XClient m_Client;

        public XProcessor(XClient nXClient)
        {
            this.m_Client = nXClient;
        }

        public void RegEvents()
        {
            m_Client.OnReceivedOnLoginRequest += new OnLoginRequest(ProcessLoginRequest);
            m_Client.OnReceivedUserInfoRequest += new OnUserInfoRequest(ProcessUserInfoRequest);
            m_Client.OnReceivedOnGamePermRequest += new OnGamePermRequest(ProcessGamePermRequest);
        }

        private void ProcessGamePermRequest(GamePermRequest gpr)
        {
         
        }

        private void ProcessUserInfoRequest(UserInfoRequest uir)
        {
           
        }

        private void ProcessLoginRequest(LoginRequest LR)
        {
            Console.WriteLine("A Client Requested For Login[" + LR.Name + "] with Password [" + LR.Password + "]");
            //
            // BURADA LOGIN ISLEMLERI YER ALMASI LAZIM
            //
            LoginRequestResponse.Builder builder = new LoginRequestResponse.Builder();
            builder.SetLogincode(LoginCode.LOGIN_SUCCESS);
            builder.SetUsername(LR.Name);
            builder.Usertype = UserType.ADMIN;
            m_Client.SendBytes(CreateCommand(XCommunicateEnum.LoginRequestResponse, builder.Build().ToByteArray()));
            Console.WriteLine("Login Request Responsed \n ================================================\n" + builder.Build().ToString());
            if (LR.Name == "timeout")
            {
                m_Client.Username = LR.Name;        
            }
        
        }
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
        
    }
}
