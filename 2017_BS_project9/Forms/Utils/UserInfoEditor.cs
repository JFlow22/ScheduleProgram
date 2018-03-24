using System.Data.SqlClient;
using MetroFramework.Forms;
using System.Windows.Forms;
using System;

namespace _2017_BS_project9
{
    public partial class UserInfoEditor : MetroForm
    {
        Label name_label;
        User user;

        public UserInfoEditor(ref Label name_label, User usr)
        {
            if (usr != null)
                this.user = usr;
            else
                this.user = Globals._session;

            this.name_label = name_label;
            InitializeComponent();
        }



        public void crudUserInfo_Load(object sender, EventArgs e)
        {
                this.name_input.Text = user.Name;
                this.pwd_input.Text = user.Pwd;
                this.id_input.Text = user.ID.ToString();

                if (user.Type.Equals("Student"))
                    this.sem_sbox.SelectedIndex = (user as Student).SemCount - 1;
               
         }

        public void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                user.Name = this.name_input.Text;
                user.Pwd = this.pwd_input.Text;
                if (user.Type == "Student")
                {
                    (user as Student).SemCount = this.sem_sbox.SelectedIndex + 1;
                }
                if(SqlWorker.SaveUser(user))
                    MessageBox.Show("Saved successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        public void VewUpdateUserInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (user != null)
                this.name_label.Text = "Welcome, " + user.Name;
        }
    }
}
