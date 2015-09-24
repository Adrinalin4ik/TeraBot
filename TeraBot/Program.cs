using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace TeraBot
{

    class Program
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);


        public static IntPtr Tera;
        public static IntPtr TeraWindowHandle;
        public static string TeraWindowTitle; 



        public static void GetWindow()
        {
            Process[] processlist = Process.GetProcesses();

            foreach (Process process in processlist)
            {
                if (process.ProcessName == "TERA")
                {
                   TeraWindowTitle = process.MainWindowTitle;
                    TeraWindowHandle = process.MainWindowHandle;

                }
            }
            Program.Tera = FindWindow(null, Program.TeraWindowTitle);
        }
    }
}
