//using System.Linq;
using System.Net;

namespace Packet_Exchange
{
    public static class IP_return
    {
        private static string lan = "";
        private static string wan = "";

        static IP_return()
        {
            IPHostEntry ip = Dns.GetHostByName(Dns.GetHostName());
            lan = ip.AddressList[0].ToString();
            HTTPGet.HTTPGet req = new HTTPGet.HTTPGet();
            req.Request("http://checkip.dyndns.org");
            string[] a = req.ResponseBody.Split(':');
            string a2 = a[1].Substring(1);
            string[] a3 = a2.Split('<');
            wan = a3[0];
        }

        public static string Get_lan()
        {
            return lan;
        }

        public static string Get_Wan()
        {
            return wan;
        }
    }
}