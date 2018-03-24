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
    public partial class CourseDetails : MetroForm
    {
        public CourseDetails()
        {
            List<StaffMemeber> lect;
            InitializeComponent();
            lect = SqlWorker.GetAllLecturers();
            foreach (User u in lect)
                lecturers_list_box.Items.Add(u);
        }

        private void lecturers_list_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lecturers_list_box.SelectedItem!=null)
            {
                List<Course> lC = new List<Course>();
                courses_list_box.Visible = true;
                courses_list_box.Items.Clear();
                lC = SqlWorker.GetStudentCourses((StaffMemeber)lecturers_list_box.SelectedItem);
                foreach (Course c in lC)
                    courses_list_box.Items.Add(c);
                course_name.Text = "";
                course_ID.Text = "";
                course_Lecturer.Text = "";
                course_type.Text = "";
                have_pract.Text = "";
                have_lab.Text = "";
            }
            else
            {
                courses_list_box.Items.Clear();
                courses_list_box.Visible = false;
            }
        }

        private void courses_list_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.courses_list_box.SelectedItem != null)
            {
                Course selcted = (Course)courses_list_box.SelectedItem;
                course_name.Text = "Name: " + selcted.Name;
                course_ID.Text =  "ID: " + selcted.ID;
                course_Lecturer.Text = "lactur: " + selcted.Lecturer.Name;
                if (selcted.Must)
                    course_type.Text = "Required course";
                else course_type.Text = "Permission course";
                if (selcted.havelab)
                    have_lab.Text = "Have lab: yes";
                else have_lab.Text = "Have lab: no";
                if (selcted.haveprac)
                    have_pract.Text = "Have practice: yes";
                else have_pract.Text = "Have practice: no";


            }
        }
    }
}
