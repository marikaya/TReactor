        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using System.Net.Sockets;
        using System.Net;
        using System.Reflection;
        using GalaSoft.MvvmLight.Messaging;
        using System.Threading;
        using GalaSoft.MvvmLight.Messaging;



namespace XReactor.XSockets
{
    public delegate void OnDisconnect(XReactorSockets nClient);
    public delegate void OnReceivedLoginResponse(LoginRequestResponse nLoginRequestResponse);
    public delegate void OnReceivedGamePermResponse(GamePermRequestResponse nGamePermRequestResponse);
    public delegate void OnReceivedUserInfoResponse(UserInfoRequestResponse nInfoRequestResponse);
    public delegate void OnMhReportSend(MhReport nMhReport);
    public class XReactorSockets : IDisposable
    {

        #region Variables

        Socket m_ServerSocket;

        string m_Name;

        bool m_Connected;

        byte[] m_Buffer = new byte[1024];
        int attempt = 0;

        string username, password;

        public OnDisconnect m_OnDisonnection;

        public OnReceivedUserInfoResponse OnUserInfoRequestResponse;

        public OnReceivedLoginResponse OnLoginRequestResponse;

        public OnReceivedGamePermResponse OnGamePermRequestResponse;

        public OnMhReportSend OnMhReportSended;

        IPEndPoint m_ServerEp;

        #endregion

        #region Properties


        public IPEndPoint ServerEp
        {
            get { return m_ServerEp; }
            set { m_ServerEp = value; }
        }

        public Socket ClientSocket
        {
            get { return m_ServerSocket; }
            set { m_ServerSocket = value; }
        }

        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        public bool Connected
        {
            get { return m_Connected; }
            set { m_Connected = value; }
        }

        #endregion

        #region Socket Functions


        public void TryConnect()
        {


            try
            {
                XPacket xp = new XPacket();
                m_ServerSocket.BeginConnect(ServerEp, new AsyncCallback(OnConnect), null);
            }
            catch (SocketException se)
            {
                Console.WriteLine(se.Message);
                Messenger.Default.Send<string>("CONNECTION_PROBLEM", "loginform");


            }
        }

        private void OnConnect(IAsyncResult ar)
        {
            m_ServerSocket.EndConnect(ar);


            Console.WriteLine("Client Connected To The Server...");


            // Login Request Datasını oluşturduk.
            // Şimdi Login Request Datasını Gönderelim.

            XPacket xp = new XPacket();
            m_ServerSocket.BeginReceive(m_Buffer, 0, m_Buffer.Length, SocketFlags.None, new AsyncCallback(OnReceive), xp);
        }

        private void OnReceive(IAsyncResult ar)
        {
            try
            {

                int ret = m_ServerSocket.EndReceive(ar);
                ExtractBuffer(m_Buffer, ret);
                m_ServerSocket.BeginReceive(m_Buffer, 0, m_Buffer.Length, SocketFlags.None, new AsyncCallback(OnReceive), null);
            }
            catch (SocketException s)
            {
                if (s.SocketErrorCode == SocketError.ConnectionReset)
                {
                    Console.WriteLine("Connection Reset By Server");
                }
                Connected = false;
                if (m_OnDisonnection != null)
                {
                    m_OnDisonnection(this);
                }
            }

        }

        private void OnSend(IAsyncResult ar)
        {
            int ret = ClientSocket.EndSend(ar);
            if (ret <= 0)
            {
                this.Connected = false;
                if (m_OnDisonnection != null)
                {
                    m_OnDisonnection(this);
                    Dispose();
                }
            }
        }
        #endregion

        #region Receive Functions

        #endregion

        #region Send Functions
        /// <summary>
        /// Giriş İsteği yolla
        /// </summary>
        /// <param name="nUsername">Kullanıcı İsmi</param>
        /// <param name="nPassword">Parola</param>
        public void SendLoginRequest(string nUsername, string nPassword)
        {
            this.username = nUsername;
            this.password = nPassword;
            LoginRequest.Builder Lr = new LoginRequest.Builder();
            Lr.SetName(nUsername);
            Lr.SetPassword(nPassword);
            Lr.SetVersion("asdas");
            Lr.SetEmail("sjdjsj");
            SendBytes(CreateCommand(XCommunicateEnum.LoginRequest, Lr.Build().ToByteArray()));
        }
        public void SendUserInfoRequest()
        {
            UserInfoRequest.Builder sd = new UserInfoRequest.Builder();
            sd.SetUsername("timeout");
            sd.SetInfotype(InfoType.DOTA);
            sd.SetGametype(1,GameType.WARCRAFTIII);

            SendBytes(CreateCommand(XCommunicateEnum.UserInfoRequest, sd.Build().ToByteArray()));
        }
        /// <summary>
        /// Küfür Raporu Gönder
        /// </summary>
        /// <param name="nUser">Küfreden Şahış</param>
        /// <param name="nGameChat">Son Anda Yazılanlar Byte Array Cinsinden olması lazım</param>
        /// <param name="nGamename">Oyun İsmi</param>
        public void SendSwearReport(string nUser, string[] nGameChat, string nGamename)
        {
            SwearReport.Builder swB = new SwearReport.Builder();
            swB.SetUser(nUser);
            swB.SetGameName(nGamename);
            for (int i = 0; i < nGameChat.Length; i++)
            {
                swB.SetGameChat(i, nGameChat[i]);
            }
            SwearReport forSend = swB.Build();
            SendBytes(CreateCommand(XCommunicateEnum.SwearReport, forSend.ToByteArray()));

        }

        #endregion

        #region Utils
        /// <summary>
        /// Ham Komut Paketi Oluşturur
        /// </summary>
        /// <param name="Command">Gönderilecek Komutun Türü</param>
        /// <param name="data">Komutun Datası</param>
        /// <returns>Saf Gonderilecek Veri Döndürür</returns>
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
            byte[] command = new byte[data.Length - 4];
            Array.Copy(data, 24, command, 0, command.Length);
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

        /// <summary>
        /// Gelen Paketi Ayrıştırıp Command Packetleri Ayır
        /// </summary>
        /// <param name="data">Gelen Veri</param>
        /// <param name="ret">Gelen Verinin Boyutu</param>
        private void ExtractBuffer(byte[] data, int ret)
        {
            // Önce Array in Boyunu Yapılandır.
            byte[] SizedBuffer = new byte[ret];
            Array.Copy(data, 0, SizedBuffer, 0, ret);

            // Sonra İlk 4 paketten Komutu Ayrıştır.
            byte[] Command = new byte[ret - 4];
            Array.Copy(SizedBuffer, 4, Command, 0, Command.Length);

            // Sized Buffer
            if (SizedBuffer[0] == (byte)XCommunicateEnum.Header)
            {
                XCommunicateEnum opt = (XCommunicateEnum)SizedBuffer[1];
                switch (opt)
                {
                    case XCommunicateEnum.LoginRequestResponse:
                        if (OnLoginRequestResponse != null)
                            OnLoginRequestResponse(LoginRequestResponse.ParseFrom(Command));
                        Console.WriteLine("Login Request Response Received..");
                        break;
                    case XCommunicateEnum.UserInfoRequestResponse:
                        if (OnUserInfoRequestResponse != null)
                            OnUserInfoRequestResponse(UserInfoRequestResponse.ParseFrom(Command));
                        Console.WriteLine("User Info Request Response Received..");
                        break;
                    case XCommunicateEnum.GamePermRequestResponse:
                        if (OnGamePermRequestResponse != null)
                            OnGamePermRequestResponse(GamePermRequestResponse.ParseFrom(Command));
                        Console.WriteLine("Game Perm Request Response Received..");
                        break;
                    case XCommunicateEnum.MhReport:
                        if (OnMhReportSended != null)
                            OnMhReportSended(MhReport.ParseFrom(Command));
                        Console.WriteLine("A Mh Report Send By...");
                        break;
                    default:
                        Console.WriteLine("A Invalid Packet Received..");
                        break;
                }
            }
            else
            {
                Console.WriteLine("BU ne");
            }


        }

        /// <summary>
        /// İstemciyi yoket
        /// </summary>
        public void Dispose()
        {
            this.ClientSocket = null;
            this.Name = null;


        }

        /// <summary>
        /// Yeni Bi istemci Kur
        /// </summary>
        /// <param name="nLocalSocket">Dinleyici Sockete Gelen Bağlantı</param>
        public XReactorSockets(IPEndPoint nServerEP)
        {
            m_ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.ServerEp = nServerEP;
            OnLoginRequestResponse += new OnReceivedLoginResponse(ProcessLoginResponse);
        }


        #endregion
        void ProcessLoginResponse(LoginRequestResponse LR)
        {
            Console.WriteLine(LR.ToString() + "ddsds");
        }
    }
}
