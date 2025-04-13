using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntdUI;
//using AntdUI.Controls; // 确保正确引用了AntdUI的命名空间

namespace SuperShop_V2_Demo
{
    public partial class Tools : UserControl
    {
        public Tools()
        {
            InitializeComponent();


        }


        public Form2 form;
           
        


        private void Yes_Click(object sender, EventArgs e)
        {
            // 获取软件运行目录
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string zipFilePath = Path.Combine(appDirectory, "shoptools.zip");
            string extractPath = Path.Combine(appDirectory, "tools");

            // 检查ZIP文件是否存在
            if (!File.Exists(zipFilePath))
            {
                MessageBox.Show("shoptools.zip 文件不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 如果目标文件夹不存在，则创建它
            if (!Directory.Exists(extractPath))
            {
                Directory.CreateDirectory(extractPath);
            }

            try
            {
                // 解压ZIP文件
                ZipFile.ExtractToDirectory(zipFilePath, extractPath);
                MessageBox.Show("解压完成！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                info.Hide();

                toolspanel1.Show();
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"访问被拒绝：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show($"目录未找到：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"I/O 错误：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发生错误：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tools_Load(object sender, EventArgs e)
        {

            form = new Form2();

            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string shoptoolsPath = Path.Combine(appDirectory, "tools");

            // 检测是否存在shoptools文件夹
            if (Directory.Exists(shoptoolsPath))
            {
                info.Hide();
                
                toolspanel1.Show();
            }
            else
            {
                info.Show();
                toolspanel1.Hide();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                if (this.IsHandleCreated)
                    this.Invoke(new Action(() =>
                    {
                        this.Time.Text = DateTime.Now.ToString();
                    }));
            });
        }

        private void toolspanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void aida64btn_Click(object sender, EventArgs e)
        {

            Task task = Task.Run(() =>
            {
                try
                {
                    // 获取当前程序的运行目录
                    string currentDir = AppDomain.CurrentDomain.BaseDirectory;

                    // 拼接目标文件路径
                    string targetFilePath = Path.Combine(currentDir, "tools", "AIDA64", "aida64.exe");

                    // 检查文件是否存在
                    if (!File.Exists(targetFilePath))
                    {
                        Console.WriteLine("文件不存在: " + targetFilePath);
                        return;
                    }

                    // 启动文件
                    Process.Start(targetFilePath);
                    Console.WriteLine("AIDA64 已启动");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("启动AIDA64时出错: " + ex.Message);
                }
            });
            
        }

        private void ASSSDBenchmarkbtn_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                try
                {
                    // 获取当前程序的运行目录
                    string currentDir = AppDomain.CurrentDomain.BaseDirectory;

                    // 拼接目标文件路径
                    string targetFilePath = Path.Combine(currentDir, "tools", "ASSSDBenchmark", "ASSSDBenchmark.exe");

                    // 检查文件是否存在
                    if (!File.Exists(targetFilePath))
                    {
                        Console.WriteLine("文件不存在: " + targetFilePath);
                        return;
                    }

                    // 启动文件
                    Process.Start(targetFilePath);
                    Console.WriteLine("已启动");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("启动时出错: " + ex.Message);
                }
            });
        }

        private void CoreTempbtn_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                try
                {
                    // 获取当前程序的运行目录
                    string currentDir = AppDomain.CurrentDomain.BaseDirectory;

                    // 拼接目标文件路径
                    string targetFilePath = Path.Combine(currentDir, "tools", "CoreTemp", "Core Temp x64.exe");

                    // 检查文件是否存在
                    if (!File.Exists(targetFilePath))
                    {
                        Console.WriteLine("文件不存在: " + targetFilePath);
                        return;
                    }

                    // 启动文件
                    Process.Start(targetFilePath);
                    Console.WriteLine("已启动");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("启动时出错: " + ex.Message);
                }
            });
        }

        private void CPUZbtn_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                try
                {
                    // 获取当前程序的运行目录
                    string currentDir = AppDomain.CurrentDomain.BaseDirectory;

                    // 拼接目标文件路径
                    string targetFilePath = Path.Combine(currentDir, "tools", "CPUZ", "cpuz_x64.exe");

                    // 检查文件是否存在
                    if (!File.Exists(targetFilePath))
                    {
                        Console.WriteLine("文件不存在: " + targetFilePath);
                        return;
                    }

                    // 启动文件
                    Process.Start(targetFilePath);
                    Console.WriteLine("已启动");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("启动时出错: " + ex.Message);
                }
            });
        }

        private void CrystalDiskInfo64_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                try
                {
                    // 获取当前程序的运行目录
                    string currentDir = AppDomain.CurrentDomain.BaseDirectory;

                    // 拼接目标文件路径
                    string targetFilePath = Path.Combine(currentDir, "tools", "CrystalDiskInfo", "DiskInfo64S.exe");

                    // 检查文件是否存在
                    if (!File.Exists(targetFilePath))
                    {
                        Console.WriteLine("文件不存在: " + targetFilePath);
                        return;
                    }

                    // 启动文件
                    Process.Start(targetFilePath);
                    Console.WriteLine("已启动");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("启动时出错: " + ex.Message);
                }
            });
        }

        private void CrystalDiskInfo32_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                try
                {
                    // 获取当前程序的运行目录
                    string currentDir = AppDomain.CurrentDomain.BaseDirectory;

                    // 拼接目标文件路径
                    string targetFilePath = Path.Combine(currentDir, "tools", "CrystalDiskInfo", "DiskInfo32S.exe");

                    // 检查文件是否存在
                    if (!File.Exists(targetFilePath))
                    {
                        Console.WriteLine("文件不存在: " + targetFilePath);
                        return;
                    }

                    // 启动文件
                    Process.Start(targetFilePath);
                    Console.WriteLine("已启动");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("启动时出错: " + ex.Message);
                }
            });
        }

        private void CrystalDiskMark64_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                try
                {
                    // 获取当前程序的运行目录
                    string currentDir = AppDomain.CurrentDomain.BaseDirectory;

                    // 拼接目标文件路径
                    string targetFilePath = Path.Combine(currentDir, "tools", "CrystalDiskMark", "DiskMark64S.exe");

                    // 检查文件是否存在
                    if (!File.Exists(targetFilePath))
                    {
                        Console.WriteLine("文件不存在: " + targetFilePath);
                        return;
                    }

                    // 启动文件
                    Process.Start(targetFilePath);
                    Console.WriteLine("已启动");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("启动时出错: " + ex.Message);
                }
            });
        }

        private void CrystalDiskMark32_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                try
                {
                    // 获取当前程序的运行目录
                    string currentDir = AppDomain.CurrentDomain.BaseDirectory;

                    // 拼接目标文件路径
                    string targetFilePath = Path.Combine(currentDir, "tools", "CrystalDiskMark", "DiskMark32S.exe");

                    // 检查文件是否存在
                    if (!File.Exists(targetFilePath))
                    {
                        Console.WriteLine("文件不存在: " + targetFilePath);
                        return;
                    }

                    // 启动文件
                    Process.Start(targetFilePath);
                    Console.WriteLine("已启动");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("启动时出错: " + ex.Message);
                }
            });
        }

        private void FurMark64_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                try
                {
                    // 获取当前程序的运行目录
                    string currentDir = AppDomain.CurrentDomain.BaseDirectory;

                    // 拼接目标文件路径
                    string targetFilePath = Path.Combine(currentDir, "tools", "FurMark", "FurMark_GUI.exe");

                    // 检查文件是否存在
                    if (!File.Exists(targetFilePath))
                    {
                        Console.WriteLine("文件不存在: " + targetFilePath);
                        return;
                    }

                    // 启动文件
                    Process.Start(targetFilePath);
                    Console.WriteLine("已启动");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("启动时出错: " + ex.Message);
                }
            });
        }

        private void HDTune64_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                try
                {
                    // 获取当前程序的运行目录
                    string currentDir = AppDomain.CurrentDomain.BaseDirectory;

                    // 拼接目标文件路径
                    string targetFilePath = Path.Combine(currentDir, "tools", "HDTune", "HDTune.exe");

                    // 检查文件是否存在
                    if (!File.Exists(targetFilePath))
                    {
                        Console.WriteLine("文件不存在: " + targetFilePath);
                        return;
                    }

                    // 启动文件
                    Process.Start(targetFilePath);
                    Console.WriteLine("已启动");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("启动时出错: " + ex.Message);
                }
            });
        }

        private void iva64_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                try
                {
                    // 获取当前程序的运行目录
                    string currentDir = AppDomain.CurrentDomain.BaseDirectory;

                    // 拼接目标文件路径
                    string targetFilePath = Path.Combine(currentDir, "tools", "iva", "iva.bat");

                    // 检查文件是否存在
                    if (!File.Exists(targetFilePath))
                    {
                        Console.WriteLine("文件不存在: " + targetFilePath);
                        return;
                    }

                    // 启动文件
                    Process.Start(targetFilePath);
                    Console.WriteLine("已启动");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("启动时出错: " + ex.Message);
                }
            });
        }

        private void keyboard64_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                try
                {
                    // 获取当前程序的运行目录
                    string currentDir = AppDomain.CurrentDomain.BaseDirectory;

                    // 拼接目标文件路径
                    string targetFilePath = Path.Combine(currentDir, "tools", "Keyboard Test Utility", "Keyboard Test Utility.exe");

                    // 检查文件是否存在
                    if (!File.Exists(targetFilePath))
                    {
                        Console.WriteLine("文件不存在: " + targetFilePath);
                        return;
                    }

                    // 启动文件
                    Process.Start(targetFilePath);
                    Console.WriteLine("已启动");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("启动时出错: " + ex.Message);
                }
            });
        }

        private void RWEverything64_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                try
                {
                    // 获取当前程序的运行目录
                    string currentDir = AppDomain.CurrentDomain.BaseDirectory;

                    // 拼接目标文件路径
                    string targetFilePath = Path.Combine(currentDir, "tools", "RWEverything", "Rw.exe");

                    // 检查文件是否存在
                    if (!File.Exists(targetFilePath))
                    {
                        Console.WriteLine("文件不存在: " + targetFilePath);
                        return;
                    }

                    // 启动文件
                    Process.Start(targetFilePath);
                    Console.WriteLine("已启动");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("启动时出错: " + ex.Message);
                }
            });
        }

        private void SSDZ64_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                try
                {
                    // 获取当前程序的运行目录
                    string currentDir = AppDomain.CurrentDomain.BaseDirectory;

                    // 拼接目标文件路径
                    string targetFilePath = Path.Combine(currentDir, "tools", "SSDZ", "SSDZ.exe");

                    // 检查文件是否存在
                    if (!File.Exists(targetFilePath))
                    {
                        Console.WriteLine("文件不存在: " + targetFilePath);
                        return;
                    }

                    // 启动文件
                    Process.Start(targetFilePath);
                    Console.WriteLine("已启动");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("启动时出错: " + ex.Message);
                }
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                try
                {
                    // 获取当前程序的运行目录
                    string currentDir = AppDomain.CurrentDomain.BaseDirectory;

                    // 拼接目标文件路径
                    string targetFilePath = Path.Combine(currentDir, "tools", "ThrottleStop", "ThrottleStop.exe");

                    // 检查文件是否存在
                    if (!File.Exists(targetFilePath))
                    {
                        Console.WriteLine("文件不存在: " + targetFilePath);
                        return;
                    }

                    // 启动文件
                    Process.Start(targetFilePath);
                    Console.WriteLine("已启动");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("启动时出错: " + ex.Message);
                }
            });
        }

        private void wPrime64_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                try
                {
                    // 获取当前程序的运行目录
                    string currentDir = AppDomain.CurrentDomain.BaseDirectory;

                    // 拼接目标文件路径
                    string targetFilePath = Path.Combine(currentDir, "tools", "wPrime", "wPrime.exe");

                    // 检查文件是否存在
                    if (!File.Exists(targetFilePath))
                    {
                        Console.WriteLine("文件不存在: " + targetFilePath);
                        return;
                    }

                    // 启动文件
                    Process.Start(targetFilePath);
                    Console.WriteLine("已启动");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("启动时出错: " + ex.Message);
                }
            });
        }

        private void ChessBenchMark32_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                try
                {
                    // 获取当前程序的运行目录
                    string currentDir = AppDomain.CurrentDomain.BaseDirectory;

                    // 拼接目标文件路径
                    string targetFilePath = Path.Combine(currentDir, "tools", "XIANGQI", "xiangqi.exe");

                    // 检查文件是否存在
                    if (!File.Exists(targetFilePath))
                    {
                        Console.WriteLine("文件不存在: " + targetFilePath);
                        return;
                    }

                    // 启动文件
                    Process.Start(targetFilePath);
                    Console.WriteLine("已启动");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("启动时出错: " + ex.Message);
                }
            });
        }

        private void monitorinfo64_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                try
                {
                    // 获取当前程序的运行目录
                    string currentDir = AppDomain.CurrentDomain.BaseDirectory;

                    // 拼接目标文件路径
                    string targetFilePath = Path.Combine(currentDir, "tools", "色域检测", "monitorinfo.exe");

                    // 检查文件是否存在
                    if (!File.Exists(targetFilePath))
                    {
                        Console.WriteLine("文件不存在: " + targetFilePath);
                        return;
                    }

                    // 启动文件
                    Process.Start(targetFilePath);
                    Console.WriteLine("已启动");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("启动时出错: " + ex.Message);
                }
            });
        }

        private void disk_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                try
                {
                    // 获取当前程序的运行目录
                    string currentDir = AppDomain.CurrentDomain.BaseDirectory;

                    // 拼接目标文件路径
                    string targetFilePath = Path.Combine(currentDir, "tools", "DiskGenius", "DiskGenius.exe");

                    // 检查文件是否存在
                    if (!File.Exists(targetFilePath))
                    {
                        Console.WriteLine("文件不存在: " + targetFilePath);
                        return;
                    }

                    // 启动文件
                    Process.Start(targetFilePath);
                    Console.WriteLine("已启动");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("启动时出错: " + ex.Message);
                }
            });
        }

        private void Time_Click(object sender, EventArgs e)
        {

        }
    }
}