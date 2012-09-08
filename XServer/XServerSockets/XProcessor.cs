using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XReactor;
using XServer.XData;

namespace XServer.XServerSockets
{
    class XProcessor
    {
        XClient m_Client;
        XMySQL m_Mysql;

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
            if (uir.Username != m_Client.Username)
            {
                m_Client.Dispose();
                return;
            }
           m_Client.SendBytes(CreateCommand(XCommunicateEnum.UserInfoRequestResponse,PrepareUserInfo(uir).ToByteArray()));
         
        }

        private UserInfoRequestResponse PrepareUserInfo(UserInfoRequest uir)
        {
            UserInfoRequestResponse.Builder builder = new UserInfoRequestResponse.Builder();
            builder.SetAssist(10).SetCreeps(10).SetDeath(10).SetDeny(10).SetKill(213).SetLost(21312).SetRax(21312).SetTotalGames(1213).SetTower(2312).SetWins(21321).SetTotalReport(20);

            return builder.Build();
        }

        private void ProcessLoginRequest(LoginRequest LR)
        {
            Console.WriteLine("A Client Requested For Login[" + LR.Name + "] with Password [" + LR.Password + "]");
            //
            // BURADA LOGIN ISLEMLERI YER ALMASI LAZIM
            //
            LoginRequestResponse.Builder builder = new LoginRequestResponse.Builder();
            builder.SetLogincode(LoginCode.LOGIN_SUCCESS);

           // m_Mysql.CheckLogin(LR.Name, LR.Password);
            builder.SetUsername(LR.Name);
            builder.Usertype = UserType.ADMIN;
            m_Client.SendBytes(CreateCommand(XCommunicateEnum.LoginRequestResponse, builder.Build().ToByteArray()));
            Console.WriteLine("Login Request Responsed \n ================================================\n" + builder.Build().ToString());
            if (LR.Name == "timeout")
            {
                m_Client.Username = LR.Name;
                Console.WriteLine("Username settings for client ="+LR.Name);
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
