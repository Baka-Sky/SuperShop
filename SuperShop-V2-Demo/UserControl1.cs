using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntdUI;

namespace SuperShop_V2_Demo
{
    public partial class Welcome : UserControl
    {
        UpdateD.Update up = new UpdateD.Update();
        private List<string> quotes = new List<string>();
        private Random random = new Random();
        private Timer timer;

        public Welcome()
        {
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

        private void Welcome_Load(object sender, EventArgs e)
        {
            ClearWebBrowserCache();
            update.Text = up.GetUpdateRem("1F9A4397DB0A47038B5A5247A2DDA6C5");

            Task.Run(() =>
            {
                this.Invoke(new Action(() =>
                {
                    //chromiumWebBrowser1.Load("www.supershop.net.cn/Lo1go.png");
                }));
            });
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
    }
}



