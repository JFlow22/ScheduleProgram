using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_BS_project9
{
    class Room
    {
        private int _capacity;
        public int Capacity {
            get { return _capacity; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Capacity is only valid count!", "Capacity");
                _capacity = value;
            }
        }

        public bool IsLab { set; get; }
        public bool HasProjector { set; get; }

        private int _num_of_comps;
        public int NumOfComputers
        {
            get { return _num_of_comps; }
            set
            {
                if (_num_of_comps < 0)
                    throw new ArgumentException("Number of comps is only positive!", "Number of comps");
                _num_of_comps = value;
            }
        }
    }
}
