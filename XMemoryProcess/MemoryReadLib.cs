using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace XReactor.XMemoryProcess
{
    
    class MemoryReadLib
    {
        #region Dll İmports
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAdress,
            byte[] lpBuffer, int size, int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int ReadProcessMemory(IntPtr hProcess, int lpBaseAdress,
            int lpBuffer, int size, int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAdress,
            byte[] lpBuffer, int size, int lpNumberOfBytesWritten); 
        #endregion


        Process m_War3;

        public Process War3
        {
            get { return m_War3; }
            set { m_War3 = value; }
        }
        ProcessModule m_GameDll;

        public ProcessModule GameDll
        {
            get { return m_GameDll; }
            set { m_GameDll = value; }
        }
        ProcessModule m_StormDll;

        public ProcessModule StormDll
        {
            get { return m_StormDll; }
            set { m_StormDll = value; }
        }

      
      public  enum WhichDLL {
           STORMDLL,
           GAMEDLL,
           WAR3
       }

        /// <summary>
        /// Memory yi okumak için Process İsmi Giriniz..
        /// </summary>
        /// <param name="ProccessName">Process Name</param>
        public MemoryReadLib(string ProccessName)
        {
            Process[] processes = Process.GetProcessesByName(ProccessName);
            foreach (Process pr in processes)
            {
                if (pr.ProcessName == ProccessName)
                {
                    this.War3 = pr;
                }
            }
            if (War3 != null)
            {
                ProcessModuleCollection blabla = War3.Modules;
                foreach (ProcessModule mdl in blabla)
                {
                    if (mdl.ModuleName == "Storm.dll")
                    {
                        this.StormDll = mdl;
                    }
                    else if (mdl.ModuleName == "Game.dll")
                    {
                        this.GameDll = mdl;
                    }
                }

                if (GameDll == null || StormDll == null)
                {
                    throw new NullReferenceException("There is no Game Process");
                }

            }
            else
            {
                throw new NullReferenceException("There is no Game Process");
            }
            
        }

        /// <summary>
        /// Mh Tespiti İçin Gerekli Fonksiyon
        /// </summary>
        /// <param name="nDLL">Okunacak DLL</param>
        /// <param name="WhichOffset">Okunacak Offsetin Değeri</param>
        /// <param name="ReadByteNumber">Okunacak Byte Sayısı</param>
        /// <param name="Matchable">Eşleştirelecek Bytelar</param>
        /// <returns>Eğer Verilen bytelarla gonderilen koordinatlardaki bytelar birbirine eşitse true döndürür.Değilse false</returns>
        public bool ReadOffset(WhichDLL nDLL, int WhichOffset,int ReadByteNumber,byte[] Matchable)
        {
            ProcessModule prm = null;
            switch (nDLL)
            {
                case WhichDLL.STORMDLL:
                    prm = this.StormDll;
                    break;
                case WhichDLL.GAMEDLL:
                    prm = this.GameDll;
                    break;
                case WhichDLL.WAR3:
                    prm = this.War3.MainModule;
                    break;
                default:
                    break;
            }

            byte[] GonnaRead = new byte[ReadByteNumber];
            if (this.War3.HasExited)
            {
                throw new ArgumentNullException("Oyun Kapandığı için Okunamıyor.");
            }
            IntPtr gg = System.IntPtr.Add(prm.BaseAddress,WhichOffset);
            
            ReadProcessMemory(this.War3.Handle,gg , GonnaRead, GonnaRead.Length, 0);

            if (Encoding.UTF8.GetString(GonnaRead) == Encoding.UTF8.GetString(Matchable))
            {
                return true;
            }

            return false;
        }
    }
}

