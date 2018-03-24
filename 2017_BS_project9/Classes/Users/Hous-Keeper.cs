using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_BS_project9
{
    public class House_keeper : User
    {
        /// <summary>
        /// def ctor
        /// </summary>
        public House_keeper() : base() { }

        /// <summary>
        /// ctor
        /// </summary>
        public House_keeper(int id, string name, string pwd, int type) : base(id, name, pwd, type) { }
    }
}
