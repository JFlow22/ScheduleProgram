using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2017_BS_project9
{
    public class Event
    {
        
        // Event ID
        public int ID { set; get; }
        public bool Full { set; get; }

        private int _day;
        public int Day {
            get { return _day; }
            set
            {
                if (value < 1 || value > 6)
                    throw new ArgumentException("Must positive int", "Day");
                _day = value;
            }
        }

        private int _currentCap;
        public int CurrentCap
        {
            get { return _currentCap; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Must positive int", "EventsCount");
                _currentCap = value;
            }
        }

        private int _startHour;
        public int StartTime {
            get { return _startHour; }
            set
            {
                if (value < Globals.StartHour || value > Globals.EndHour)
                    throw new ArgumentException("Must be int (8-22)", "StartHour");
                _startHour = value;
            }
        }

        private int _endHour;
        public int EndTime
        {
            get { return _endHour; }
            set
            {
                if (value < Globals.StartHour || value > Globals.EndHour)
                    throw new ArgumentException("Must be int (8-22)", "StartHour");
                _endHour = value;
            }
        }

        private int _equpment;
        public int Equpment
        {
            get { return _equpment; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Must be positive int!", "Equpment");
                _equpment = value;
            }
        }

        private string _eventType;
        public string EventType {
            get { return _eventType; }
            set
            {
                if (!value.Equals("Lecture") && !value.Equals("Practice") && !value.Equals("Lab"))
                    throw new ArgumentException("Event 'Type' is undefined", "Type");
                _eventType = value;
            }
        }


        public string Room { set; get; }
        public Course ParentCourse { set; get; }
        public StaffMemeber EventStaffMemeber { set; get; }

        // Event btn in ScheduleGrid
        public MetroFramework.Controls.MetroTile btn;
        public override string ToString()
        {
            return EventStaffMemeber.ToString() + ": " + StartTime + ":00 - " + EndTime + ":00";
            //return ParentCourse + ": " + Room + ": " + StartTime + ":00 - " + EndTime + ":00"; 
        }

        public string btn_txt()
        {
            return ParentCourse + "\n" + EventStaffMemeber.ToString() + "\n" + EventType + "\n" + Room + "\n" + StartTime + ":00\n" + EndTime + ":00";
        }
    }
}
