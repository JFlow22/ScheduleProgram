using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_BS_project9
{
    public class Secretary : User
    {
        /// <summary>
        /// def ctor
        /// </summary>
        public Secretary() : base() { }


        /// <summary>
        /// ctor
        /// </summary>
        public Secretary(int id, string name, string pwd, int type) : base(id, name, pwd, type) { }
    }
}
