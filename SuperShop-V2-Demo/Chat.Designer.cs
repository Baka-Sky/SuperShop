namespace SuperShop_V2_Demo
{
    partial class Chat
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.Done = new AntdUI.Panel();
            this.Time = new System.Windows.Forms.Label();
            this.xiugai = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发言人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text = new AntdUI.Input();
            this.send = new AntdUI.Button();
            this.name = new AntdUI.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ok = new AntdUI.Button();
            this.Username = new AntdUI.Input();
            this.label2 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Done.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Done
            // 
            this.Done.Controls.Add(this.Time);
            this.Done.Controls.Add(this.xiugai);
            this.Done.Location = new System.Drawing.Point(0, 2);
            this.Done.Margin = new System.Windows.Forms.Padding(2);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(1005, 58);
            this.Done.TabIndex = 1;
            this.Done.Text = "panel1";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Transparent;
            this.Time.Font = new System.Drawing.Font("MiSans", 12F, System.Drawing.FontStyle.Bold);
            this.Time.Location = new System.Drawing.Point(769, 15);
            this.Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(62, 27);
            this.Time.TabIndex = 1;
            this.Time.Text = "Time";
            this.Time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // xiugai
            // 
            this.xiugai.AutoSize = true;
            this.xiugai.BackColor = System.Drawing.Color.Transparent;
            this.xiugai.Font = new System.Drawing.Font("MiSans", 12F, System.Drawing.FontStyle.Bold);
            this.xiugai.Location = new System.Drawing.Point(15, 15);
            this.xiugai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xiugai.Name = "xiugai";
            this.xiugai.Size = new System.Drawing.Size(265, 27);
            this.xiugai.TabIndex = 0;
            this.xiugai.Text = "聊天室Beta(SkySQLChat)";
            this.xiugai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.xiugai.Click += new System.EventHandler(this.xiugai_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.时间,
            this.发言人,
            this.话});
            this.dataGridView1.GridColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.Location = new System.Drawing.Point(3, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 414);
            this.dataGridView1.TabIndex = 2;
            // 
            // 时间
            // 
            this.时间.DataPropertyName = "时间";
            this.时间.HeaderText = "发送时间";
            this.时间.MinimumWidth = 6;
            this.时间.Name = "时间";
            this.时间.ReadOnly = true;
            this.时间.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.时间.Width = 200;
            // 
            // 发言人
            // 
            this.发言人.DataPropertyName = "发言人";
            this.发言人.HeaderText = "发言人";
            this.发言人.MinimumWidth = 6;
            this.发言人.Name = "发言人";
            this.发言人.ReadOnly = true;
            this.发言人.Width = 200;
            // 
            // 话
            // 
            this.话.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.话.DataPropertyName = "话";
            this.话.HeaderText = "话";
            this.话.MinimumWidth = 6;
            this.话.Name = "话";
            this.话.ReadOnly = true;
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("MiSans", 9F, System.Drawing.FontStyle.Bold);
            this.text.Location = new System.Drawing.Point(148, 482);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(860, 42);
            this.text.TabIndex = 3;
            this.text.Text = "请输入文字";
            // 
            // send
            // 
            this.send.Font = new System.Drawing.Font("MiSans", 9F, System.Drawing.FontStyle.Bold);
            this.send.Location = new System.Drawing.Point(3, 482);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(139, 42);
            this.send.TabIndex = 4;
            this.send.Text = "发送!";
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // name
            // 
            this.name.Controls.Add(this.pictureBox1);
            this.name.Controls.Add(this.ok);
            this.name.Controls.Add(this.Username);
            this.name.Controls.Add(this.label2);
            this.name.Location = new System.Drawing.Point(303, 190);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(376, 186);
            this.name.TabIndex = 5;
            this.name.Text = "panel2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(336, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ok
            // 
            this.ok.DefaultBack = System.Drawing.Color.AliceBlue;
            this.ok.Font = new System.Drawing.Font("MiSans", 9F, System.Drawing.FontStyle.Bold);
            this.ok.Location = new System.Drawing.Point(18, 132);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(337, 42);
            this.ok.TabIndex = 6;
            this.ok.Text = "完成";
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("MiSans", 9F, System.Drawing.FontStyle.Bold);
            this.Username.Location = new System.Drawing.Point(18, 77);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(337, 49);
            this.Username.TabIndex = 6;
            this.Username.Text = "名字";
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "在聊天之前\r\n请设置你的用户名:";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.AliceBlue;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(360, 214);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(241, 142);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.name);
            this.Controls.Add(this.send);
            this.Controls.Add(this.text);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Done);
            this.Font = new System.Drawing.Font("MiSans", 12F, System.Drawing.FontStyle.Bold);
            this.Name = "Chat";
            this.Size = new System.Drawing.Size(1008, 527);
            this.Load += new System.EventHandler(this.Chat_Load);
            this.Done.ResumeLayout(false);
            this.Done.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.name.ResumeLayout(false);
            this.name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel Done;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label xiugai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AntdUI.Input text;
        private AntdUI.Button send;
        private AntdUI.Panel name;
        private System.Windows.Forms.Label label2;
        private AntdUI.Button ok;
        private AntdUI.Input Username;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发言人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 话;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Timer timer2;
    }
}
