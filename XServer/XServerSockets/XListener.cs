using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace XServer.XServerSockets
{
    class XListener
    {
        IPEndPoint m_LocalEP;
        List<XClient> m_ClientList = new List<XClient>();

        public IPEndPoint LocalEP
        {
            get { return m_LocalEP; }
            set { m_LocalEP = value; }
        }
        Socket m_LocalSocket;

        public Socket LocalSocket
        {
            get { return m_LocalSocket; }
            set { m_LocalSocket = value; }
        }

        public XListener(int port) : this(new IPEndPoint(IPAddress.Any,port))
        {

        }

        XListener(IPEndPoint nLocalEP)
        {
            this.LocalEP = nLocalEP;
            LocalSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void StartListen()
        {
            LocalSocket.Bind(LocalEP);
            LocalSocket.Listen(1000);

            LocalSocket.BeginAccept(new AsyncCallback(OnConnect), null);
        }
        void OnConnect(IAsyncResult ar) 
        {
            Socket temp = LocalSocket.EndAccept(ar);
            XClient xc = new XClient(temp);
            xc.StartRelay();
            m_ClientList.Add(xc);
            xc.OnDisconnect += new DestroyDelegate(RemoveClient);
            LocalSocket.BeginAccept(new AsyncCallback(OnConnect), null);            
        }

        private void RemoveClient(XClient xc)
        {
            m_ClientList.Remove(xc);
            if ( xc.Username != null )
            Console.WriteLine("Kullanıcı Düştü"+xc.Username);
        }



    }
}
