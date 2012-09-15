using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using Packet_Exchange;
using Packet_builder;
namespace Packet_demo
{
    public partial class Senderform : Form
    {
        Packets packetpusher = null;
        Make_Packet packer = new Make_Packet();
        public Senderform()
        {
            InitializeComponent();
            this.FormClosing += Senderform_FormClosing;
        }
        private void Conect_Click(object sender, EventArgs e)
        {
            packetpusher = new Packets(thisip.Text, Convert.ToInt16(thisport.Text));
            packetpusher.push(packer.Connect("bleh"));
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string data = packer.Text(txtMessage.Text);
            Return_txt.Text = packer.Text(txtMessage.Text);
            packetpusher.push(data);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            packetpusher.push(packer.Disconnect(0));
            packetpusher.disconnect();
        }
        private void Senderform_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                packetpusher.push(packer.Disconnect(0));
            }
            catch
            {
            }
        }
    }
}