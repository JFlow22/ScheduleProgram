using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_BS_project9
{
    public class StaffMemeber : User
    {
        public List<Course> CoursesList;
        public List<Event> EventsList;
        public string respHours;

        /// <summary>
        /// def ctor
        /// </summary>
        public StaffMemeber() : base() { }

        /// <summary>
        /// 
        /// </summary>
        public StaffMemeber(int id, string name, string pwd, int type) : base(id, name, pwd, type)
        {

            CoursesList = new List<Course>();
            EventsList = new List<Event>();
        }
        public StaffMemeber(User u) : base(u)
        {
            CoursesList = new List<Course>();
            EventsList = new List<Event>();
        } 

        /// <summary>
        /// 
        /// </summary>
        public StaffMemeber(object id, object name, object pwd, object type) : base(id, name, pwd, type)
        {

            CoursesList = new List<Course>();
            EventsList = new List<Event>();
        }

        /// <summary>
        /// Staff member does not needs all the data to be shown
        /// </summary>
        /// <returns>name- string</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
