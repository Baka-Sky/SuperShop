namespace SuperShop_V2_Demo
{
    partial class Welcome
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
            this.panel1 = new AntdUI.Panel();
            this.Time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.FindSky = new AntdUI.Button();
            this.SkyLabel = new AntdUI.Input();
            this.Skyinput = new AntdUI.Input();
            this.update = new AntdUI.Input();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Time);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 58);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
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
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MiSans", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "主页-Home";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FindSky
            // 
            this.FindSky.Location = new System.Drawing.Point(481, 480);
            this.FindSky.Margin = new System.Windows.Forms.Padding(2);
            this.FindSky.Name = "FindSky";
            this.FindSky.Radius = 0;
            this.FindSky.Size = new System.Drawing.Size(95, 40);
            this.FindSky.TabIndex = 4;
            this.FindSky.Text = "查询！";
            this.FindSky.Click += new System.EventHandler(this.FindSky_Click);
            // 
            // SkyLabel
            // 
            this.SkyLabel.BackgroundImageLayout = AntdUI.TFit.None;
            this.SkyLabel.Location = new System.Drawing.Point(481, 311);
            this.SkyLabel.Margin = new System.Windows.Forms.Padding(2);
            this.SkyLabel.Name = "SkyLabel";
            this.SkyLabel.ReadOnly = true;
            this.SkyLabel.Size = new System.Drawing.Size(524, 170);
            this.SkyLabel.TabIndex = 5;
            this.SkyLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Skyinput
            // 
            this.Skyinput.Location = new System.Drawing.Point(572, 480);
            this.Skyinput.Margin = new System.Windows.Forms.Padding(2);
            this.Skyinput.Name = "Skyinput";
            this.Skyinput.Size = new System.Drawing.Size(432, 40);
            this.Skyinput.TabIndex = 6;
            this.Skyinput.Text = "输入城市(后面不加“市”字)以查询天气";
            // 
            // update
            // 
            this.update.BadgeSvg = "";
            this.update.Location = new System.Drawing.Point(2, 311);
            this.update.Margin = new System.Windows.Forms.Padding(2);
            this.update.Name = "update";
            this.update.ReadOnly = true;
            this.update.SelectionColor = System.Drawing.Color.Transparent;
            this.update.Size = new System.Drawing.Size(482, 209);
            this.update.TabIndex = 7;
            this.update.Text = "Test";
            this.update.TextChanged += new System.EventHandler(this.update_TextChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(2, 65);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1001, 241);
            this.webBrowser1.TabIndex = 8;
            this.webBrowser1.Url = new System.Uri("https://www.supershop.net.cn/Logo/html.html", System.UriKind.Absolute);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Skyinput);
            this.Controls.Add(this.SkyLabel);
            this.Controls.Add(this.FindSky);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MiSans", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(1008, 522);
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer timer2;
        private AntdUI.Button FindSky;
        private AntdUI.Input SkyLabel;
        private AntdUI.Input Skyinput;
        private AntdUI.Input update;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}
