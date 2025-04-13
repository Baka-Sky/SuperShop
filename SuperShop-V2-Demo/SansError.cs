using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SuperShop_V2_Demo
{
    public partial class SansError : Form
    {
        public SansError()
        {
            InitializeComponent();
        }

        private void SansError_Load(object sender, EventArgs e)
        {
            Task task = Task.Factory.StartNew(() =>
            {
                this.Invoke(new Action(() =>
                {
                    string filePath = System.IO.Path.Combine(Application.StartupPath, "html.mht");

                    // 检查文件是否存在
                    if (System.IO.File.Exists(filePath))
                    {
                        // 加载.mht文件
                        Htm.Navigate(filePath);
                    }
                    else
                    {
                        MessageBox.Show("文件未找到，请确保html.mht文件在程序运行目录下。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }));
            });
        }



        protected override void OnClosing(CancelEventArgs e)
        {
                Process.GetCurrentProcess().Kill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 获取程序的启动路径
                string folderPath = Application.StartupPath;

                // 打开指定文件夹
                Process.Start("Misans", folderPath);
                Console.WriteLine("文件夹打开成功！");
            }
            catch (Exception ex)
            {
                Console.WriteLine("无法打开文件夹，错误信息：" + ex.Message);
            }
        }
    }
    }

    
