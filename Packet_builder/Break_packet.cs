using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Packet_builder
{
    class Break_packet
    {
        public void disasemble(string packetstring)
        {
            //first seperate into 3 parts and asign to variables
            string[] data = packetstring.Split('|');
            //0 = location
            //1 = action
            //value1
            //value2
            ;
            switch (Convert.ToChar(data[0]))
            {
                    
                case 'A':
                    break;
                case 'B':
                    break;
                case 'C':
                    break;
                case 'D':
                    break;
                case 'E':
                    break;
                case 'F':
                    break;
                case 'G':
                    break;
                case 'H':
                    break;
                case 'I':
                    break;
                case 'J':
                    break;
                case 'K':
                    break;
                case 'L':
                    break;
                case 'M':
                    break;
                case 'N':
                    break;
                case 'O':
                    break;
                case 'P':
                    break;
                case 'Q':
                    break;
                case 'R':
                    break;
                case 'S':
                    break;
                case 'T':
                    break;
                case 'U':
                    break;
                case 'V':
                    break;
                case 'W':
                    break;
                case 'X':
                    break;
                case 'Y':
                    break;
                case 'Z':
                    break;
                default:
                    System.Diagnostics.Debugger.Log(0, "1",
                    "Packet:'" + packetstring + 
                    "' was recived, but action '" + data[1] +
                    "' was not found.");
                    break;
            }
            foreach (string test in data)
            {
                System.Diagnostics.Debugger.Log(0, "1",
                    test + "\r\n");
            }
        }
    }
}
