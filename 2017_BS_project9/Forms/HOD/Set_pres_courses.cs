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
    public partial class Set_pres_courses : MetroForm
    {
        //Ctor
        public Set_pres_courses()
        {
            InitializeComponent();
            comboBox1.DataSource = SqlWorker.GetDataSet("SELECT CourseName From Courses").Tables[0] ;
            comboBox1.DisplayMember = "CourseName";
            comboBox2.DataSource = SqlWorker.GetDataSet("SELECT CourseName From Courses").Tables[0];
            comboBox2.DisplayMember = "CourseName";
            this.Size = new Size(404, 150);
        }

        //Save the pre course
        private void save_Click(object sender, EventArgs e)
        {
            //Check if any courses was chosen
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please choose pre course and course", "Error"
                               , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Get two strings from combobox
            DataRowView oDataRowView = comboBox1.SelectedItem as DataRowView;
            string preCourse = oDataRowView.Row["CourseName"] as string;
            oDataRowView = comboBox2.SelectedItem as DataRowView;
            string course = oDataRowView.Row["CourseName"] as string;
            //Check if the courses isn't the same
            if (preCourse == course)
            {
                MessageBox.Show("Course can't have himself as pre course", "Error"
                               , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
 
            int success = SqlWorker.addPreCourse(preCourse, course);
            //Show message according to add pre course function
            if (success == 2)
                MessageBox.Show("Action successfully completed.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else if (success == 0)
                MessageBox.Show("The course " + course + " already has " + preCourse + " as pre course!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("The course " + preCourse + " has " + course + " as pre course!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        //Show all pre courses
        private void view_pre_courses_Click(object sender, EventArgs e)
        {
            if(view_pre_courses.Text == "View pre courses")
            {
                view_pre_courses.Text = "Hide pre courses";
                dataGridView1.Visible = true;
                this.Size = new Size(404, 325);

                dataGridView1.DataSource = SqlWorker.GetDataSet("SELECT * From PreCourses").Tables[0];
            }
            else
            {
                view_pre_courses.Text = "View pre courses";
                dataGridView1.Visible = false;
                this.Size = new Size(404, 150);
            }
        }
    }
}
