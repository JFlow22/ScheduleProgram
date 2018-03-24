using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_BS_project9
{
    public static class Globals
    {
        /* Global Variables */

        public static Random rnd = new Random();
        /// <summary>
        ///  Conn string
        /// </summary>

        public static string connString = "Server=tcp:group-a-server.database.windows.net,1433;Initial Catalog = Group_A_DB; Persist Security Info=False;User ID = groupa; Password=1q2w#E$R;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout " +
            "= 30;";

        public static int MinSem = 1;
        public static int MaxSem = 8;
        public static int minDay = 1;
        public static int MaxDay = 6;
        public static int StartHour = 8;
        public static int EndHour = 22;


        /* Global Objects */

        /// <summary>
        /// Current Logged in User
        /// </summary>
        public static User _session;
    }
}
