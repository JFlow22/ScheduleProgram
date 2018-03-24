using _2017_BS_project9;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _2017_BS_project9
{
    public partial class SecretarySchduleStudetnsForm : MetroForm
    {
        /**
         * sender form
         */

        public SecretarySchduleStudetnsForm()
        {
            InitializeComponent();
            // if user has a facebook login, hide the btn
            if (Globals._session.FB_ID != null)
                this.facebook_login_btn.Hide();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        

        private void SecretaryControlPanelForm_Load(object sender, EventArgs e)
        {
            if (Globals._session != null)
                this.userNameLable.Text = "Welcome, " + Globals._session.Name;
            else
                this.userNameLable.Text = "Welcome, Test User";
        }

        private void course_info_btn_Click(object sender, EventArgs e)
        {
            Form cf = new CoursesInfo(SqlWorker.GetAllCourses());
            cf.Show();
        }

        private void Show_Curri_btn_Click(object sender, EventArgs e)
        {
            List<Curriculum> l_c = new List<Curriculum>();
            for (int i = 1; i < 9; i++)
            {
                Curriculum cur = new Curriculum(i);
                l_c.Add(cur);
            }
            Form form = new CurriculumsList(l_c);
            form.Show();
        }

        private void set_schedule_btn_Click(object sender, EventArgs e)
        {
            Form form = new SetStudentSchedule(SqlWorker.GetAllStudents());
            form.Show();
        }

        private void add_student_btn_Click(object sender, EventArgs e)
        {
            Form form = new AddStudent();
            form.Show();
        }

        private void delete_stud_btn_Click(object sender, EventArgs e)
        {
            Form form = new DeleteStudent(SqlWorker.GetAllStudents());
            form.Show();
        }

        private void pass_stud_crs_btn_Click(object sender, EventArgs e)
        {
            Form form = new PassStudentCourse(SqlWorker.GetAllStudents());
            form.Show();
        }

        private void facebook_login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Globals._session.FB_ID = this.facebook_login_btn.getLoginData()["id"];
                if (Globals._session.FB_ID != null && Globals._session.FB_ID != "")
                    if (SqlWorker.SaveUser(Globals._session))
                    {
                        MessageBox.Show("User Was Connected To Facebook seccessfuly!");
                        this.Close();
                    }
            }
            catch
            {
                MessageBox.Show("Login with Facebook Failded!\n Please try again!");
            }
        }
    }
}
