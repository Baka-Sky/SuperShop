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
    public partial class about : UserControl
    {
        public about()
        {
            InitializeComponent();
            //FontHelper.LoadAndApplyDefaultFont(this);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
