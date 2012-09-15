using System;

//using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace Packet_Exchange
{
    internal class Recive
    {
        public AsyncCallback oWorkerCallBack;
        public Socket oSocketListener;
        public Socket oSocketWorker;
        public int ListeningPort = 0;

        public Recive(Int16 whatport)
        {
            ListeningPort = whatport;
            Listen();
        }

        private void Listen()
        {
            try
            {
                //Declare Socket Listener
                oSocketListener = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint oLocalIP = new IPEndPoint(IPAddress.Any, ListeningPort);

                //Local IP Address Binding
                oSocketListener.Bind(oLocalIP);

                //Start Listening
                oSocketListener.Listen(10);

                //Create Callback for Client Connections
                oSocketListener.BeginAccept(new AsyncCallback(OnConnect), null);
                System.Console.WriteLine("Listening on Port : " + ListeningPort);
            }
            catch (SocketException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        public void OnConnect(IAsyncResult oAsyncResult)
        {
            try
            {
                oSocketWorker = oSocketListener.EndAccept(oAsyncResult);
                WaitForData(oSocketWorker);
            }
            catch (ObjectDisposedException)
            {
                System.Diagnostics.Debugger.Log(0, "1",
                    "\n OnConnect: Socket has been closed\n");
            }
            catch (SocketException ex)
            {
                System.Diagnostics.Debugger.Log(0, "1", ex.Message);
            }
        }

        public void WaitForData(System.Net.Sockets.Socket oSocket)
        {
            try
            {
                if (oWorkerCallBack == null)
                    oWorkerCallBack = new AsyncCallback(OnReceive);

                SocketPacket oSocketPacket = new SocketPacket();
                oSocketPacket.oSocket = oSocket;

                // Start Listening for any Data
                oSocket.BeginReceive(oSocketPacket.bDataBuffer, 0,
                    oSocketPacket.bDataBuffer.Length, SocketFlags.None, oWorkerCallBack,
                    oSocketPacket);
            }
            catch (SocketException ex)
            {
                System.Diagnostics.Debugger.Log(0, "1", ex.Message);
            }
        }

        public void OnReceive(IAsyncResult oAsyncResult)
        {
            try
            {
                SocketPacket oSocketID = (SocketPacket)oAsyncResult.AsyncState;

                //Stop Recieve
                int iRecieve = 0;
                iRecieve = oSocketID.oSocket.EndReceive(oAsyncResult);

                //Build the message
                char[] chars = new char[iRecieve + 1];
                System.Text.Decoder d = System.Text.Encoding.UTF8.GetDecoder();
                int iCharLen = d.GetChars(oSocketID.bDataBuffer, 0, iRecieve, chars, 0);
                //string sData = new string(chars);
                Packet_Exchange.Packets.add_to_que(chars[0]);
                //Wait again
                WaitForData(oSocketWorker);
            }
            catch (ObjectDisposedException)
            {
                System.Diagnostics.Debugger.Log(0, "1",
                    "\n OnReceive: Socket has been closed\n");
            }
            catch (SocketException ex)
            {
                System.Diagnostics.Debugger.Log(0, "1", ex.Message);
            }
        }

        public class SocketPacket
        {
            public System.Net.Sockets.Socket oSocket;
            public byte[] bDataBuffer = new byte[1];
        }

        public void dissconnect()
        {
            oSocketListener.Shutdown(SocketShutdown.Receive);
            oSocketWorker.Shutdown(SocketShutdown.Receive);
            oSocketListener.Close();
            oSocketWorker.Close();
        }
    }
}