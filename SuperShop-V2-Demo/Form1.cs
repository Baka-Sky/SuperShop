using AntdUI;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace SuperShop_V2_Demo
{
    public partial class Form1 : BaseForm
    {
        private float progressValue = 0; // 用于跟踪进度条的当前值
        private Form2 form2;
        public SansError f1;
        private static List<string> _installedFonts;

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load); // 订阅Load事件

            text.Text = "加载字体列表";
            LoadInstalledFonts(); // 加载已安装的字体列表
        }

        public static class GlobalSettings
        {
            public static int R { get; set; }
            public static int G { get; set; }
            public static int B { get; set; }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await Task.Delay(100); // 异步等待0.1秒

            // 获取系统主题色
            text.Text = "获取Windows主题色";
            Color windowsThemeColor;
            try
            {
                windowsThemeColor = GetSystemAccentColor(); // 获取系统主题色
                Console.WriteLine($"Windows 主题色: {windowsThemeColor.R}, {windowsThemeColor.G}, {windowsThemeColor.B}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                windowsThemeColor = Color.Empty; // 如果发生异常，设置为默认值
            }

            text.Text = "保存配置文件";
            // 将系统主题色保存到 RGB.txt 文件
            string rgbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RGB.txt");
            string rgbText = $"{windowsThemeColor.R}, {windowsThemeColor.G}, {windowsThemeColor.B}";
            File.WriteAllText(rgbFilePath, rgbText);

            // 执行自检
            text.Text = "自检启动";
            await CheckFontsAndLoadForm();
        }

        private Color GetSystemAccentColor()
        {
            using (RegistryKey dwm = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\DWM", false))
            {
                if (dwm != null && dwm.GetValueNames().Contains("AccentColor"))
                {
                    // 读取 AccentColor 值
                    int accentColor = (int)dwm.GetValue("AccentColor");
                    // 注意：读取到的颜色格式为 AABBGGRR
                    return Color.FromArgb(
                        (byte)((accentColor >> 24) & 0xFF), // Alpha
                        (byte)(accentColor & 0xFF),         // Red
                        (byte)((accentColor >> 8) & 0xFF),  // Green
                        (byte)((accentColor >> 16) & 0xFF)  // Blue
                    );
                }
            }
            return SystemColors.Window; // 如果读取失败，返回默认窗口颜色
        }

        private async Task CheckFontsAndLoadForm()
        {
            int totalChecks = 5; // 假设总共有5个检查项

            // 字体检查
            text.Text = "MiSans检查";
            string fontName = "MiSans";
            if (IsFontInstalled(fontName))
            {
                UpdateProgress(1f / totalChecks); // 更新进度条
            }
            else
            {
                f1 = new SansError();
                f1.Show();
                this.Hide();
                return; // 退出方法
            }

            // 文件夹检查
            // ...（此处可以添加其他检查逻辑）

            text.Text = "完成";
            text.Text = "正在启动";
            form2 = new Form2();
            form2.Show();
            this.Hide(); // 关闭Form1，释放资源
        }

        private bool IsFontInstalled(string fontName)
        {
            return _installedFonts.Contains(fontName.ToLowerInvariant());
        }

        private void UpdateProgress(float increment)
        {
            progressValue += increment;
            if (progressValue > 1) progressValue = 1; // 确保不超过100%
            progress1.Value = (int)(progressValue * 100);
            progress1.Text = $"{(int)(progressValue * 100)}%";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    GlobalSettings.R = selectedColor.R;
                    GlobalSettings.G = selectedColor.G;
                    GlobalSettings.B = selectedColor.B;
                }
            }
        }

        private void LoadInstalledFonts()
        {
            _installedFonts = new List<string>();
            InstalledFontCollection fontsCollection = new InstalledFontCollection();
            foreach (FontFamily family in fontsCollection.Families)
            {
                _installedFonts.Add(family.Name.ToLowerInvariant());
            }
        }
    }
}