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
    public partial class SecretarySchduleStaffForm : MetroForm
    {
        private User secretary;
        public SecretarySchduleStaffForm()
        {
            InitializeComponent();
            secretary = Globals._session;
            // if user has a facebook login, hide the btn
            if (Globals._session.FB_ID != null)
                this.facebook_login_btn.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        private void Add_User_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adding_User_Form f = new Adding_User_Form();
            f.ShowDialog();
            this.Show();
        }


        private void class_filter_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search_Class_By_Type_Form f = new Search_Class_By_Type_Form();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Searching_Filtering_Practices_Form f = new Searching_Filtering_Practices_Form();
            f.ShowDialog();
            this.Show();
        }


        private void Class_Change_Click(object sender, EventArgs e)
        {
            this.Hide();
            Secretary_Change_Class_Form f = new Secretary_Change_Class_Form();
            f.ShowDialog();
            this.Show();
        }

        private void Secretary_Form_Load(object sender, EventArgs e)
        {
            label2.Text = "Welcome, " + Globals._session.Name;
        }

        private void lecture_filter_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Searching_Filtering_Lectures_Form f = new Searching_Filtering_Lectures_Form();
            f.ShowDialog();
            this.Show();
        }

        private void Change_Class_Click(object sender, EventArgs e)
        {
            this.Hide();
            Secretary_Change_Class_Form f = new Secretary_Change_Class_Form();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Deleting_LecturerPractitioner_Form f = new Deleting_LecturerPractitioner_Form();
            f.ShowDialog();
            this.Show();
        }

        private void ShowPraLec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Secretary_Show_Lecturer_Practitioner_Form f = new Secretary_Show_Lecturer_Practitioner_Form();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Secretary_Change_Lec_Pra_Time_Form f = new Secretary_Change_Lec_Pra_Time_Form();
            f.ShowDialog();
            this.Show();
        }

        private void AddLecture_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adding_Lecture_Form f = new Adding_Lecture_Form();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click_12(object sender, EventArgs e)
        {
            this.Hide();
            SeeAvailableHoursForm f = new SeeAvailableHoursForm();
            f.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForSubstitute_Form f = new SearchForSubstitute_Form();
            f.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Secretary_Show_Available_Classes_Form f = new Secretary_Show_Available_Classes_Form();
            f.ShowDialog();
            this.Show();
        }

        private void AddPractice_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adding_PracticeLab_Form f = new Adding_PracticeLab_Form();
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
