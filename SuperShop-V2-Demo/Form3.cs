using AntdUI;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop_V2_Demo
{
    public partial class Form3 : BaseForm
    {
        Form2 form2 = new Form2();
        public Form3()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // 在窗体加载时设置按钮的初始状态
            UpdateButtonEnabledState();
            // 为每个文本框添加TextChanged事件处理器
            textBox1.TextChanged += TextBox_TextChanged;
            textBox2.TextChanged += TextBox_TextChanged;
            textBox3.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // 每次文本框内容变化时更新按钮的状态
            UpdateButtonEnabledState();
        }

        private void UpdateButtonEnabledState()
        {
            // 检查所有文本框是否都已填写
            bool allFilled = !(string.IsNullOrEmpty(textBox1.Text) ||
                               string.IsNullOrEmpty(textBox2.Text) ||
                               string.IsNullOrEmpty(textBox3.Text));
            // 根据检查结果设置按钮的Enabled属性
            button1.Enabled = allFilled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mysqlcon = "server = hostsql.btust.xiaokecloud.cn; database = gwlned; user = gwlned; password = eCpNZRq89mBW";
            using (MySqlConnection con = new MySqlConnection(mysqlcon))
            {
                try
                {
                    con.Open();
                    string sql2 = "INSERT INTO `app` (软件名, 链接, 上传者) VALUES (@fileName, @link, @Uesr)"; // 使用反引号包围表名
                    using (MySqlCommand mysql = new MySqlCommand(sql2, con))
                    {
                        // 使用参数化查询防止SQL注入
                        mysql.Parameters.AddWithValue("@fileName", textBox1.Text);
                        mysql.Parameters.AddWithValue("@link", textBox2.Text);
                        mysql.Parameters.AddWithValue("@Uesr", textBox3.Text);

                        mysql.ExecuteNonQuery();
                        AntdUI.Modal.open(form2, "SQL数据添加完成!", AntdUI.TType.Success);
                        Console.WriteLine("数据添加成功!");
                    }
                }
                catch (Exception ex)
                {
                    AntdUI.Modal.open(form2, "SQL添加时发生致命错误!", ex.Message, AntdUI.TType.Error);
                    Console.WriteLine("数据库错误: " + ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                        Console.WriteLine("已关闭连接!");
                    }
                }
            }
            // 如果需要在添加数据后关闭窗口
            this.Close();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DelBtn_Click_1(object sender, EventArgs e)
        {
            del frm3 = new del();
            frm3.Show();
        }
    }
}
