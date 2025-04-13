namespace SuperShop_V2_Demo
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new AntdUI.Panel();
            this.Set = new AntdUI.Button();
            this.About = new AntdUI.Button();
            this.Version = new AntdUI.Label();
            this.tools = new AntdUI.Button();
            this.Dwn = new AntdUI.Button();
            this.Home = new AntdUI.Button();
            this.windowBar1 = new AntdUI.WindowBar();
            this.UesrPanel = new AntdUI.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.Set);
            this.panel1.Controls.Add(this.About);
            this.panel1.Controls.Add(this.Version);
            this.panel1.Controls.Add(this.tools);
            this.panel1.Controls.Add(this.Dwn);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Location = new System.Drawing.Point(2, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 419);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // Set
            // 
            this.Set.BackColor = System.Drawing.Color.Lavender;
            this.Set.BackgroundImageLayout = AntdUI.TFit.Cover;
            this.Set.DefaultBack = System.Drawing.Color.Lavender;
            this.Set.DefaultBorderColor = System.Drawing.Color.Lavender;
            this.Set.Icon = ((System.Drawing.Image)(resources.GetObject("Set.Icon")));
            this.Set.IconGap = 1F;
            this.Set.IconRatio = 1.4F;
            this.Set.LoadingWaveColor = System.Drawing.Color.LavenderBlush;
            this.Set.Location = new System.Drawing.Point(10, 210);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(59, 59);
            this.Set.TabIndex = 5;
            this.Set.ToggleBackHover = System.Drawing.Color.Lavender;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.Lavender;
            this.About.BackgroundImageLayout = AntdUI.TFit.Cover;
            this.About.DefaultBack = System.Drawing.Color.Lavender;
            this.About.DefaultBorderColor = System.Drawing.Color.Lavender;
            this.About.Icon = ((System.Drawing.Image)(resources.GetObject("About.Icon")));
            this.About.IconGap = 1F;
            this.About.IconRatio = 1.4F;
            this.About.LoadingWaveColor = System.Drawing.Color.LavenderBlush;
            this.About.Location = new System.Drawing.Point(10, 351);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(59, 59);
            this.About.TabIndex = 3;
            this.About.ToggleBackHover = System.Drawing.Color.Lavender;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Version
            // 
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.Location = new System.Drawing.Point(0, 331);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(80, 23);
            this.Version.TabIndex = 4;
            this.Version.Text = "3.0.0";
            this.Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tools
            // 
            this.tools.BackColor = System.Drawing.Color.Lavender;
            this.tools.BackgroundImageLayout = AntdUI.TFit.Cover;
            this.tools.DefaultBack = System.Drawing.Color.Lavender;
            this.tools.DefaultBorderColor = System.Drawing.Color.Lavender;
            this.tools.Icon = ((System.Drawing.Image)(resources.GetObject("tools.Icon")));
            this.tools.IconGap = 1F;
            this.tools.IconRatio = 1.4F;
            this.tools.LoadingWaveColor = System.Drawing.Color.LavenderBlush;
            this.tools.Location = new System.Drawing.Point(10, 145);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(59, 59);
            this.tools.TabIndex = 2;
            this.tools.ToggleBackHover = System.Drawing.Color.Lavender;
            this.tools.Click += new System.EventHandler(this.tools_Click);
            // 
            // Dwn
            // 
            this.Dwn.BackColor = System.Drawing.Color.Lavender;
            this.Dwn.DefaultBack = System.Drawing.Color.Lavender;
            this.Dwn.DefaultBorderColor = System.Drawing.Color.Lavender;
            this.Dwn.Icon = ((System.Drawing.Image)(resources.GetObject("Dwn.Icon")));
            this.Dwn.IconRatio = 1.4F;
            this.Dwn.LoadingWaveColor = System.Drawing.Color.LavenderBlush;
            this.Dwn.Location = new System.Drawing.Point(10, 80);
            this.Dwn.Name = "Dwn";
            this.Dwn.Size = new System.Drawing.Size(59, 59);
            this.Dwn.TabIndex = 1;
            this.Dwn.ToggleBackHover = System.Drawing.Color.Lavender;
            this.Dwn.Click += new System.EventHandler(this.Dwn_Click);
            // 
            // Home
            // 
            this.Home.DefaultBack = System.Drawing.Color.Lavender;
            this.Home.Icon = ((System.Drawing.Image)(resources.GetObject("Home.Icon")));
            this.Home.IconRatio = 1.4F;
            this.Home.LoadingWaveColor = System.Drawing.Color.Lavender;
            this.Home.Location = new System.Drawing.Point(10, 15);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(59, 59);
            this.Home.TabIndex = 0;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // windowBar1
            // 
            this.windowBar1.BackColor = System.Drawing.Color.Lavender;
            this.windowBar1.DividerShow = true;
            this.windowBar1.Font = new System.Drawing.Font("MiSans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.windowBar1.Icon = ((System.Drawing.Image)(resources.GetObject("windowBar1.Icon")));
            this.windowBar1.Location = new System.Drawing.Point(2, 1);
            this.windowBar1.MaximizeBox = false;
            this.windowBar1.Name = "windowBar1";
            this.windowBar1.Size = new System.Drawing.Size(892, 38);
            this.windowBar1.TabIndex = 1;
            this.windowBar1.Text = "超级小铺";
            // 
            // UesrPanel
            // 
            this.UesrPanel.Location = new System.Drawing.Point(88, 41);
            this.UesrPanel.Name = "UesrPanel";
            this.UesrPanel.Size = new System.Drawing.Size(806, 419);
            this.UesrPanel.TabIndex = 2;
            this.UesrPanel.Text = "panel2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(894, 463);
            this.Controls.Add(this.UesrPanel);
            this.Controls.Add(this.windowBar1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MiSans", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperShop";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.WindowBar windowBar1;
        private AntdUI.Button tools;
        private AntdUI.Button Dwn;
        private AntdUI.Button Home;
        private AntdUI.Button About;
        private AntdUI.Label Version;
        private AntdUI.Button Set;
        public AntdUI.Panel UesrPanel;
    }
}