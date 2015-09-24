using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;
using WindowsInput;
using System.Windows.Threading;
 
namespace TeraBot
{
    class Keyboard
    {
        [DllImport("user32.dll")]
        public static extern int SendMessageA(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_WHEEL = 0x0800;
        private const int MOUSEEVENTF_XDOWN = 0x0080;
        private const int MOUSEEVENTF_XUP = 0x0100;
        ///summary>
        /// Virtual Messages
        /// </summary>
        public static bool d1;
        public static bool d2;
        public static bool d3;
        public static bool d4;
        public static bool d5;
        public static bool d6;
        public static bool d7;
        public static bool d8;
        public static bool d9;
        public static bool d0;
        public static bool f1;
        public static bool f2;
        public static bool f3;
        public static bool f4; 
        public static bool f5;
        public static bool f6;
        public static bool f7;
        public static bool f8;
        public static bool f9;
        public static bool f10; 

        public static int Sleepd1;
        public static int Sleepd2;
        public static int Sleepd3;
        public static int Sleepd4;
        public static int Sleepd5;
        public static int Sleepd6;
        public static int Sleepd7;
        public static int Sleepd8;
        public static int Sleepd9;
        public static int Sleepd0;
        public static int Sleepf1;
        public static int Sleepf2;
        public static int Sleepf3;
        public static int Sleepf4;
        public static int Sleepf5;
        public static int Sleepf6;
        public static int Sleepf7;
        public static int Sleepf8;
        public static int Sleepf9;
        public static int Sleepf10;

        public static int PauseBetweenSkills = 100;
        private static bool ready = true;
        public static void MouseMove(uint x, uint y)
        {
            mouse_event(0x0001, x, y, 0, 0);
        }
        public static void BattleKey1()
        {
            if (d1 && Hero.Range < Hero.attackRange)
            {
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D1, (IntPtr)0);
                Thread.Sleep(Sleepd1);
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D1, (IntPtr)0);

            }
            if (d2 && Hero.Range < Hero.attackRange)
            {
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D2, (IntPtr)0);
                Thread.Sleep(Sleepd2);
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D2, (IntPtr)0);
            }
            if (d3 && Hero.Range < Hero.attackRange)
            {
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D3, (IntPtr)0);
                Thread.Sleep(Sleepd3);
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D3, (IntPtr)0);
            }
            if (d4 && Hero.Range < Hero.attackRange)
            {
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D4, (IntPtr)0);
                Thread.Sleep(Sleepd4);
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D4, (IntPtr)0);
            }
            if (d5 && Hero.Range < Hero.attackRange)
            {
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D5, (IntPtr)0);
                Thread.Sleep(Sleepd5);
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D5, (IntPtr)0);
            }
            if (d6 && Hero.Range < Hero.attackRange)
            {
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D6, (IntPtr)0);
                Thread.Sleep(Sleepd6);
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D6, (IntPtr)0);
            }
            if (d7 && Hero.Range < Hero.attackRange)
            {
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D7, (IntPtr)0);
                Thread.Sleep(Sleepd7);
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D7, (IntPtr)0);
            }
            if (d8 && Hero.Range < Hero.attackRange)
            {
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D8, (IntPtr)0);
                Thread.Sleep(Sleepd8);
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D8, (IntPtr)0);
            }
            if (d9 && Hero.Range < Hero.attackRange)
            {
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D9, (IntPtr)0);
                Thread.Sleep(Sleepd9);
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D9, (IntPtr)0);
            }
            if (d0 && Hero.Range < Hero.attackRange)
            {
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D0, (IntPtr)0);
                Thread.Sleep(Sleepd0);
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D0, (IntPtr)0);
            }
            if (f1 && Hero.Range < Hero.attackRange)
            {
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F1, (IntPtr)0);
                Thread.Sleep(Sleepf1);
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F1, (IntPtr)0);
            }
            if (f2 && Hero.Range < Hero.attackRange)
            {
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F2, (IntPtr)0);
                Thread.Sleep(Sleepf2);
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F2, (IntPtr)0);
            }
            if (f3 && Hero.Range < Hero.attackRange)
            {
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F3, (IntPtr)0);
                Thread.Sleep(Sleepf3);
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F3, (IntPtr)0);
            }
            if (f4 && Hero.Range < Hero.attackRange)
            {
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F4, (IntPtr)0);
                Thread.Sleep(Sleepf4);
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F4, (IntPtr)0);
            }
            if (f5 && Hero.Range < Hero.attackRange)
            {
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F5, (IntPtr)0);
                Thread.Sleep(Sleepf5);
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F5, (IntPtr)0);
            }
            if (f6 && Hero.Range < Hero.attackRange)
            {
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F6, (IntPtr)0);
                Thread.Sleep(Sleepf6);
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F6, (IntPtr)0);
            }
            if (f7 && Hero.Range < Hero.attackRange)
            {
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F7, (IntPtr)0);
                Thread.Sleep(Sleepf7);
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F7, (IntPtr)0);
            }
            if (f8 && Hero.Range < Hero.attackRange)
            {
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F8, (IntPtr)0);
                Thread.Sleep(Sleepf8);
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F8, (IntPtr)0);
            }
            if (f9 && Hero.Range < Hero.attackRange)
            {
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F9, (IntPtr)0);
                Thread.Sleep(Sleepf9);
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F9, (IntPtr)0);
            }
            if (f10 && Hero.Range < Hero.attackRange)
            {
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.F10, (IntPtr)0);
                Thread.Sleep(Sleepf10);
                SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.F10, (IntPtr)0);
            }
        }
        public static void BattleKey()
        {

            if (ready)
            {
                ready = false;
                if (d1 && Hero.Range <= Hero.attackRange && Hero.target)
                {
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_1);
                    Thread.Sleep(Sleepd1);
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_1);
                    Thread.Sleep(PauseBetweenSkills);
                }
                if (d2 && Hero.Range <= Hero.attackRange && Hero.target)
                {
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_2);
                    Thread.Sleep(Sleepd2);
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_2);
                    Thread.Sleep(PauseBetweenSkills);
                }
                if (d3 && Hero.Range <= Hero.attackRange && Hero.target)
                {
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_3);
                    Thread.Sleep(Sleepd3);
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_3);
                    Thread.Sleep(PauseBetweenSkills);
                }
                if (d4 && Hero.Range <= Hero.attackRange && Hero.target)
                {
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_4);
                    Thread.Sleep(Sleepd4);
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_4);
                    Thread.Sleep(PauseBetweenSkills);
                }
                if (d5 && Hero.Range <= Hero.attackRange && Hero.target)
                {
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_5);
                    Thread.Sleep(Sleepd5);
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_5);
                    Thread.Sleep(PauseBetweenSkills);
                }
                if (d6 && Hero.Range <= Hero.attackRange && Hero.target)
                {
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_6);
                    Thread.Sleep(Sleepd6);
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_6);
                    Thread.Sleep(PauseBetweenSkills);
                }
                if (d7 && Hero.Range <= Hero.attackRange && Hero.target)
                {
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_7);
                    Thread.Sleep(Sleepd7);
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_7);
                    Thread.Sleep(PauseBetweenSkills);
                }
                if (d8 && Hero.Range <= Hero.attackRange && Hero.target)
                {
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_8);
                    Thread.Sleep(Sleepd8);
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_8);
                    Thread.Sleep(PauseBetweenSkills);
                }
                if (d9 && Hero.Range <= Hero.attackRange && Hero.target)
                {
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_9);
                    Thread.Sleep(Sleepd9);
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_9);
                    Thread.Sleep(PauseBetweenSkills);
                }
                if (d0 && Hero.Range <= Hero.attackRange && Hero.target)
                {
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_0);
                    Thread.Sleep(Sleepd0);
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_0);
                    Thread.Sleep(PauseBetweenSkills);
                }
                if (f1 && Hero.Range <= Hero.attackRange && Hero.target)
                {
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.F1);
                    Thread.Sleep(Sleepf1);
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.F1);
                    Thread.Sleep(PauseBetweenSkills);
                }
                if (f2 && Hero.Range <= Hero.attackRange && Hero.target)
                {
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.F2);
                    Thread.Sleep(Sleepf2);
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.F2);
                    Thread.Sleep(PauseBetweenSkills);
                }
                if (f3 && Hero.Range <= Hero.attackRange && Hero.target)
                {
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.F3);
                    Thread.Sleep(Sleepf3);
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.F3);
                    Thread.Sleep(PauseBetweenSkills);
                }
                if (f4 && Hero.Range <= Hero.attackRange && Hero.target)
                {
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.F4);
                    Thread.Sleep(Sleepf4);
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.F4);
                    Thread.Sleep(PauseBetweenSkills);
                }
                if (f5 && Hero.Range <= Hero.attackRange && Hero.target)
                {
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.F5);
                    Thread.Sleep(Sleepf5);
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.F5);
                    Thread.Sleep(PauseBetweenSkills);
                }
                if (f6 && Hero.Range <= Hero.attackRange && Hero.target)
                {
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.F6);
                    Thread.Sleep(Sleepf6);
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.F6);
                    Thread.Sleep(PauseBetweenSkills);
                }
                if (f7 && Hero.Range <= Hero.attackRange && Hero.target)
                {
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.F7);
                    Thread.Sleep(Sleepf7);
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.F7);
                    Thread.Sleep(PauseBetweenSkills);
                }
                if (f8 && Hero.Range <= Hero.attackRange && Hero.target)
                {
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.F8);
                    Thread.Sleep(Sleepf8);
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.F8);
                    Thread.Sleep(PauseBetweenSkills);
                }
                if (f9 && Hero.Range <= Hero.attackRange && Hero.target)
                {
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.F9);
                    Thread.Sleep(Sleepf9);
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.F9);
                    Thread.Sleep(PauseBetweenSkills);
                }
                if (f10 && Hero.Range <= Hero.attackRange && Hero.target)
                {
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.F10);
                    Thread.Sleep(Sleepf10);
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.F10);
                    Thread.Sleep(PauseBetweenSkills);
                }
                ready = true;
            }
        }
        public enum WMessages : int
        {
            WM_LBUTTONDOWN = 0x201, //Left mousebutton down
            WM_LBUTTONUP = 0x202,  //Left mousebutton up
            WM_LBUTTONDBLCLK = 0x203, //Left mousebutton doubleclick
            WM_RBUTTONDOWN = 0x204, //Right mousebutton down
            WM_RBUTTONUP = 0x205,   //Right mousebutton up
            WM_RBUTTONDBLCLK = 0x206, //Right mousebutton doubleclick
            WM_KEYDOWN = 0x100,  //Key down
            WM_KEYUP = 0x101,   //Key up
            WM_CHAR = 0x0102,
            VK_RETURN = 0x0D,
        }
    }
}
