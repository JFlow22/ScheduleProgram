using System.Data.SqlClient;
using MetroFramework.Forms;
using System.Windows.Forms;
using System;
using System.Data;

namespace _2017_BS_project9
{
    public partial class AddStudent : MetroForm
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaveUser())
                    MessageBox.Show("Added successfully!");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool SaveUser()
        {
            if (this.name_input.Text != ""
                   && this.id_input.Text != ""
                   && this.sem_sbox.Text != "")
            {
                try
                {
                    DataTable users_list = SqlWorker.GetUsersList();
                    Student student = new Student();
                    student.Type = "Student";
                    student.Name = this.name_input.Text;
                    student.ID = this.id_input.Text;
                    student.Pwd = this.pwd_input.Text;
                    student.SemCount = int.Parse(this.sem_sbox.Text);

                    foreach (DataRow row in users_list.Rows)
                    {
                        if ((row["id"].ToString()) == this.id_input.Text )
                        {
                            if (row["Type"].ToString() == "Student")
                            {
                                // Configure the message box to be displayed
                                string messageBoxText = "Student with that ID is already in system. Do you want to update?";
                                string caption = "Confirme Update";

                                if (MessageBox.Show(messageBoxText, caption, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    Student DbStudent = (Student)SqlWorker.GetUser(student.ID.ToString());
                                    student.ActiveLects = DbStudent.ActiveLects;
                                    student.ActivePracLabs = DbStudent.ActivePracLabs;
                                    student.Constraints = DbStudent.Constraints;

                                    if (SqlWorker.SaveUser(student))
                                        return true;
                                }
                                return false;
                            }
                            else
                            {
                                MessageBox.Show("User with that ID is already in system");
                                return false;
                            }
                            }
                    }

                    if (SqlWorker.AddStudent(student))
                        return true;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("Fields can't be empty!");
            }
            return false;
        }
    }
}
