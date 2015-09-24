using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Threading.Tasks;
using WindowsInput;
namespace TeraBot
{
    class Battle
    {
        [DllImport("user32.dll")]
        public static extern int SendMessageA(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern void SetCursorPos(int x, int y);
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);


        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }
        /// <summary>
        /// Retrieves the cursor's position, in screen coordinates.
        /// </summary>
        /// <see>See MSDN documentation for further information.</see>
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);
        public static Point GetCursorPosition()
        {
            POINT lpPoint;
            GetCursorPos(out lpPoint);
            //bool success = User32.GetCursorPos(out lpPoint);
            // if (!success)

            return lpPoint;
        }

        public static int count = 0,count1 = 1000;
        public static bool check = false;
        public static void battle()
        {
            
            if (Hero.target)
            {
                if (Hero.Range >= Hero.attackRange)
                {
                    // SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.Up, (IntPtr)0);
                    //  System.Windows.Forms.SendKeys.SendWait("W");
                    //keybd_event(0x57, 0, 0, UIntPtr.Zero);
                    InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_W);
                }
                else
                {
                    InputSimulator.SimulateKeyUp(VirtualKeyCode.VK_W);
                    //keybd_event(0x57, 0, 0x02, UIntPtr.Zero);
                    // SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.Up, (IntPtr)0);

                    var task = Task.Factory.StartNew(() =>
                    {
                        Keyboard.BattleKey();
                      
                    });
                    //task.Wait();
                }
                
            } 
            else
            {

                keybd_event(0x57, 0, 0x02, UIntPtr.Zero);
              
                int posX = Convert.ToInt32(GetCursorPosition().X);
                int posY = Convert.ToInt32(GetCursorPosition().Y);
            //    if (count < 1000 && !check)
            //    {
            //        count++;
           //         count1--;
                   // Keyboard.MouseMove(50, 0);
                    //Thread.Sleep(300);
            //        check = true;
            //    }
               /* if (check)
               {
                    count--;
                    count1++;
                    Keyboard.MouseMove(4, 0);
                    if (count1 == 1000)
                    {
                        check = false;
                    }
                }
                */
              //  SetCursorPos(posX+40,posY);
            }
        }

    }
}
