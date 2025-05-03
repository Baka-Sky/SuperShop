using AntdUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop_V2_Demo
{
    public partial class Welcome : UserControl
    {

        public string network;
        UpdateD.Update up = new UpdateD.Update();
        private List<string> quotes = new List<string>();
        private Random random = new Random();
        private Timer timer;
        //public Form2 f1;

        public Welcome()
        {
            //f1 = new Form2();
            //ifnetwork();

            InitializeComponent();
            // 初始化每日一言列表

            update.Multiline = true;

            // 设置定时器
            timer = new Timer();
            timer.Interval = 1000; // 每秒更新一次时间
            timer.Tick += Timer_Tick;
            timer.Start();
        }



        private void Timer_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString();
        }

        private async void Welcome_Load(object sender, EventArgs e)
        {
            // 等待网络检测完成
            await ifnetwork();

            // MessageBox.Show("1"); // 调试用，确认执行到这里

            // 直接在UI线程更新
            if (network == "yes")
            {
                ClearWebBrowserCache();
                update.Text = up.GetUpdateRem("1F9A4397DB0A47038B5A5247A2DDA6C5");

                // 异步加载网页内容
                await Task.Run(() =>
                {
                    // 这里不需要Invoke，因为不涉及UI操作
                    // 如果有UI操作，应该在这里收集数据，然后在外面更新UI
                });

                // 如果需要更新UI
                // chromiumWebBrowser1.Load("www.supershop.net.cn/Lo1go.png");
            }
            else if (network == "no")
            {
                update.Text = "超级小铺因检测到您的设备处于无网络环境，已自动进入离线模式！";
            }
        }





        private void FindSky_Click(object sender, EventArgs e)
        {
            SkyLabel.Multiline = true;

            cn.com.webxml.www.WeatherWebService w = new cn.com.webxml.www.WeatherWebService();
            // 把webservice当做一个类来操作

            string[] s = new string[23]; // 声明string数组存放返回结果
            string city = this.Skyinput.Text.Trim(); // 获得文本框录入的查询城市
            s = w.getWeatherbyCityName(city); // 以文本框内容为变量实现方法getWeatherbyCityName
            if (s[8] == "")
            {
                MessageBox.Show("暂时不支持您查询的城市");
            }
            else
            {
                SkyLabel.Text = s[10];
            }
        }


        private void update_TextChanged(object sender, EventArgs e)
        {
            // 不需要做任何事情
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // 不需要做任何事情
        }

        // 定义外部方法
        [DllImport("wininet.dll", SetLastError = true)]
        private static extern bool InternetClearAllPerSiteCookieDecisions();

        [DllImport("wininet.dll", SetLastError = true)]
        private static extern bool InternetCloseHandle(IntPtr hInternet);

        [DllImport("wininet.dll", SetLastError = true)]
        private static extern IntPtr InternetOpen(string lpszAgent, int dwAccessType, string lpszProxy, string lpszProxyBypass, int dwFlags);

        private const int INTERNET_OPEN_TYPE_PRECONFIG = 0;

        // 清除WebBrowser缓存的方法
        private void ClearWebBrowserCache()
        {
            IntPtr internetHandle = InternetOpen("ClearBrowserCache", INTERNET_OPEN_TYPE_PRECONFIG, null, null, 0);
            if (internetHandle != IntPtr.Zero)
            {
                InternetClearAllPerSiteCookieDecisions(); // 清除所有网站的Cookie决策
                InternetCloseHandle(internetHandle);
            }
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    if (timer != null)
        //    {
        //        timer.Stop();
        //        timer.Dispose();
        //        timer = null;
        //    }
        //    base.Dispose(disposing);
        //}

        // 新增的 Dispose1 方法
        protected virtual void Dispose1(bool disposing)
        {
            if (disposing)
            {
                if (timer != null)
                {
                    timer.Stop();
                    timer.Dispose();
                    timer = null;
                }
            }
            base.Dispose(disposing);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        public async Task ifnetwork()  // 改为返回Task而不是async void
        {
            bool isConnected = await Task.Run(() => PingBaidu());
            network = isConnected ? "yes" : "no";
        }

        public bool PingBaidu()
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send("www.baidu.com", 2000);
                    return reply.Status == IPStatus.Success;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}



