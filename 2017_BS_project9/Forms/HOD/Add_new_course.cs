using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MetroFramework.Forms;

namespace _2017_BS_project9
{
    public partial class Add_new_course : MetroForm
    {
        //Constructor
        public Add_new_course()
        {
            InitializeComponent();
            this.Size = new Size(351, 375);
            if (SqlWorker.getAmountOfLecturers() > 1 && SqlWorker.getAmountOfPractitioners() > 1)
            {
                LecturerID_combo.DataSource = SqlWorker.GetDataSet("SELECT * From Users Where type='Lecturer'").Tables[0];
                LecturerID_combo.DisplayMember = "Name";
                practitionerID_combo.DataSource = SqlWorker.GetDataSet("SELECT * From Users Where type='Practitioner'").Tables[0];
                practitionerID_combo.DisplayMember = "Name";
            }
            else
            {
                MessageBox.Show("There is no practitioners/lecturers in the system!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        //Set the color of textbox to black when enter
        private void course_textbox_Enter(object sender, EventArgs e)
        {
            if (course_textbox.ForeColor == Color.Gray)
            {
                course_textbox.ForeColor = Color.Black;
                course_textbox.Text = "";
            }
        }

        //If there was text - leave text color as black
        //If the textbox is empty - set it back to gray
        private void course_textbox_Leave(object sender, EventArgs e)
        {
            if (course_textbox.Text == "")
            {
                course_textbox.ForeColor = Color.Gray;
                course_textbox.Text = "Course name";

            }
        }

        //When the save button is pressed
        private void save_button_Click(object sender, EventArgs e)
        {
            Regex checkName = new Regex("^[A-Za-z0-9 ]+$");
            //check if the course name is invaild or empty
            if (!checkName.IsMatch(course_textbox.Text) || course_textbox.ForeColor == Color.Gray)
            {
                MessageBox.Show("Course name invaild!\nMake sure that the name contains only letters and numbers", "Error"
                               , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Check if lecturer was chosen
            if(LecturerID_combo.SelectedItem == null)
            {
                MessageBox.Show("You must chose lecturer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Check if practitioner was chosen
            if (practitionerID_combo.SelectedItem == null)
            {
                MessageBox.Show("You must chose practitioner", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Check if lecture duration was chosen
            if (Lectur_duration_combobox.SelectedItem == null)
            {
                MessageBox.Show("You must choose lecture duration for a course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Check if some item was selected in the practice/lab duration list
            if (Practice_checkbox.Checked && Practice_duration_combobox.SelectedItem == null)
            {
                MessageBox.Show("Please chose practice duration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Lab_Checkbox.Checked && lab_duration_combobox.SelectedItem == null)
            {
                MessageBox.Show("Please chose lab duration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            //Check if at least 1 check box is checked
            if(!Lab_Checkbox.Checked && !Practice_checkbox.Checked)
            {
                MessageBox.Show("For a course there must be at least lab and/or practice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Create new connection to write to database

            DataRowView oDataRowView = LecturerID_combo.SelectedItem as DataRowView;
            int lecturerID = (int)oDataRowView.Row["ID"];
            oDataRowView = practitionerID_combo.SelectedItem as DataRowView;
            int practitionerID = (int)oDataRowView.Row["ID"];
            //Check if the course exists
            if (SqlWorker.checkCourseExistence(course_textbox.Text))
            {
                MessageBox.Show("The course " + course_textbox.Text + " already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string practiceDur = null, labDur = null;
            //Show confirm message
            string messageString = "Are you sure you want to add the following course to the department?"
                + "\nName: " + course_textbox.Text
                + "\nLecturer ID: " + lecturerID.ToString()
                + "\nPractitioner ID: " + practitionerID.ToString()
            + "\nLecutre duration: " + Lectur_duration_combobox.SelectedItem;
            if (Practice_checkbox.Checked)
            {
                messageString += "\nPractice duration: " + Practice_duration_combobox.SelectedItem;
                practiceDur = Practice_duration_combobox.SelectedItem.ToString();
            }
            if (Lab_Checkbox.Checked)
            {
                messageString += "\nLab duration: " + lab_duration_combobox.SelectedItem;
                labDur = lab_duration_combobox.SelectedItem.ToString();
            }
            DialogResult resault = MessageBox.Show(messageString, "Before you continue" , MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            //If the user click ok, add the course to database
            if (resault == DialogResult.OK)
            {
                SqlWorker.addCourse(course_textbox.Text, lecturerID.ToString(), practitionerID.ToString(),
                    Lectur_duration_combobox.SelectedItem.ToString(), practiceDur, labDur, checkBox1.Checked);
                MessageBox.Show("Course successfully added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }

        //Enable practice duration list if practice check box is checked
        private void Practice_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Practice_checkbox.Checked)
                Practice_duration_combobox.Enabled = true;
            else
                Practice_duration_combobox.Enabled = false;
        }

        //Enable lab duration list if lab check box is checked
        private void Lab_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Lab_Checkbox.Checked)
                lab_duration_combobox.Enabled = true;
            else
                lab_duration_combobox.Enabled = false;
        }

        //Show course list
        private void View_courses_Click(object sender, EventArgs e)
        {
            if(View_courses.Text == "View courses")
            {
                View_courses.Text = "Hide courses";
                this.Size = new Size(351, 561);
                dataGridView1.Visible = true;
 
                dataGridView1.DataSource = SqlWorker.GetDataSet("SELECT CourseId,CourseName From Courses").Tables[0];
            }
            else
            {
                View_courses.Text = "View courses";
                this.Size = new Size(351, 375);
                dataGridView1.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to make this course optional?",
                    "Before you continue", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    checkBox1.Checked = true;
                }
            }
        }
    }
}
