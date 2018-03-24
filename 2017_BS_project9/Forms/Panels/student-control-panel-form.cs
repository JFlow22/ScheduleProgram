using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace _2017_BS_project9
{
    public partial class StudentControlPanelForm : MetroForm
    {
        StudentScheduler StudentSchedulerForm;

        public StudentControlPanelForm()
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
        private void ControlPanelForm_Load(object sender, EventArgs e)
        {
            if (Globals._session != null)
                this.userNameLable.Text = "Welcome, " + Globals._session.Name;
            else
                this.userNameLable.Text = "Welcome, Test User";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void info_btn_Click(object sender, EventArgs e)
        {
            UserInfoEditor form = new UserInfoEditor(ref this.userNameLable, null);
            form.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTile1_Click(object sender, EventArgs e)
        {
            ScheduleDayView form = new ScheduleDayView(null);
            form.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTile4_Click(object sender, EventArgs e)
        {
            Under_Construction UC = new Under_Construction();
            UC.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scheduler_btn_click(object sender, EventArgs e)
        {
            StudentSchedulerForm = new StudentScheduler(null);
            StudentSchedulerForm.Show();
        }

        private void week_view_Click(object sender, EventArgs e)
        {
            ScheduleWeekView form = new ScheduleWeekView(null);
            form.Show();
        }

        private void set_constrains_btn_Click(object sender, EventArgs e)
        {
            Form form = new StudentConstains(null);
            form.Show();
        }


        private void courseBT_Click(object sender, EventArgs e)
        {
            Form form = new CourseDetails();
            form.Show();
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            Form cf = new CoursesInfo(SqlWorker.GetAllCourses());
            cf.Show();
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
