using AntdUI;
using System;
using System.Diagnostics;
using System.Drawing; // 确保引用了 System.Drawing 命名空间
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop_V2_Demo
{
    public partial class Set : UserControl
    {
        private string configFilePath = "shop.config"; // 用于存储其他配置
        private string configFilePath1 = "shopBtn.config"; // 用于存储按钮颜色配置
        private string configFilePath2 = "WindowsRGB.config"; // 用于存储Windows主题色配置
        private string configFilePath3 = "RGB.txt";
        public string exefile;

        public string filePath = "directory.txt";
        //string content = "";

        

        public Form2 MainForm { get; set; }// 用于存储开关状态的配置文件

        string app = AppDomain.CurrentDomain.BaseDirectory;

        [DllImport("dwmapi.dll", PreserveSig = false)]
        public static extern void DwmGetColorizationColor(out int pcrColorization, out bool pfOpaqueBlend);

        public static Color GetColor(int argb) => Color.FromArgb(argb);


        public Set()
        {
            InitializeComponent();
            EnsureConfigFileExists(configFilePath);
            EnsureConfigFileExists(configFilePath1);
            EnsureConfigFileExists(configFilePath2);
            EnsureConfigFileExists(configFilePath3);

        }

        // 确保配置文件存在
        private void EnsureConfigFileExists(string filePath)
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose(); // 创建空文件
            }
        }

        // 加载开关的初始状态

        // 写入开关状态到 RGB.config 文件
        private void WriteSwitchStatus(string status)
        {
            try
            {
                File.WriteAllText(configFilePath3, status);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"写入配置文件时发生错误：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 读取开关状态
        private string ReadSwitchStatus()
        {
            if (File.Exists(configFilePath3))
            {
                string[] lines = File.ReadAllLines(configFilePath3);
                if (lines.Length > 0)
                {
                    return lines[0];
                }
            }
            return "0"; // 默认为关闭
        }

        // 开关状态改变事件


        // 其他已有代码保持不变
        private void timer1_Tick(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                if (this.IsHandleCreated)
                    this.Invoke(new Action(() =>
                    {
                        this.label4.Text = DateTime.Now.ToString();
                    }));
            });



        }

        private void label8_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                File.WriteAllText(configFilePath1, $"RGB={selectedColor.R},{selectedColor.G},{selectedColor.B}");
            }
        }

        private void colorPicker1_ValueChanged(object sender, ColorEventArgs e)
        {
            Color selectedColor = e.Value;
            File.WriteAllText(configFilePath, $"RGB={selectedColor.R},{selectedColor.G},{selectedColor.B}");
        }

        private void color_MouseClick(object sender, MouseEventArgs e)
        {
            Color selectedColor = color.Value;
            File.WriteAllText(configFilePath1, $"RGB={selectedColor.R},{selectedColor.G},{selectedColor.B}");
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(configFilePath))
            {
                writer.WriteLine("RGB=230,230,250");
            }
            MessageBox.Show("完成！");
        }

        private void Set_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.Invoke(new Action(() =>
                {
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WindowsRGB.txt");
                    string readText = File.ReadAllText(path);

                    string path1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "run.txt");
                    string readText1 = File.ReadAllText(path);


                    if (readText == "1")
                    {
                        switch1.Checked = true;
                    }
                    else
                    {
                        switch1.Checked = false;
                    }



                }));

                Task.Run(() =>
                {
                    if (switch1.Checked == true)
                    {

                        panel3.Enabled = false;
                        label7.Text = "SuperShop主题色(需要重启超级小铺)";
                    };

                    if (switch1.Checked == false)
                    {
                        panel3.Enabled = true;
                    };

                });


            });

            filetext.Text = File.ReadAllText(filePath);
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            GC.Collect();
            MessageBox.Show("完成!");
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                // 启动其他程序
            });
        }

        private void switch1_CheckedChanged(object sender, BoolEventArgs e)
        {
            Task.Run(() =>
            {
                if (switch1.Checked == true)
                {
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WindowsRGB.txt");
                    string Text = "1";
                    File.WriteAllText(path, Text);


                    panel3.Enabled = false;
                    label7.Text = "SuperShop主题色(需要重启超级小铺)";
                    

                };

                if (switch1.Checked == false)
                {
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WindowsRGB.txt");
                    string Text = "0";
                    File.WriteAllText(path, Text);
                    
                    panel3.Enabled = true;
                    

                };
            });
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            // 获取系统架构
            string architecture = Environment.Is64BitOperatingSystem ? "64位" : "32位";

            // 获取操作系统版本
            var osVersionInfo = FileVersionInfo.GetVersionInfo(Environment.SystemDirectory + @"\kernel32.dll");

            // 构建系统信息字符串
            string systemInfo = $"操作系统版本: {Environment.OSVersion.VersionString}\r\n" +
                                $"系统架构: {architecture}\r\n" +
                                $".NET 版本: {Environment.Version}\r\n" +
                                $"当前程序集路径: {AppDomain.CurrentDomain.BaseDirectory}\r\n" +
                                $"当前程序集版本: {System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}";

            // 显示系统信息
            MessageBox.Show(systemInfo);
        }

        private void fanhui_Click(object sender, EventArgs e)
        {
            //MainForm.GoBack();
        }

        private void panel4_Click(object sender, EventArgs e)
        {

        }

        private void file_Click(object sender, EventArgs e)
        {

            //exe文件夹选择器 会保存txt文件 别问我为啥要这样做，怪C#关闭就失忆了
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.SelectedPath = exefile;
            folderBrowser.Description = "请选择小铺默认下载目录";
            //folderBrowser.ShowNewFolderButton = true;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                this.filetext.Text = folderBrowser.SelectedPath;

                File.WriteAllText(filePath, filetext.Text);
            }

        }
    }
}