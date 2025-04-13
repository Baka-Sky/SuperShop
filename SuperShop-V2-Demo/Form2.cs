using AntdUI;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop_V2_Demo
{
    public partial class Form2 : BaseForm
    {
        private ConfigManager configManager;
        public static string appUp = "none";
        private UpdateD.Update up = new UpdateD.Update();
        public Set f5; // 设置页面

        public Welcome f1;
        public App f2;
        public Tools f3;
        public about f4;
        public SansError f6;
        public More f7;

        private UserControl currentControl; // 当前显示的用户控件
        private UserControl previousControl; // 上一个用户控件

        public Form2()
        {
            InitializeComponent();
            InitializeConfigManagers();
            LoadGlobalSettings();
            InitializeUI();
        }

        private void InitializeConfigManagers()
        {
            configManager = new ConfigManager();
        }

        private void LoadGlobalSettings()
        {
            var (r, g, b) = configManager.LoadConfig();
            GlobalSettings.R = r;
            GlobalSettings.G = g;
            GlobalSettings.B = b;
        }

        private void InitializeUI()
        {
            windowBar1.SubText = "Version " + Version.Text;
            SetControlBackgroundColor();
        }

        public static class GlobalSettings
        {
            public static int R { get; set; }
            public static int G { get; set; }
            public static int B { get; set; }
        }

        private void SetControlBackgroundColor()
        {
            string path1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WindowsRGB.txt");
            string readText1 = File.ReadAllText(path1);

            if (readText1 == "1")
            {
                string path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RGB.txt");
                string readText2 = File.ReadAllText(path2);

                string[] rgbValues = readText2.Split(',');
                int r = int.Parse(rgbValues[0].Trim());
                int g = int.Parse(rgbValues[1].Trim());
                int b = int.Parse(rgbValues[2].Trim());
                windowBar1.BackColor = System.Drawing.Color.FromArgb(r, g, b);
                Home.DefaultBack = windowBar1.BackColor;
                Dwn.DefaultBack = windowBar1.BackColor;
                tools.DefaultBack = windowBar1.BackColor;
                Set.DefaultBack = windowBar1.BackColor;
                About.DefaultBack = windowBar1.BackColor;
            }
            else
            {
                windowBar1.BackColor = System.Drawing.Color.FromArgb(GlobalSettings.R, GlobalSettings.G, GlobalSettings.B);
                Home.DefaultBack = windowBar1.BackColor;
                Dwn.DefaultBack = windowBar1.BackColor;
                tools.DefaultBack = windowBar1.BackColor;
                Set.DefaultBack = windowBar1.BackColor;
                About.DefaultBack = windowBar1.BackColor;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否确认关闭？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Process.GetCurrentProcess().Kill();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitializeForms();
            ShowWelcomeForm();
            CheckForUpdates();
        }

        private void InitializeForms()
        {
            f1 = new Welcome();
            f2 = new App();
            f3 = new Tools();
            f4 = new about();
            f5 = new Set { MainForm = this }; // 将 Form2 的引用传递给 Set 控件
            f6 = new SansError();
            f7 = new More(this); // 将 Form2 的引用传递给 More 控件
        }

        private void ShowWelcomeForm()
        {
            ShowUserControl(f1);
        }

        private void ShowUserControl(UserControl userControl)
        {
            previousControl = currentControl; // 保存当前控件为上一个控件
            currentControl = userControl; // 更新当前控件

            UesrPanel.Controls.Clear();
            UesrPanel.Controls.Add(currentControl);
            currentControl.Show();
        }



        private void CheckForUpdates()
        {
            Task.Run(() =>
            {
                this.Invoke(new Action(() =>
                {
                    if (up.GetUpdate("1F9A4397DB0A47038B5A5247A2DDA6C5", Version.Text))
                    {
                        Task.Delay(3500);
                        windowBar1.Loading = true;
                        windowBar1.Text = "有新更新! 2秒后启动更新服务!";

                        appUp = up.GetUpdateFile("1F9A4397DB0A47038B5A5247A2DDA6C5");
                        Task.Delay(2000);
                        Process.Start(new ProcessStartInfo("iexplore.exe", appUp) { UseShellExecute = true });
                    }
                    else
                    {
                        windowBar1.Loading = false;
                        windowBar1.Text = "超级小铺";
                    }
                }));
            });
        }

        private void Home_Click(object sender, EventArgs e)
        {
            ShowUserControl(f1);
        }

        private void Dwn_Click(object sender, EventArgs e)
        {
            ShowUserControl(f2);
        }

        private void tools_Click(object sender, EventArgs e)
        {
            ShowUserControl(f3);
        }

        private void About_Click(object sender, EventArgs e)
        {
            ShowUserControl(f4);
        }

        private void Set_Click(object sender, EventArgs e)
        {
            ShowUserControl(f7);
        }
    }
}