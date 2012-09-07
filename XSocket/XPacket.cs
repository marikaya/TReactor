using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace XReactor.XSockets
{
    class XPacket
    {
        byte[] m_Buffer = new byte[1024];

        public byte[] Buffer
        {
            get { return m_Buffer; }
            set { m_Buffer = value; }
        }

        Socket m_ServerSocket;

        public Socket ServerSocket
        {
            get { return m_ServerSocket; }
            set { m_ServerSocket = value; }
        }

    }
}
