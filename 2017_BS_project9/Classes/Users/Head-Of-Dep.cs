using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_BS_project9
{
    public class Head_Of_Dep : StaffMemeber
    {
        /// <summary>
        /// def ctor
        /// </summary>
        public Head_Of_Dep() : base() { }

        /// <summary>
        /// ctor
        /// </summary>
        public Head_Of_Dep(int id, string name, string pwd, int type) : base(id,name,pwd,type){}
    }
}
