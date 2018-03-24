using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_BS_project9
{
    public class Lecturer : StaffMemeber
    {
        private int num_of_courses;

        //Constructor
        public Lecturer() : base()
        {
            num_of_courses = 0;
        }

        //Constructor
        public Lecturer(string name,string id,string pwd,string type) : base (name, id, pwd,type)
        {
            num_of_courses = 0;
        }

        //Get num of courses
        public int getNumOfCourses() { return num_of_courses; }
    }
}
