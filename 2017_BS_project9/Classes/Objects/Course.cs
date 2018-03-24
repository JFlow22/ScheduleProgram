using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2017_BS_project9
{
    public class Course
    {
        /// <summary>
        /// 
        /// </summary>
        public int ID { set; get; }
        public string Name { set; get; }
        public bool Must { set; get; }
        public int _eventCount;

        public int EventsCount {
            get { return _eventCount; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Must positive int", "EventsCount");
                _eventCount = value;
            }
        }

        private int _maxCap;
        public int MaxCap
        {
            get { return _maxCap; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Must positive int", "MaxCap");
                _maxCap = value;
            }
        }


        public List<Event> LectEventsList { set; get; }
        public List<Event> PractEventsList { set; get; }
        public List<Event> LabsEventsList { set; get; }
        public Boolean haveprac { set; get; }
        public Boolean havelab { set; get; }
        public string PreReq { set; get; }


        public StaffMemeber Lecturer;
        public StaffMemeber Practitioner;

        /// <summary>
        /// 
        /// </summary>
        public Course() {
            LectEventsList = new List<Event>();
            LabsEventsList = new List<Event>();
            PractEventsList = new List<Event>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString() { return Name; }
    }
}
