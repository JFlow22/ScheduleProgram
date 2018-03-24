using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_BS_project9
{
    public class Practitioner : StaffMemeber
    {
        //Constructor
        public Practitioner() : base() {}

        //Constructor
        public Practitioner(string name, string id, string pwd,string type) : base(name, id, pwd,type) {}
    }
}
