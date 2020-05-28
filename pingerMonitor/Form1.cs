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

            chart1.Legends.Clear();

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



        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //lb_sync_ping.Text = pingHost("8.8.8.8");
        }

        private void Lb_sync_ping_Click(object sender, EventArgs e)
        {

        }
    }
}
