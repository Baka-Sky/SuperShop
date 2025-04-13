namespace SuperShop_V2_Demo
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.panel1 = new AntdUI.Panel();
            this.label4 = new AntdUI.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new AntdUI.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ResBtn = new AntdUI.Button();
            this.AddBtn = new AntdUI.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SqlViwi = new System.Windows.Forms.DataGridView();
            this.软件名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.链接 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.上传者 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Waitbar = new AntdUI.Progress();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PS = new AntdUI.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SqlViwi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Time);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 58);
            this.panel1.TabIndex = 1;
            this.panel1.Text = "panel1";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MiSans", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(242, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "下载进度: 我不道啊";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(186, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MiSans", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "软件-Download\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.ResBtn);
            this.panel2.Controls.Add(this.AddBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(4, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 42);
            this.panel2.TabIndex = 2;
            this.panel2.Text = "panel2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(694, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 34);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "尝试搜索一下";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(302, 8);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(383, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // ResBtn
            // 
            this.ResBtn.BackActive = System.Drawing.Color.Lavender;
            this.ResBtn.BackColor = System.Drawing.Color.Lavender;
            this.ResBtn.DefaultBack = System.Drawing.Color.Lavender;
            this.ResBtn.DefaultBorderColor = System.Drawing.Color.Lavender;
            this.ResBtn.Location = new System.Drawing.Point(229, 0);
            this.ResBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ResBtn.Name = "ResBtn";
            this.ResBtn.Radius = 1;
            this.ResBtn.Size = new System.Drawing.Size(75, 42);
            this.ResBtn.TabIndex = 5;
            this.ResBtn.Text = "刷新";
            this.ResBtn.Click += new System.EventHandler(this.ResBtn_Click_1);
            // 
            // AddBtn
            // 
            this.AddBtn.BackActive = System.Drawing.Color.Lavender;
            this.AddBtn.BackColor = System.Drawing.Color.Lavender;
            this.AddBtn.DefaultBack = System.Drawing.Color.Lavender;
            this.AddBtn.DefaultBorderColor = System.Drawing.Color.Lavender;
            this.AddBtn.Location = new System.Drawing.Point(110, 0);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Radius = 1;
            this.AddBtn.Size = new System.Drawing.Size(129, 42);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "上传/删除文件";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MiSans", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "下载工具";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SqlViwi
            // 
            this.SqlViwi.AllowUserToAddRows = false;
            this.SqlViwi.AllowUserToDeleteRows = false;
            this.SqlViwi.AllowUserToOrderColumns = true;
            this.SqlViwi.AllowUserToResizeColumns = false;
            this.SqlViwi.AllowUserToResizeRows = false;
            this.SqlViwi.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.SqlViwi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SqlViwi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SqlViwi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.软件名,
            this.链接,
            this.上传者});
            this.SqlViwi.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.SqlViwi.Location = new System.Drawing.Point(0, 115);
            this.SqlViwi.Margin = new System.Windows.Forms.Padding(4);
            this.SqlViwi.MultiSelect = false;
            this.SqlViwi.Name = "SqlViwi";
            this.SqlViwi.ReadOnly = true;
            this.SqlViwi.RowHeadersWidth = 51;
            this.SqlViwi.RowTemplate.Height = 27;
            this.SqlViwi.Size = new System.Drawing.Size(1000, 368);
            this.SqlViwi.TabIndex = 3;
            this.SqlViwi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SqlViwi_CellMouseClick);
            // 
            // 软件名
            // 
            this.软件名.DataPropertyName = "软件名";
            this.软件名.HeaderText = "软件名";
            this.软件名.MinimumWidth = 6;
            this.软件名.Name = "软件名";
            this.软件名.ReadOnly = true;
            this.软件名.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.软件名.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.软件名.Width = 270;
            // 
            // 链接
            // 
            this.链接.DataPropertyName = "链接";
            this.链接.HeaderText = "链接";
            this.链接.MinimumWidth = 6;
            this.链接.Name = "链接";
            this.链接.ReadOnly = true;
            this.链接.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.链接.Width = 220;
            // 
            // 上传者
            // 
            this.上传者.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.上传者.DataPropertyName = "上传者";
            this.上传者.HeaderText = "上传者";
            this.上传者.MinimumWidth = 6;
            this.上传者.Name = "上传者";
            this.上传者.ReadOnly = true;
            // 
            // Waitbar
            // 
            this.Waitbar.Location = new System.Drawing.Point(4, 490);
            this.Waitbar.Margin = new System.Windows.Forms.Padding(4);
            this.Waitbar.Name = "Waitbar";
            this.Waitbar.Size = new System.Drawing.Size(996, 29);
            this.Waitbar.TabIndex = 4;
            this.Waitbar.Text = "progress1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 408);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(390, 235);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(218, 132);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // PS
            // 
            this.PS.BackColor = System.Drawing.Color.AliceBlue;
            this.PS.Location = new System.Drawing.Point(121, 408);
            this.PS.Name = "PS";
            this.PS.Size = new System.Drawing.Size(273, 55);
            this.PS.TabIndex = 8;
            this.PS.Text = "PS:第一次开启可能会报错OpenID报错 您可以重启超级小铺以解决问题";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("MiSans", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(789, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "连接MySQL数据库";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PS);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Waitbar);
            this.Controls.Add(this.SqlViwi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MiSans", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "App";
            this.Size = new System.Drawing.Size(1008, 522);
            this.Load += new System.EventHandler(this.App_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SqlViwi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AntdUI.Panel panel1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label label1;
        private AntdUI.Panel panel2;
        private System.Windows.Forms.Label label2;
        private AntdUI.Button AddBtn;
        private AntdUI.Button ResBtn;
        private System.Windows.Forms.DataGridView SqlViwi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private AntdUI.Progress Waitbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 软件名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 链接;
        private System.Windows.Forms.DataGridViewTextBoxColumn 上传者;
        private System.Windows.Forms.PictureBox pictureBox3;
        private AntdUI.Label PS;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private AntdUI.Label label4;
    }
}
