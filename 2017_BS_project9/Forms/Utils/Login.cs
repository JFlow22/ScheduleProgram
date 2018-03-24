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
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = this.login_button;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (auth())
                    starter(false);
            }
            /// Main Error handler
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message.ToString(), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //login_button_Click(sender, e);

            }
        }

        //Check if the id contains only digits.
        //Public for the unit tests.
        public bool IsDigits(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Login worker.
        /// Use this for testing log in
        /// </summary>
        /// <returns></returns>
        public bool auth()
        {
            if (!IsDigits(this.id_textbox.Text))
                throw new Exception("Make sure that your id contains only digits");
            if (!SqlWorker.CheckForInternetConnection())
                throw new Exception("There is no internet connection.\nPlease try again later.");

            string f_id = this.id_textbox.Text.ToString();
            string f_pwd = this.pwd_textbox.Text.ToString();


            User usr = SqlWorker.GetUser(f_id);
            // check if we found it and if pwds much
            if (usr == null || usr.Pwd != f_pwd)
                throw new Exception("User not found or Password is incorrect");

            //  set session user
            Globals._session = usr;
            return true;
        }

        public bool starter(bool isTest)
        {
            Form cPanel;
            switch (Globals._session.Type)
            {
                case "Student":
                    cPanel = new StudentControlPanelForm();
                    break;
                case "Secretary":
                    cPanel = new secretary_junction_from();
                    //cPanel = new SecretaryControlPanelForm();
                    break;
                case "HeadOfDep":
                    cPanel = new HODControlPanelForm();
                    break;
                case "Lecturer":
                    cPanel = new Lecturer_Form();
                    break;
                case "Practitioner":
                    cPanel = new Practitioner_Form();
                    break;
                case "HouseKeeper":
                    cPanel = new HouseKeeperControlPanelForm();
                    break;
                default:
                    throw new Exception("User Type not defind");
            }

            this.Hide();
            if (!isTest)
            {
                cPanel.StartPosition = FormStartPosition.CenterScreen;
                cPanel.ShowDialog();
                //Remove old id and password
                id_textbox.Text = "";
                pwd_textbox.Text = "";
                this.Show();
            } else { this.Close(); }
            return true;
        }

        private void facebook_login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string facebook_id = this.facebook_login_btn.getLoginData()["id"];
                User FB_User = SqlWorker.FB_Exists(facebook_id);
                if (FB_User != null)
                {
                    Globals._session = FB_User;
                    starter(false);
                }
                else
                {
                    MessageBox.Show("User does not found in DB. Did you register?");
                }
            } catch
            {
                MessageBox.Show("Login with Facebook Failded!\n Please try again!");
            }
        }
    }
}
