using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017_BS_project9
{
    public partial class CoursesInfo : MetroForm
    {
        List<Course> CoursesList;
        public CoursesInfo(List<Course> CoursesList)
        {
            InitializeComponent();
            this.CoursesList = CoursesList;
            foreach (Course co in CoursesList)
                this.courses_list_box.Items.Add(co);
        }

        private void courses_list_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course cours1 = (Course)this.courses_list_box.SelectedItem;
            this.lectures_list_box.Items.Clear();
            this.practices_list_box.Items.Clear();
            this.lab_list_box.Items.Clear();
            foreach (Event ev in cours1.LectEventsList)
                this.lectures_list_box.Items.Add(ev);
            foreach (Event ev in cours1.PractEventsList)
                this.practices_list_box.Items.Add(ev);
            foreach (Event ev in cours1.LabsEventsList)
                this.lab_list_box.Items.Add(ev);
        }

        private void lectures_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Event selcted = (Event)this.lectures_list_box.SelectedItem;
            if (selcted == null)
                return;
            this.practices_list_box.ClearSelected();
            this.lab_list_box.ClearSelected();
            switch (selcted.Day)
            {
                case 1:
                    this.lab_day.Text = "day: Sunday";
                    break;
                case 2:
                    this.lab_day.Text = "day: Monday";
                    break;
                case 3:
                    this.lab_day.Text = "day: Tuesday";
                    break;
                case 4:
                    this.lab_day.Text = "day: Wednesday";
                    break;
                case 5:
                    this.lab_day.Text = "day: Thursday";
                    break;
                case 6:
                    this.lab_day.Text = "day: Friday";
                    break;
            }
            this.lab_start.Text = "start: "+ selcted.StartTime + ":00";
            this.lab_end.Text = ",end: "+ selcted.EndTime + ":00";
            this.lab_lactur.Text = "Teaches: "+ selcted.EventStaffMemeber.ToString();
            this.lab_room.Text = "room: " + selcted.Room;
        }

        private void practices_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Event selcted = (Event)this.practices_list_box.SelectedItem;
            if (selcted == null)
                return;
            this.lectures_list_box.ClearSelected();
            this.lab_list_box.ClearSelected();
            switch (selcted.Day)
            {
                case 1:
                    this.lab_day.Text = "day: Sunday";
                    break;
                case 2:
                    this.lab_day.Text = "day: Monday";
                    break;
                case 3:
                    this.lab_day.Text = "day: Tuesday";
                    break;
                case 4:
                    this.lab_day.Text = "day: Wednesday";
                    break;
                case 5:
                    this.lab_day.Text = "day: Thursday";
                    break;
                case 6:
                    this.lab_day.Text = "day: Friday";
                    break;
            }
            this.lab_start.Text = "start: " + selcted.StartTime + ":00";
            this.lab_end.Text = ",end: " + selcted.EndTime + ":00";
            this.lab_lactur.Text = "Teaches: " + selcted.EventStaffMemeber.ToString();
            this.lab_room.Text = "room: " + selcted.Room;
        }

        private void lab_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Event selcted = (Event)this.lab_list_box.SelectedItem;
            if (selcted == null)
                return;
            this.practices_list_box.ClearSelected();
            this.lectures_list_box.ClearSelected();
            switch (selcted.Day)
            {
                case 1:
                    this.lab_day.Text = "day: Sunday";
                    break;
                case 2:
                    this.lab_day.Text = "day: Monday";
                    break;
                case 3:
                    this.lab_day.Text = "day: Tuesday";
                    break;
                case 4:
                    this.lab_day.Text = "day: Wednesday";
                    break;
                case 5:
                    this.lab_day.Text = "day: Thursday";
                    break;
                case 6:
                    this.lab_day.Text = "day: Friday";
                    break;
            }
            this.lab_start.Text = "start: " + selcted.StartTime + ":00";
            this.lab_end.Text = ",end: " + selcted.EndTime + ":00";
            this.lab_lactur.Text = "Teaches: " + selcted.EventStaffMemeber.ToString();
            this.lab_room.Text = "room: " + selcted.Room;
        }
    }
}
