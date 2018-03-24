using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_BS_project9
{
    public class Student : User
    {
        // Accessors
        public List<Event>  ActiveEventsList    { set; get; }
        public Curriculum   Curriculum          { set; get; }
        public string       ActiveLects         { set; get; } 
        public string       ActivePracLabs      { set; get; }
        public string       Constraints         { set; get; }
        public string       PassedCourses       { set; get; }

        // 1 - 8
        private int         _semCount;          
        public int          SemCount
        {
            get { return _semCount; }
            set
            {
                if (value < 1 || value > 8)
                    throw new ArgumentException("Must Be integer (1-8)", "SemCount");
                _semCount = value;
            }
        }

        /// <summary>
        /// ctor
        /// </summary>
        public Student(string id, string name, string pwd, string type) : base(id, name, pwd, type)
        {
            init();
        }

        /// <summary>
        /// def ctor
        /// </summary>
        public Student() : base() { init();  }

        /// <summary>
        /// init ActiveEventsList 
        /// </summary>
        private void init() { ActiveEventsList    = new List<Event>(); }
        
    }
}
