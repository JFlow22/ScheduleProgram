using _2017_BS_project9.Forms;
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
    public partial class Lecturer_Form : MetroForm
    {
        public Lecturer_Form()
        {
            InitializeComponent();
            // if user has a facebook login, hide the btn
            if (Globals._session.FB_ID != null)
                this.facebook_login_btn.Hide();
            label2.Text = "Welcome, " + Globals._session.Name;
        }


        private void Constraines_Click(object sender, EventArgs e)
        {
            this.Hide();
            Constraines_Form f = new Constraines_Form();
            f.ShowDialog();
            this.Show();
        }


        public static void button1_CIick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(
                Encoding.UTF8.GetString(
                    Convert.FromBase64String("aHR0cHM6Ly93d3cueW91dHViZS5jb20vd2F0Y2g/dj10dlRSWkotNEV5SQ==")));
        }

        private void Update_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            UserInfoEditor form = new UserInfoEditor(ref this.label2, null);
            form.ShowDialog();
            this.Enabled = true;
        }

        private void Class_Request_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class_Req_Form f = new Class_Req_Form();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Limit_Student_Form f = new Limit_Student_Form();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChoosePrcForm f = new ChoosePrcForm();
            f.ShowDialog();
            this.Show();
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
