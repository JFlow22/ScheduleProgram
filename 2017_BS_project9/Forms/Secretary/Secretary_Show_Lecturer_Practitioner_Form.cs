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
    public partial class Secretary_Show_Lecturer_Practitioner_Form : MetroForm
    {
        private int[] hours = new int[22];
        private string Teacher = null;
        public Secretary_Show_Lecturer_Practitioner_Form()
        {
            InitializeComponent();
            for(int i=8;i<hours.Length;i++)
            {
                hours[i] = i;
            }
            Day.Items.Add("Sunday");
            Day.Items.Add("Monday");
            Day.Items.Add("Wednesday");
            Day.Items.Add("Tuesday");
            Day.Items.Add("Thursday");
            Day.Items.Add("Friday");
        }

        private void LecturerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (LecturerCheck.Checked && PractitionerCheck.Checked)
            {
                PractitionerCheck.Checked = false;
            }
            if (!LecturerCheck.Checked)
            {
                StartTime.Enabled = false;
                EndTime.Enabled = false;
                Search.Enabled = false;
                Day.Enabled = false;
            }
            else
            {
                Day.Enabled = true;
                StartTime.ResetText();
                StartTime.Items.Clear();
                EndTime.ResetText();
                EndTime.Items.Clear();
                IDListBox.ResetText();
                IDListBox.Items.Clear();
                NameListBox.ResetText();
                NameListBox.Items.Clear();
                for (int i = 8; i < 21; i++)
                {
                    StartTime.Items.Add(i + ":00");
                }
                Teacher = "L";
            }
        }

        private void PractitionerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (LecturerCheck.Checked && PractitionerCheck.Checked)
            {
                LecturerCheck.Checked = false;
            }
            if (!PractitionerCheck.Checked)
            {
                StartTime.Enabled = false;
                EndTime.Enabled = false;
                Day.Enabled = false;
                Search.Enabled = false;
            }

            else
            {
                StartTime.ResetText();
                StartTime.Items.Clear();
                EndTime.ResetText();
                EndTime.Items.Clear();
                IDListBox.ResetText();
                IDListBox.Items.Clear();
                NameListBox.ResetText();
                NameListBox.Items.Clear();
                Day.Enabled = true;
                for (int i = 8; i < 21; i++)
                {
                    StartTime.Items.Add(i + ":00");
                }
                Teacher = "P";
            }
        }


        private void Search_Click(object sender, EventArgs e)
        {//here we will search the practitioner/lecturer
            IDListBox.Items.Clear();
            IDListBox.ResetText();
            NameListBox.Items.Clear();
            NameListBox.ResetText();

            string AvailTime = "", Time = "", Teacherid = "", Name = "";
            int  countUsers = 0, Start_h = 0, End_h = 0, CountConstraints=0;
            DataSet dataset1, dataset2 = null;
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Teacher == "P")
            {
                dataset1 = SqlWorker.GetDataSet("SELECT ID,Name From Users WHERE Type LIKE 'Practitioner'");           
                dataset2 = SqlWorker.GetDataSet("SELECT TeacherId,HoursAvail From Constraines_PraLec WHERE Day LIKE'" + Day.SelectedItem.ToString() + "'");
            }
            else
            {
                dataset1 = SqlWorker.GetDataSet("SELECT ID,Name From Users WHERE Type LIKE 'Lecturer'");
                dataset2 = SqlWorker.GetDataSet("SELECT TeacherId,HoursAvail From Constraines_PraLec WHERE Day LIKE'" + Day.SelectedItem.ToString() + "'");
            }
           
            Start_h = Int32.Parse(StartTime.SelectedItem.ToString().Split(':')[0]);
            End_h = Int32.Parse(EndTime.SelectedItem.ToString().Split(':')[0]);
            for (int i = Start_h; i < End_h; i++)
            {
                Time += i;
                if (i != End_h - 1)
                    Time += ',';
            }
            
            
            {
                while (dataset1.Tables[0].Rows.Count > countUsers)
                {
                    while (dataset2.Tables[0].Rows.Count > CountConstraints)
                    {
                        if (dataset1.Tables[0].Rows[countUsers]["ID"].ToString() == dataset2.Tables[0].Rows[CountConstraints]["TeacherId"].ToString())
                        {
                            AvailTime = dataset2.Tables[0].Rows[CountConstraints]["HoursAvail"].ToString();
                            if (AvailTime.Contains(Time))
                            {
                                if (!((AvailTime[0] == '0' && Time == "8") || (AvailTime[1] == '0' && Time == "9")))
                                {
                                    Teacherid = dataset1.Tables[0].Rows[countUsers]["ID"].ToString();
                                    Name = dataset1.Tables[0].Rows[0]["Name"].ToString();
                                    IDListBox.Items.Add(Teacherid);
                                    NameListBox.Items.Add(Name);
                                }
                            }
                        }
                        CountConstraints++;
                    }
                    CountConstraints=0;
                    countUsers++;
                }

            }

            if (IDListBox.Items.Count == 0 && NameListBox.Items.Count == 0)
            {
                
                MessageBox.Show("No teacher was found, please try to search again with new data.", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public string getday(string day)
        {//this function gets a day's name and return its number accordingly
            if (day == "Sunday")
                    return "1";
            if (day == "Monday")
                return "2";
            if (day == "Wednesday")
                return "4";
            if (day == "Tuesday")
                return "3";
            if (day == "Thursday")
                return "5";
            return "6";
        }

        private void StartTime_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string cur_itm = ((ComboBox)sender).SelectedItem.ToString();
            cur_itm = cur_itm.Split(':')[0];
            int cur_h = Int32.Parse(cur_itm);
            EndTime.Enabled = true;
            EndTime.SelectedIndex = -1;
            EndTime.Items.Clear();
            for (int i = (cur_h + 1); i < 22; i++) EndTime.Items.Add(i + ":00");
            Search.Enabled = false;
        }

        private void EndTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search.Enabled = true;
        }

        private void Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartTime.Enabled = true;
        }
        private void Convert(int[] hours, string Hour, bool c)
        {//the function takes the values in the string she gets and inserts them as an int to the array she gets 
            int count = 0, i = 8, val;
            if (c == true)
                i = 0;
            while (Hour.Length > count)
            {
                if (Hour[count] != ',' && count + 1 < Hour.Length && Hour[count + 1] != ',')
                {
                    val = Int32.Parse(Hour[count].ToString() + Hour[count + 1]);
                    if (val == 0)
                        hours[i] = 0;
                    else
                        hours[i] = val;
                    i++;
                    count += 2;
                }
                else if (Hour[count] != ',')
                {
                    val = Hour[count] - '0';
                    if (val == 0)
                        hours[i] = 0;
                    else
                        hours[i] = val;
                    i++;
                    count++;
                }
                else
                    count++;
            }
        }
    }
}
