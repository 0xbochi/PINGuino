namespace pingerMonitor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_ping = new System.Windows.Forms.Label();
            this.lb_srv = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lb_cpu = new System.Windows.Forms.Label();
            this.lb_ram = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showMeCPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMeRAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.lb_checkVisible = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_ping
            // 
            this.lb_ping.AutoSize = true;
            this.lb_ping.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ping.ForeColor = System.Drawing.Color.White;
            this.lb_ping.Location = new System.Drawing.Point(28, 76);
            this.lb_ping.Name = "lb_ping";
            this.lb_ping.Size = new System.Drawing.Size(96, 32);
            this.lb_ping.TabIndex = 1;
            this.lb_ping.Text = "Ping : ";
            // 
            // lb_srv
            // 
            this.lb_srv.AutoSize = true;
            this.lb_srv.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_srv.ForeColor = System.Drawing.Color.White;
            this.lb_srv.Location = new System.Drawing.Point(74, 25);
            this.lb_srv.Name = "lb_srv";
            this.lb_srv.Size = new System.Drawing.Size(108, 16);
            this.lb_srv.TabIndex = 3;
            this.lb_srv.Text = "Server : Google";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.CursorY.Interval = 5D;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-110, 111);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.White;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            series1.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "ping";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(965, 161);
            this.chart1.TabIndex = 7;
            this.chart1.Click += new System.EventHandler(this.Chart1_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lb_cpu
            // 
            this.lb_cpu.AutoSize = true;
            this.lb_cpu.Font = new System.Drawing.Font("Arial", 16.2F);
            this.lb_cpu.ForeColor = System.Drawing.Color.White;
            this.lb_cpu.Location = new System.Drawing.Point(293, 76);
            this.lb_cpu.Name = "lb_cpu";
            this.lb_cpu.Size = new System.Drawing.Size(98, 32);
            this.lb_cpu.TabIndex = 9;
            this.lb_cpu.Text = "CPU : ";
            this.lb_cpu.Click += new System.EventHandler(this.Lb_ram_Click);
            // 
            // lb_ram
            // 
            this.lb_ram.AutoSize = true;
            this.lb_ram.Font = new System.Drawing.Font("Arial", 16.2F);
            this.lb_ram.ForeColor = System.Drawing.Color.White;
            this.lb_ram.Location = new System.Drawing.Point(539, 76);
            this.lb_ram.Name = "lb_ram";
            this.lb_ram.Size = new System.Drawing.Size(93, 32);
            this.lb_ram.TabIndex = 9;
            this.lb_ram.Text = "RAM :";
            this.lb_ram.Click += new System.EventHandler(this.Lb_ram_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreToolStripMenuItem,
            this.discoverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(566, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(139, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.showMeCPUToolStripMenuItem,
            this.showMeRAMToolStripMenuItem});
            this.moreToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F);
            this.moreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // showMeCPUToolStripMenuItem
            // 
            this.showMeCPUToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.showMeCPUToolStripMenuItem.Name = "showMeCPUToolStripMenuItem";
            this.showMeCPUToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.showMeCPUToolStripMenuItem.Text = "Show me CPU";
            this.showMeCPUToolStripMenuItem.Click += new System.EventHandler(this.ShowMeCPUToolStripMenuItem_Click);
            // 
            // showMeRAMToolStripMenuItem
            // 
            this.showMeRAMToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.showMeRAMToolStripMenuItem.Name = "showMeRAMToolStripMenuItem";
            this.showMeRAMToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.showMeRAMToolStripMenuItem.Text = "Show me RAM";
            this.showMeRAMToolStripMenuItem.Click += new System.EventHandler(this.ShowMeRAMToolStripMenuItem_Click);
            // 
            // discoverToolStripMenuItem
            // 
            this.discoverToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.discoverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubToolStripMenuItem,
            this.twitterToolStripMenuItem,
            this.donateToolStripMenuItem});
            this.discoverToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F);
            this.discoverToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.discoverToolStripMenuItem.Name = "discoverToolStripMenuItem";
            this.discoverToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.discoverToolStripMenuItem.Text = "Discover";
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(186)))), ((int)(((byte)(80)))));
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.GitHubToolStripMenuItem_Click);
            // 
            // twitterToolStripMenuItem
            // 
            this.twitterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(145)))), ((int)(((byte)(218)))));
            this.twitterToolStripMenuItem.Name = "twitterToolStripMenuItem";
            this.twitterToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.twitterToolStripMenuItem.Text = "Twitter";
            this.twitterToolStripMenuItem.Click += new System.EventHandler(this.TwitterToolStripMenuItem_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.donateToolStripMenuItem.Text = "Donate";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.DonateToolStripMenuItem_Click);
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // lb_checkVisible
            // 
            this.lb_checkVisible.AutoSize = true;
            this.lb_checkVisible.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lb_checkVisible.ForeColor = System.Drawing.Color.White;
            this.lb_checkVisible.Location = new System.Drawing.Point(260, 24);
            this.lb_checkVisible.Name = "lb_checkVisible";
            this.lb_checkVisible.Size = new System.Drawing.Size(193, 20);
            this.lb_checkVisible.TabIndex = 11;
            this.lb_checkVisible.Text = "Stay visible as top window";
            this.lb_checkVisible.UseVisualStyleBackColor = true;
            this.lb_checkVisible.CheckedChanged += new System.EventHandler(this.Lb_checkVisible_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(701, 252);
            this.Controls.Add(this.lb_checkVisible);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lb_ram);
            this.Controls.Add(this.lb_cpu);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lb_srv);
            this.Controls.Add(this.lb_ping);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PINGuino";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_ping;
        private System.Windows.Forms.Label lb_srv;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lb_cpu;
        private System.Windows.Forms.Label lb_ram;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showMeCPUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMeRAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.CheckBox lb_checkVisible;
    }
}

