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

namespace _2017_BS_project9.Forms
{
    public partial class Adding_User_Form : MetroForm
    {
        private string[] Days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

        public Adding_User_Form()
        {
            InitializeComponent();
        }

        private void Adding_Click(object sender, EventArgs e)
        {

            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //checking if the id contains only digits
            if (!IsDigits(this.id_input.Text))
            {
                MessageBox.Show("Make sure that your id contains only digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddPractitioner_Form_Load(sender, e);
                return;
            }
            //chcking if the name contains only characters
            if (!IsChar(this.name_input.Text))
            {
                MessageBox.Show("Make sure that your name contains only charecters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddPractitioner_Form_Load(sender, e);
                return;
            }
            if (this.id_input.Text == "" || this.name_input.Text == "" || this.pwd_input.Text == "" || this.type_input.Text == "" || startTime_combo.SelectedIndex == -1 || endTime_combo.SelectedIndex == -1 || day_combo.SelectedIndex == -1)
            {
                MessageBox.Show("One of the values is empty, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddPractitioner_Form_Load(sender, e);
                return;
            }

            DataSet dataset = SqlWorker.GetDataSet("SELECT * From Users WHERE id='" + this.id_input.Text + "'");
            if (dataset.Tables[0].Rows.Count > 0)
                MessageBox.Show("User ID is already exist! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // Adding the user to the DB
                bool flag = addUser(id_input.Text, pwd_input.Text, name_input.Text, type_input.Text, startTime_combo.SelectedItem.ToString(), endTime_combo.SelectedItem.ToString(), day_combo.SelectedItem.ToString());
                if (flag) MessageBox.Show("Adding has succeeded!", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                AddPractitioner_Form_Load(sender, e);
            }
        }

        // A function for adding the user to the DB
        public bool addUser(string ID, string Password, string Name, string Type, string startTime, string endTime, string day)
        {
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            int dayInWeek = 0;

            for (int i = 0; i < Days.Length; i++)
            {
                if (Days[i] == day) dayInWeek = i + 1;
            }

            if (Int32.Parse(startTime.Substring(0, startTime.LastIndexOf(":"))) >= Int32.Parse(endTime.Substring(0, endTime.LastIndexOf(":"))))
            {
                MessageBox.Show("The Hours are incorrect! Please try again!.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string Hours = dayInWeek + "," + startTime.Substring(0, startTime.LastIndexOf(":")) + "," + endTime.Substring(0, endTime.LastIndexOf(":"));
            string sqlstring = "INSERT INTO Users(ID,PWD,Name,Type,AccHours) VALUES('" + ID + "','" + Password + "','" + Name + "','" + Type + "','" + Hours + "')";
            DataSet dataset = SqlWorker.GetDataSet(sqlstring);
            return true;
        }

        //function for checking if a string contains only digits
        bool IsDigits(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        //function for checking if a string contains only characters
        bool IsChar(string str)
        {
            int a = 0;
            foreach (char c in str)
            {
                if ((c >= 'A' && c <= 'z' && !(c > 'Z' && c < 'a')) || c == ' ')
                {
                    a++;
                }
            }
            return (a == str.Length);
        }

        private void AddPractitioner_Form_Load(object sender, EventArgs e)
        {
            id_input.Text = "";
            name_input.Text = "";
            pwd_input.Text = "";
            type_input.SelectedIndex = -1;
            startTime_combo.SelectedIndex = -1;
            endTime_combo.SelectedIndex = -1;
            day_combo.SelectedIndex = -1;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
