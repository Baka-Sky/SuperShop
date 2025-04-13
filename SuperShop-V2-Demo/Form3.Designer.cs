namespace SuperShop_V2_Demo
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.windowBar1 = new AntdUI.WindowBar();
            this.windowBar2 = new AntdUI.WindowBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.label1 = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // windowBar1
            // 
            this.windowBar1.BackColor = System.Drawing.Color.Lavender;
            this.windowBar1.DividerShow = true;
            this.windowBar1.Font = new System.Drawing.Font("MiSans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.windowBar1.Icon = ((System.Drawing.Image)(resources.GetObject("windowBar1.Icon")));
            this.windowBar1.Location = new System.Drawing.Point(-135, 122);
            this.windowBar1.MaximizeBox = false;
            this.windowBar1.MinimizeBox = false;
            this.windowBar1.Name = "windowBar1";
            this.windowBar1.Size = new System.Drawing.Size(1, 1);
            this.windowBar1.TabIndex = 2;
            this.windowBar1.Text = "超级小铺";
            // 
            // windowBar2
            // 
            this.windowBar2.Location = new System.Drawing.Point(1, -1);
            this.windowBar2.MaximizeBox = false;
            this.windowBar2.MinimizeBox = false;
            this.windowBar2.Name = "windowBar2";
            this.windowBar2.Size = new System.Drawing.Size(621, 40);
            this.windowBar2.TabIndex = 3;
            this.windowBar2.Text = "添加文件";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 27);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(374, 27);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(374, 27);
            this.textBox3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(381, 210);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(121, 41);
            this.DelBtn.TabIndex = 8;
            this.DelBtn.Text = "删除";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(69, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "软件名";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(69, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "链接";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(69, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "上传者";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 275);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.windowBar2);
            this.Controls.Add(this.windowBar1);
            this.Font = new System.Drawing.Font("MiSans", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AntdUI.WindowBar windowBar1;
        private AntdUI.WindowBar windowBar2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DelBtn;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private System.Windows.Forms.Button button2;
    }
}