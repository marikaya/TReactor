using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace XReactor.XUtil
{
    class UtilVariables
    {
        public static IPEndPoint GetServerEp(string host,int port)
        {
            IPAddress[] ip = Dns.GetHostAddresses(host);
            IPEndPoint ep = new IPEndPoint(ip[0],port);
            return ep;
        }
    }
}
