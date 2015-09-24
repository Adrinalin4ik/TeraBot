using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;


namespace TeraBot
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
        [DllImport("user32.dll")]
        public static extern int SendMessageA(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);



        int statsBaseAddress = 0x205d34c;
        //int targetBaseAddress = 0x020a0e94;
        int targetBaseAddress = 0x205d34c; 
        Memory m = new Memory();
        #region Example
        /*
            SetCursorPos(clientPoint.X, clientPoint.Y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, UIntPtr.Zero); /// left mouse button down
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, UIntPtr.Zero); /// left mouse button up
         * 
         * System.Diagnostics.Process.Start("http://vk.com/TeraBot");
         */
        #endregion Example


        public static bool Pause = false;
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();


        public MainWindow()
		{
			this.InitializeComponent();
            SetHook();
            readSettings();
		}


        public static int X, Y;

        private void timerTick(object sender, EventArgs e)
        {
            
            refreshControls();
            Battle.battle();
            //mouse_event(MOUSEEVENTF_LEFTUP, 100, 100, 0, 0);
            X = Convert.ToInt32(textBox2.Text);
            Y = Convert.ToInt32(textBox3.Text);
            if (Pause)
            {
                StopTimers();
            }
        }

        private void AFK_timer_tick(object sender, EventArgs e)
        {
            SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYDOWN, (IntPtr)System.Windows.Forms.Keys.D1, (IntPtr)0);
            SendMessageA(Program.Tera, (int)Keyboard.WMessages.WM_KEYUP, (IntPtr)System.Windows.Forms.Keys.D1, (IntPtr)0);
        }

        private void KeyCheck()
        {
            if (checkBox1.IsChecked==true)
            {
                Keyboard.d1 = true;
                Keyboard.Sleepd1 = Convert.ToInt32(SkillSleep1.Text);
            }
            else Keyboard.d1 = false;

            if (checkBox2.IsChecked == true)
            {
                Keyboard.d2 = true;
                Keyboard.Sleepd2 = Convert.ToInt32(SkillSleep2.Text);
            }
            else Keyboard.d2 = false;
            if (checkBox3.IsChecked == true)
            {
                Keyboard.d3 = true;
                Keyboard.Sleepd3 = Convert.ToInt32(SkillSleep3.Text);
            }
            else Keyboard.d3 = false;
            if (checkBox4.IsChecked == true)
            {
                Keyboard.d4 = true;
                Keyboard.Sleepd4 = Convert.ToInt32(SkillSleep4.Text);
            }
            else Keyboard.d4 = false;
            if (checkBox5.IsChecked == true)
            {
                Keyboard.d5 = true;
                Keyboard.Sleepd5 = Convert.ToInt32(SkillSleep5.Text);
            }
            else Keyboard.d5 = false;
            if (checkBox6.IsChecked == true)
            {
                Keyboard.d6 = true;
                Keyboard.Sleepd6 = Convert.ToInt32(SkillSleep6.Text);
            }
            else Keyboard.d6 = false;
            if (checkBox7.IsChecked == true)
            {
                Keyboard.d7 = true;
                Keyboard.Sleepd7 = Convert.ToInt32(SkillSleep7.Text);
            }
            else Keyboard.d7 = false;
            if (checkBox8.IsChecked == true)
            {
                Keyboard.d8 = true;
                Keyboard.Sleepd8 = Convert.ToInt32(SkillSleep8.Text);
            }
            else Keyboard.d8 = false;
            if (checkBox9.IsChecked == true)
            {
                Keyboard.d9 = true;
                Keyboard.Sleepd9 = Convert.ToInt32(SkillSleep9.Text);
            }
            else Keyboard.d9 = false;
            if (checkBox10.IsChecked == true)
            {
                Keyboard.d0 = true;
                Keyboard.Sleepd0 = Convert.ToInt32(SkillSleep10.Text);
            }
            else Keyboard.d0 = false;
            if (checkBox11.IsChecked == true)
            {
                Keyboard.f1 = true;
                Keyboard.Sleepf1 = Convert.ToInt32(SkillSleep11.Text);
            }
            else Keyboard.f1 = false;
            if (checkBox12.IsChecked == true)
            {
                Keyboard.f2 = true;
                Keyboard.Sleepf2 = Convert.ToInt32(SkillSleep12.Text);
            }
            else Keyboard.f2 = false;
            if (checkBox13.IsChecked == true)
            {
                Keyboard.f3 = true;
                Keyboard.Sleepf3 = Convert.ToInt32(SkillSleep13.Text);
            }
            else Keyboard.f3 = false;
            if (checkBox14.IsChecked == true)
            {
                Keyboard.f4 = true;
                Keyboard.Sleepf4 = Convert.ToInt32(SkillSleep14.Text);
            }
            else Keyboard.f4 = false;
            if (checkBox15.IsChecked == true)
            {
                Keyboard.f5 = true;
                Keyboard.Sleepf5 = Convert.ToInt32(SkillSleep15.Text);
            }
            else Keyboard.f5 = false;
            if (checkBox16.IsChecked == true)
            {
                Keyboard.f6 = true;
                Keyboard.Sleepf6 = Convert.ToInt32(SkillSleep16.Text);
            }
            else Keyboard.f6 = false;
            if (checkBox17.IsChecked == true)
            {
                Keyboard.f7 = true;
                Keyboard.Sleepf7 = Convert.ToInt32(SkillSleep17.Text);
            }
            else Keyboard.f7 = false;
            if (checkBox18.IsChecked == true)
            {
                Keyboard.f8 = true;
                Keyboard.Sleepf8 = Convert.ToInt32(SkillSleep18.Text);
            }
            else Keyboard.f8 = false;
            if (checkBox19.IsChecked == true)
            {
                Keyboard.f9 = true;
                Keyboard.Sleepf9 = Convert.ToInt32(SkillSleep19.Text);
            }
            else Keyboard.f9 = false;
            if (checkBox20.IsChecked == true)
            {
                Keyboard.f10 = true;
                Keyboard.Sleepf10 = Convert.ToInt32(SkillSleep20.Text);
            }
            else Keyboard.f10 = false;
        }
        public void StartTimers()
        {
           
            
            if (checkAFK.IsChecked == true)
            {
                timer.Tick += new EventHandler(AFK_timer_tick);
                timer.Interval = new TimeSpan(0, 0, 20);
                timer.Start();
            }
            else
            {
                timer.Tick += new EventHandler(timerTick);
                timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
                timer.Start();
            }
        }
        public void StopTimers() 
        {
            timer.IsEnabled = false;
        }


        private void saveSettings()
        {
            StreamWriter sw = File.AppendText("Setting.tb");
            sw.WriteLine(textBox1.Text);
            sw.WriteLine(skillPauseBox.Text);
            #region SkillSleep
            sw.WriteLine(SkillSleep1.Text);
            sw.WriteLine(SkillSleep2.Text);
            sw.WriteLine(SkillSleep3.Text);
            sw.WriteLine(SkillSleep4.Text);
            sw.WriteLine(SkillSleep5.Text);
            sw.WriteLine(SkillSleep6.Text);
            sw.WriteLine(SkillSleep7.Text);
            sw.WriteLine(SkillSleep8.Text);
            sw.WriteLine(SkillSleep9.Text);
            sw.WriteLine(SkillSleep10.Text);
            sw.WriteLine(SkillSleep11.Text);
            sw.WriteLine(SkillSleep12.Text);
            sw.WriteLine(SkillSleep13.Text);
            sw.WriteLine(SkillSleep14.Text);
            sw.WriteLine(SkillSleep15.Text);
            sw.WriteLine(SkillSleep16.Text);
            sw.WriteLine(SkillSleep17.Text);
            sw.WriteLine(SkillSleep18.Text);
            sw.WriteLine(SkillSleep19.Text);
            sw.WriteLine(SkillSleep20.Text);
            #endregion
            sw.Close();
        }
        private void readSettings()
        {
            StreamReader sr = new StreamReader("Setting.tb");
            textBox1.Text = sr.ReadLine();
            skillPauseBox.Text = sr.ReadLine();
            #region SkillSleep
            SkillSleep1.Text = sr.ReadLine();
            SkillSleep2.Text = sr.ReadLine();
            SkillSleep3.Text = sr.ReadLine();
            SkillSleep4.Text = sr.ReadLine();
            SkillSleep5.Text = sr.ReadLine();
            SkillSleep6.Text = sr.ReadLine();
            SkillSleep7.Text = sr.ReadLine();
            SkillSleep8.Text = sr.ReadLine();
            SkillSleep9.Text = sr.ReadLine();
            SkillSleep10.Text = sr.ReadLine();
            SkillSleep11.Text = sr.ReadLine();
            SkillSleep12.Text = sr.ReadLine();
            SkillSleep13.Text = sr.ReadLine();
            SkillSleep14.Text = sr.ReadLine();
            SkillSleep15.Text = sr.ReadLine();
            SkillSleep16.Text = sr.ReadLine();
            SkillSleep17.Text = sr.ReadLine();
            SkillSleep18.Text = sr.ReadLine();
            SkillSleep19.Text = sr.ReadLine();
            SkillSleep20.Text = sr.ReadLine();
            #endregion
            sr.Close();
        }
        #region mousecontrol
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }  
        private void rectangle1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            saveSettings();
            Process.GetCurrentProcess().Kill();
        }

        private void label9_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("http://vk.com/TeraBot");
        }
        #endregion mousecontrol

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pause = false;
            KeyCheck();
            Program.GetWindow();
            m.GetProcess("TERA");
            StartTimers();

            Hero.attackRange = Convert.ToInt32(textBox1.Text);
        }
         
        public void RefreshValue()
        {
            Hero.CurrentHp = m.ReadMemory(statsBaseAddress, offsets.CurrentHP);
            Hero.CurrentMp = m.ReadMemory(statsBaseAddress, offsets.CurrentMP);
            Hero.FullHp = m.ReadMemory(statsBaseAddress, offsets.FullHP);
            Hero.FullMp = m.ReadMemory(statsBaseAddress, offsets.FullMP);
            Hero.PosX = m.ReadMemory(statsBaseAddress, offsets.PosX);
            Hero.PosY = m.ReadMemory(statsBaseAddress, offsets.PosY);
            Hero.PosZ = m.ReadMemory(statsBaseAddress, offsets.PosZ);

            Hero.Range = m.ReadMemory(targetBaseAddress, offsets.Range);

            if (Hero.Range >= 0)
            {
                Hero.target = true;
            }
            else Hero.target = false;
            
        }

        public void refreshControls()
        {
            RefreshValue();
            progressBar1.Maximum = Hero.FullHp;
            progressBar1.Value = Hero.CurrentHp;

            progressBar2.Maximum = Hero.FullMp;
            progressBar2.Value = Hero.CurrentMp;
            label4.Content = Convert.ToString(Hero.CurrentHp+"/"+Hero.FullHp);
            label5.Content = Convert.ToString(Hero.CurrentMp + "/" + Hero.FullMp);

            label14.Content = Convert.ToString(Hero.PosX);
            label15.Content = Convert.ToString(Hero.PosY);
            label19.Content = Convert.ToString(Hero.PosZ);

            label1.Content = Convert.ToString("("+Hero.Range+")");
            Keyboard.PauseBetweenSkills = Convert.ToInt32(skillPauseBox.Text);
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StopTimers();
        }


        #region KeyboardHook
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        const int WH_KEYBOARD_LL = 13; // Номер глобального LowLevel-хука на клавиатуру
        const int WM_KEYDOWN = 0x100; // Сообщения нажатия клавиши

        private LowLevelKeyboardProc _proc = hookProc;

        private static IntPtr hhook = IntPtr.Zero;

        public void SetHook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, hInstance, 0);
        }

        public static void UnHook()
        {
            UnhookWindowsHookEx(hhook);
        }


        public string TextMessage;
        
        public static IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
        {

            int vkCode = Marshal.ReadInt32(lParam);

            //MessageBox.Show(Convert.ToString(vkCode));//160
            if (vkCode == 115) //F4
            {
                Process.GetCurrentProcess().Kill();

              
                return (IntPtr)1;
            }

            if (vkCode == 114)//запуск
            {
                Keyboard.MouseMove((uint)X, (uint)Y);
                return (IntPtr)1;
            }

            if (vkCode == 113)//F2
            {
                Pause = true;
                return (IntPtr)1;
            }
            else
            {
                return CallNextHookEx(hhook, code, (int)wParam, lParam);
            }
            //return CallNextHookEx(hhook, code, (int)wParam, lParam);
        }
        #endregion
    }
}