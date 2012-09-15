using System;

//using System.Linq;
using System.Net.Sockets;

namespace Packet_Exchange
{
    public class Send
    {
        private Socket oSocket = null;
        private string sRecieverIP = "0.0.0.0";
        private int iRecieverPort = 7777;

        public Send(string ip, Int16 port)
        {
            sRecieverIP = ip;
            iRecieverPort = port;
            Connect();
        }

        public void push(string data)
        {
            try
            {
                byte[] bData = System.Text.Encoding.ASCII.GetBytes(data);
                oSocket.Send(bData);
            }
            catch (ArgumentNullException ane)
            {
                System.Diagnostics.Debugger.Log(0, "1", ane.Message);
                System.Diagnostics.Debugger.Log(0, "1", data);
            }

            catch (SocketException se)
            {
                System.Diagnostics.Debugger.Log(0, "1", se.Message);
            }
        }

        private void Connect()
        {
            try
            {
                //Creating a Client Socket
                oSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
                    ProtocolType.Tcp);

                System.Net.IPAddress oIPAddress = System.Net.IPAddress.Parse(sRecieverIP);
                System.Net.IPEndPoint oEndPoint = new System.Net.IPEndPoint(oIPAddress,
                    iRecieverPort);
                oSocket.Connect(oEndPoint);
            }
            catch (SocketException se)
            {
                System.Diagnostics.Debugger.Log(0, "1", se.Message);
            }
        }

        public void Disconnect()
        {
            //Close socket on both sender and receiver
            oSocket.Shutdown(SocketShutdown.Send);
            oSocket.Close();
        }
    }
}