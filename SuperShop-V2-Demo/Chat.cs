using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AntdUI;
using System.Diagnostics;
using System.Windows.Controls.Primitives;
using System.Security.Policy;
using System.Threading;

namespace SuperShop_V2_Demo
{
    public partial class Chat : UserControl
    {
        public static string mysqlcon = "server=hostsql.btust.xiaokecloud.cn;database=gwlned;user=gwlned;password=eCpNZRq89mBW";

        // 用于记录 DataGridView 刷新前的滚动位置
        private int firstDisplayedRowIndex = -1;

        public Chat()
        {
            InitializeComponent();
        }

        // 保存 DataGridView 的滚动位置
        private void SaveDataGridViewScrollPosition()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                firstDisplayedRowIndex = dataGridView1.FirstDisplayedScrollingRowIndex;
            }
        }

        // 恢复 DataGridView 的滚动位置
        private void RestoreDataGridViewScrollPosition()
        {
            if (firstDisplayedRowIndex != -1 && dataGridView1.Rows.Count > firstDisplayedRowIndex)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = firstDisplayedRowIndex;
            }
            else if (dataGridView1.Rows.Count > 0)
            {
                // 如果刷新后的行数少于之前记录的行索引，则滚动到第一行
                dataGridView1.FirstDisplayedScrollingRowIndex = 0;
            }
        }

        // 刷新 DataGridView 的数据
        public void Sqlrun()
        {
            Task task = Task.Factory.StartNew(() =>
            {
                // 这里放置任务要执行的代码
                this.Invoke(new Action(() =>
                {
                    // 保存当前滚动位置
                    SaveDataGridViewScrollPosition();

                    try
                    {
                        MySqlConnection con = new MySqlConnection(mysqlcon);
                        string strcmd = "SELECT * FROM chat";
                        MySqlCommand cmd = new MySqlCommand(strcmd, con);
                        MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        ada.Fill(ds);   // 查询结果填充数据集
                        dataGridView1.DataSource = ds.Tables[0];
                        Console.WriteLine("查询成功!");
                        con.Close();   // 关闭连接
                        Console.WriteLine("已关闭连接!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        Console.WriteLine("数据库错误: " + ex.Message);
                    }

                    // 恢复滚动位置
                    RestoreDataGridViewScrollPosition();

                    logo.Hide();
                    send.Enabled = true;
                    text.Enabled = true;
                }));
            });
        }

        private void send_Click(object sender, EventArgs e)
        {
            Task task = Task.Factory.StartNew(() =>
            {
                // 这里放置任务要执行的代码
                this.Invoke(new Action(() =>
                {
                    string mysqlcon = "server=hostsql.btust.xiaokecloud.cn;database=gwlned;user=gwlned;password=eCpNZRq89mBW";
                    using (MySqlConnection con = new MySqlConnection(mysqlcon))
                    {
                        try
                        {
                            con.Open();
                            string sql2 = "INSERT INTO `chat` (时间, 发言人, 话) VALUES (@fileName, @link, @Uesr)"; // 使用反引号包围表名
                            using (MySqlCommand mysql = new MySqlCommand(sql2, con))
                            {
                                // 使用参数化查询防止SQL注入
                                mysql.Parameters.AddWithValue("@fileName", DateTime.Now.ToString("MM-dd"));
                                mysql.Parameters.AddWithValue("@link", Username.Text);
                                mysql.Parameters.AddWithValue("@Uesr", text.Text);

                                mysql.ExecuteNonQuery();
                                Console.WriteLine("数据添加成功!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error!");
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

                    // 刷新数据
                    Sqlrun();
                }));
            });
        }

        private void Chat_Load(object sender, EventArgs e)
        {


            timer2.Enabled = false;

            xiugai.Text = "聊天室Beta(SkySQLChat)";

            ok.Enabled = false;

            if (name.Visible == true)
            {
                send.Enabled = false;
                text.Enabled = false;
            }
            ;

            if (xiugai.Text != "聊天室Beta(SkySQLChat)")
            {
                pictureBox1.Show();
            }
            else
            {
                pictureBox1.Hide();
            }

            Task.Run(() =>
            {
                this.Invoke(new Action(() =>
                {
                    if (name.Visible == false)
                    {
                        Sqlrun();
                    }
                }));
            });
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            if (Username.Text == "名字")
            {
                ok.Enabled = false;
            }
            else
            {
                ok.Enabled = true;
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;

            string name = Username.Text;

            this.name.Hide();

            xiugai.Text = "聊天室Beta(SkySQLChat)" + "当前名字:" + name;

            Sqlrun();
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            Sqlrun();
        }

        private void xiugai_Click(object sender, EventArgs e)
        {
            if (xiugai.Text != "聊天室Beta(SkySQLChat)")
            {
                name.Visible = true;
                label2.Text = "看起来不太合适?\n修改名字:";
            }

            if (xiugai.Text != "聊天室Beta(SkySQLChat)")
            {
                pictureBox1.Show();
            }
            else
            {
                pictureBox1.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            name.Hide();
        }
    }
}