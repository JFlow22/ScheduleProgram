using MetroFramework.Forms;
using System.Windows.Forms;

namespace _2017_BS_project9
{
    public partial class HODControlPanelForm : MetroForm
    {
        /**
         * sender form
         */

        public HODControlPanelForm()
        {
            InitializeComponent();
            // if user has a facebook login, hide the btn
            if (Globals._session.FB_ID != null)
                this.facebook_login_btn.Hide();
        }

        private void info_btn_Click(object sender, System.EventArgs e)
        {
            this.Enabled = false;
            UserInfoEditor form = new UserInfoEditor(ref this.userNameLable, null);
            form.ShowDialog();
            this.Enabled = true;

        }

        private void HODControlPanelForm_Load(object sender, System.EventArgs e)
        {
            if (Globals._session != null)
                this.userNameLable.Text = "Welcome, " + Globals._session.Name;
            else
                this.userNameLable.Text = "Welcome, Test User";
        }

        private void course_info_btn_Click(object sender, System.EventArgs e)
        {
            Form fo = new CreateCurri(SqlWorker.GetAllCourses());
            fo.Show();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            Enter_courses_or_pre edit_courses = new Enter_courses_or_pre();
            this.Enabled = false;
            edit_courses.ShowDialog();
            this.Enabled = true;
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            Work_Hours work_hours = new Work_Hours();
            this.Hide();
            work_hours.ShowDialog();
            this.Show();
        }

        private void facebook_login_btn_Click(object sender, System.EventArgs e)
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
