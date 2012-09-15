using Packet_Exchange;

namespace Packet_builder
{
    public class Make_Packet
    {
        private string location = "0.0.0.0";

        public Make_Packet()
        {
            try
            {
                location = IP_return.Get_Wan();
            }
            catch
            {
            }
        }

        public string A_() { return "NULL"; }

        public string B_Buy(int itemid) { return Build('B', itemid); }

        //a
        public string C_Connect(string username) { return Build('C', username); }

        public string D_Disconnect(int reason) { return Build('D', reason); }

        //connect:
        public string E_Enemy_Move(double X, double Y) { return Build('E', X, Y); }

        public string F_Fire(double X, double Y) { return Build('F', X, Y); }

        //enemymove:x,y
        public string G_() { return "NULL"; }

        public string H_Hit_Entity(int entityid) { return Build('H', entityid); }

        public string I_Item_get(int itementid) { return Build('I', itementid); }

        public string J_Item_Sale(int itemid) { return Build('K', itemid); }

        public string K_Kill_Enemy(int entityid) { return Build('K', entityid); }

        public string L_Kill_player(int playerid) { return Build('L', playerid); }

        public string M_Move_Player(double X, double Y) { return Build('M', X, Y); }

        public string N_Drop_pickup() { return "NULL"; }

        public string O_Vote_procide() { return "NULL"; }

        public string P_Place(double X, double Y) { return Build('P', X, Y); }

        public string Q_VoteKIck() { return "NULL"; }

        //place:gridx,gridy
        public string R_() { return Build('R', 0); }

        public string S_Sell(int itemid) { return Build('S', itemid); }

        public string T_Text(string message) { return Build('T', message); }

        public string U_() { return "NULL"; }

        public string V_() { return "NULL"; }

        public string W_() { return "NULL"; }

        public string X_() { return "NULL"; }

        public string Y_() { return "NULL"; }

        public string Z_Keepalive() { return "NULL"; }

        private string Build(char address, string data)
        {
            return '{' + location + "|" + address + "|" + data + '}';
        }

        private string Build(char address, int data)
        {
            return '{' + location + "|" + address + "|" + data + '}';
        }

        private string Build(char address, double X, double Y)
        {
            return '{' + location + "|" + address + "|" + X + "|" + Y + '}';
        }
    }
}