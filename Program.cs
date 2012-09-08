using System;
using ConsoleApplication1.XInterface;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xaml;
using XReactor.XSockets;
using System.Windows;
using System.Windows.Forms;
using ss = System.Windows.Application;
using XReactor.XMemoryProcess;
using System.Net;
using XReactor.XInterface;

namespace XReactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            ss yeni = new ss();


            try
            {
                MemoryReadLib sd = new MemoryReadLib("war3");
                sd.ReadOffset(MemoryReadLib.WhichDLL.GAMEDLL, 0x12121, 5, new byte[] { 0x12 });
            }
            catch (ArgumentNullException sd)
            {
                Console.WriteLine("Oyun Bulunamadı");
            }
            catch(NullReferenceException ss )
                {
                    Console.WriteLine(ss.Message);
                }


            XReactorSockets XRS = new XReactorSockets(new IPEndPoint(IPAddress.Parse("127.0.0.1"),11000));
            new LoginPanel(XRS).ShowDialog();

            new DashBoard(XRS).ShowDialog();
            XRS.Dispose();
                       
        }
    }
}
