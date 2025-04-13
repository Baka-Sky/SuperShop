using AntdUI;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop_V2_Demo
{
    public partial class del : BaseForm
    {
        Form2 form2 = new Form2();
        public del()
        {
            InitializeComponent();
            InitializeForm();
        }
        private void InitializeForm()
        {
            // 在窗体加载时设置按钮的初始状态
            UpdateButtonEnabledState();
            // 为文本框添加TextChanged事件处理器
            textBox1.TextChanged += TextBox1_TextChanged;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // 每次文本框内容变化时更新按钮的状态
            UpdateButtonEnabledState();
        }

        private void UpdateButtonEnabledState()
        {
            // 检查文本框是否已填写
            bool filled = !string.IsNullOrEmpty(textBox1.Text);
            // 根据检查结果设置按钮的Enabled属性
            button1.Enabled = filled;
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定删除？", "警告！", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection("server=hostsql.btust.xiaokecloud.cn;database=gwlned;user=gwlned;password=eCpNZRq89mBW"))
                    {
                        con.Open();
                        string sql3 = "DELETE FROM app WHERE 软件名 = @软件名";
                        using (MySqlCommand mycommand2 = new MySqlCommand(sql3, con))
                        {
                            mycommand2.Parameters.AddWithValue("@软件名", textBox1.Text);
                            mycommand2.ExecuteNonQuery();
                            Console.WriteLine("数据删除成功!");
                        }
                    }
                    Console.WriteLine("已关闭连接!");
                    AntdUI.Modal.open(form2, "完成!",AntdUI.TType.Success);
                    this.Close();
                }
                catch (Exception ex)
                {
                    AntdUI.Modal.open(form2, "SQL删除时发生致命错误!", ex.Message, AntdUI.TType.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    
    
