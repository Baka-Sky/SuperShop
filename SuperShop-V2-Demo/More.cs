using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop_V2_Demo
{
    public partial class More : UserControl
    {
        public Set f1; // F1 用户控件
        public Form2 f2; // 包含 UesrPanel 的主窗体
        public Chat f3;

        public More(Form2 form2)
        {
            InitializeComponent();
            f1 = new Set(); // 初始化 F1 用户控件
            f2 = form2; // 使用传入的 Form2 实例

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 清空 UesrPanel 的内容
            f2.UesrPanel.Controls.Clear();
            // 将 F1 添加到 UesrPanel
            f2.UesrPanel.Controls.Add(f1);
            // 显示 F1
            f1.Show();
            // 隐藏当前 More 控件
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            f3 = new Chat();
            f3.timer2.Enabled=true;


            f2.UesrPanel.Controls.Clear();
            // 将 F1 添加到 UesrPanel
            f2.UesrPanel.Controls.Add(f3);
            // 显示 F1
            f3.Show();
            // 隐藏当前 More 控件
            this.Hide();
        }

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

        //private void More_Load(object sender, EventArgs e)
        //{
         
        //}
       
    
    }

}
    

