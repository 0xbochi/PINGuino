using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pingerMonitor
{


    public partial class Form1 : Form
    {

        public static class statusSoft
        {
            public static bool showCPU ;
            public static bool showRAM ;

        }


        public int seconds { get; set; }
        public int ping { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private string pingHost(string host)
        {
            System.Net.NetworkInformation.Ping pinger = new Ping();
            PingReply reply = pinger.Send(host);

            return (reply.RoundtripTime).ToString();


        }




        private void Form1_Load(object sender, EventArgs e)
        {
            //lb_sync_ping.Text = pingHost("8.8.8.8");
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            chart1.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            chart1.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;

            chart1.ChartAreas[0].AxisY.Minimum = 5;
            chart1.ChartAreas[0].AxisY.Maximum = 150;

            chart1.Legends.Clear();

            lb_cpu.Visible = false;
            lb_ram.Visible = false;

           

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            string ping = pingHost("8.8.8.8");
            lb_ping.Text = "Ping : " + ping + " MS";
            chart1.Series["ping"].Points.AddY(ping);

            int colorPing = Convert.ToInt32(ping);

            if (colorPing <= 25)
            {
                lb_ping.ForeColor = System.Drawing.Color.White;
            }
            if (colorPing > 25 && colorPing < 55)
            {
                lb_ping.ForeColor = System.Drawing.Color.Green;
            }

            if (colorPing > 55 && colorPing < 80)
            {
                lb_ping.ForeColor = System.Drawing.Color.Brown;
            }

            if (colorPing > 80)
            {
                lb_ping.ForeColor = System.Drawing.Color.Red;
            }

            if (colorPing < 0)
            {
                colorPing = 0;
            }
            
            
            if (chart1.Series["ping"].Points.Count >= 300)
            {
                foreach(var series in chart1.Series)
                {
                    chart1.Series[0].Points.RemoveAt(0);
                    chart1.ResetAutoValues();
                }
            }

            if (statusSoft.showRAM == true)
            {
                lb_ram.Visible = true;
                float fram = pRAM.NextValue();
                lb_ram.Text = "RAM : " + string.Format("{0:0.00}%", fram);

            }

            if (statusSoft.showCPU == true)
            {
                lb_cpu.Visible = true;
                float fcpu = pCPU.NextValue();
                lb_cpu.Text = "CPU : " + string.Format("{0:0.00}%", fcpu);
            }




            /*
            if (statusSoft.showCPU == true)
            {
                //float fcpu = pCPU
            }
            */



        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //lb_sync_ping.Text = pingHost("8.8.8.8");
        }

        private void Lb_sync_ping_Click(object sender, EventArgs e)
        {

        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void Lb_ram_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ShowMeCPUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusSoft.showCPU == true)
            {
                statusSoft.showCPU = false;
                lb_cpu.Visible = false;
                showMeCPUToolStripMenuItem.Text = "Show me CPU";
            }
            else
            {
                statusSoft.showCPU = true;
                showMeCPUToolStripMenuItem.Text = "Hide CPU";
            }
        }

        private void Lb_ram_Click_1(object sender, EventArgs e)
        {

        }

        private void ShowMeRAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusSoft.showRAM == true)
            {
                statusSoft.showRAM = false;
                lb_ram.Visible = false;
                showMeRAMToolStripMenuItem.Text = "Show me RAM";
            }
            else
            {
                statusSoft.showRAM = true;
                showMeRAMToolStripMenuItem.Text = "Hide RAM";
            }

        }

        private void GitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/devbosch");

        }

        private void TwitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/__Wrath__404__");

        }

        private void DonateToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            System.Diagnostics.Process.Start("https://www.paypal.me/LePrince");
        }

        private void Lb_checkVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (lb_checkVisible.Checked == true)
            {
                TopMost = true;
                Opacity = 0.75;
                Form1.ActiveForm.FormBorderStyle =  FormBorderStyle.None;
                pictureBox1.Visible = false;
                menuStrip1.Visible = false;
                lb_srv.Visible = false;
            }
            if (lb_checkVisible.Checked == false)
            {
                TopMost = false;
                Opacity = 1;
                Form1.ActiveForm.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                pictureBox1.Visible = true;
                menuStrip1.Visible = true;
                lb_srv.Visible = true;
            }


        }
    }
}
