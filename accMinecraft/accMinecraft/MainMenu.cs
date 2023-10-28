using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accMinecraft
{
    public partial class MainMenu : Form
    {
        #region Dll

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        #endregion

        public static bool check = true;

        public static KeysConverter Key = new KeysConverter();

        Process[] processes = Process.GetProcessesByName("javaw");
        public MainMenu()
        {
            InitializeComponent();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        #region Bind
        private void btnLeftBind_Click(object sender, EventArgs e)
        {
            btnLeftBind.Text = "...";
        }

        private void btnRightBind_Click(object sender, EventArgs e)
        {
            btnRightBind.Text = "...";
        }

        private void leftBind_Tick(object sender, EventArgs e)
        {
            if (btnLeftBind.Text != "None" && btnLeftBind.Text != "...")
            {
                Keys key = (Keys)Key.ConvertFromString(btnLeftBind.Text);

                if (GetAsyncKeyState(key) < 0)
                {
                    chLeftButt.Checked = !chLeftButt.Checked;
                }
            }
        }

        private void btnLeftBind_KeyUp(object sender, KeyEventArgs e)
        {
            if (btnLeftBind.Text == "...")
            {
                if (GetAsyncKeyState(Keys.Escape) < 0)
                {
                    btnLeftBind.Text = "None";
                }
                else
                {
                    btnLeftBind.Text = e.KeyCode.ToString();
                }
            }
        }

        private void btnRightBind_KeyUp(object sender, KeyEventArgs e)
        {
            if (btnRightBind.Text == "...")
            {
                if (GetAsyncKeyState(Keys.Escape) < 0)
                {
                    btnRightBind.Text = "None";
                }
                else
                {
                    btnRightBind.Text = e.KeyCode.ToString();
                }
            }
        }

        private void rightBind_Tick(object sender, EventArgs e)
        {
            if (btnRightBind.Text != "None" && btnRightBind.Text != "...")
            {
                Keys key = (Keys)Key.ConvertFromString(btnRightBind.Text);

                if (GetAsyncKeyState(key) < 0)
                {
                    chRightButt.Checked = !chRightButt.Checked;
                }
            }
        }

        #endregion

        #region track
        private void trackClick_Scroll(object sender, EventArgs e)
        {
            lblLeftCPS.Text = $"CPS: {tbLeft.Value}";
        }
        private void tbRight_Scroll(object sender, EventArgs e)
        {
            lblRightCPS.Text = $"CPS: {tbRight.Value}";
        }
        #endregion

        #region mainAcc
        private void LeftAcc_Tick(object sender, EventArgs e)
        {
            leftClicker.Interval = 1000 / tbLeft.Value;

            foreach (Process process in processes)
            {
                if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                {
                    if (chLeftButt.Checked)
                    {
                        if (MouseButtons == MouseButtons.Left)
                        {
                            SendMessage(GetForegroundWindow(), 0x201, 0, 0);
                            Task.Delay(25).Wait();
                            SendMessage(GetForegroundWindow(), 0x202, 0, 0);
                        }
                    }
                }
            }
        }

        private void rightClicker_Tick(object sender, EventArgs e)
        {
            rightClicker.Interval = 1000 / tbRight.Value;

            foreach (Process process in processes)
            {
                if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                {
                    if (chRightButt.Checked)
                    {
                        if (MouseButtons == MouseButtons.Right)
                        {
                            SendMessage(GetForegroundWindow(), 0x204, 0, 0);
                            Task.Delay(25).Wait();
                            SendMessage(GetForegroundWindow(), 0x205, 0, 0);
                        }
                    }
                }
            }
        }

        #endregion
    }
}
