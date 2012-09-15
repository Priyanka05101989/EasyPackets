using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Packet_Exchange;
namespace Part2
{
    public partial class Reciver_form : Form
    {
        Packets packetpuller = null;
        public Reciver_form()
        {
            InitializeComponent();
            My_lanip.Text = Packet_Exchange.IP_return.Get_lan();
            My_Wanip.Text = Packet_Exchange.IP_return.Get_Wan();
        }
        private void Listen_Click(object sender, EventArgs e)
        {
            packetpuller = new Packets(Convert.ToInt16(theport.Text));
            lblApplicationMessage.Text = "Listining to port:" + theport.Text;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool isquempty = Packets.queempty();
            if (!isquempty)
            {
                txtMessageRecieved.Text += Packets.takefirstitem();
            }
        }
    }
}