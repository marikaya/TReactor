using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XServer.XServerSockets;

namespace XServer
{
    class Program
    {
        static void Main(string[] args)
        {
            XListener xr = new XListener(11000);
            xr.StartListen();

            Console.ReadLine();
        }
    }
}
