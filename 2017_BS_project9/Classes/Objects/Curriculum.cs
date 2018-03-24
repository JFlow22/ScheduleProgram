using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_BS_project9
{
    public class Curriculum
    {
        public List<Course> Courses { set; get; }

        private int _semester;
        public int Semester {
            get { return _semester; }
            set
            {
                if (value < 1 || value > 8)
                    throw new ArgumentException("Must Be integer (1-8)", "Semester");
                _semester = value;
            }
        }
       
        public Curriculum() { Courses = new List<Course>(); }
        public Curriculum(int Semester)
        {
            this.Semester = Semester;
            Courses = new List<Course>();
            Courses = builder(SqlWorker.GetCurriculumString(this.Semester));
        }


        /// <summary>
        /// build courses list for curriculum
        /// </summary>
        /// <param name="coursesString"></param>
        /// <returns></returns>
        private List<Course> builder(string coursesString)
        {
            List<Course> result = new List<Course>();
            // for each crs name in splitted string
            foreach (string crsName in coursesString.Split(','))
            {
                if (crsName == "")
                    continue;
                // create new crs
                Course crs = new Course();
                // get course from db
                crs = SqlWorker.GetCoures(crsName.Trim());
                // fill lectures
                crs.LectEventsList = SqlWorker.GetLects(crs);
                // fill Practice and Lab of the curse
                crs.PractEventsList = SqlWorker.GetPracts(crs);
                crs.LabsEventsList = SqlWorker.GetLabs(crs);

                result.Add(crs);
            }

            return result;
        }
    }

}
