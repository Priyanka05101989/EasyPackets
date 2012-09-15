using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Packet_Exchange
{
    public enum Dissconect_Reasons
    {
        Closed_By_Remote = 0,
        Closed_By_Host = 1,
        Timeout = 2,
        Kicked = 3,
        Invalid_Responce = 4
    }
    public class Packets
    {
        Send sender = null;
        Recive reciver = null;
        static List<string> myList = new List<string>();
        static List<char> mybuffer = new List<char>();
        public Packets(string ip_address, Int16 port)
        {
            sender = new Send(ip_address, port);
        }
        public Packets(Int16 port)
        {
            reciver = new Recive(port);
        }
        public void push(string data)
        {
            sender.push(data);
        }
        public bool senderisconected()
        {
            if (sender == null)
                return false;
            else
                return true;
        }
        public bool reciverisconected()
        {
            if (reciver == null)
                return false;
            else
                return true;
        }
        public void disconnect()
        {
            if (sender != null)
            {
                sender.Disconnect();
                sender = null;
            }
            if (reciver != null)
            {
                reciver.dissconnect();
                reciver = null;
            }
        }
        public static void add_to_que(char data)
        {
            mybuffer.Add(data);
            checkbuffer();
        }
        public static bool queempty()
        {
            if (myList.Count >= 1)
                return false;
            else
                return true;
        }
        private static void checkbuffer()
        {
            if (mybuffer.Contains('}'))
            {
                string vr = "";
                    foreach(char thing in mybuffer)
                    {
                        vr +=thing;
                    }
                    myList.Add(vr);
                    mybuffer.Clear();
            }
        }
        public static string takefirstitem()
        {
            System.Diagnostics.Debugger.Log(0,"1", myList[0] +"\r\n");
            string data = myList[0];
            myList.Remove(myList[0]);
            return data;
        }
    }
}
