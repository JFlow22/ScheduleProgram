using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace _2017_BS_project9.Forms
{
    public partial class Constraines_Form : MetroForm
    {

        private User Teacher;

        public Constraines_Form()
        { //here we will initialize the comboboxes  with the hours possible

            InitializeComponent();
                       
            if (Globals._session is Lecturer) Teacher = (Lecturer)Globals._session;
            if (Globals._session is Practitioner) Teacher = (Practitioner)Globals._session;


            for (int i = 8; i < 22; i++)
            {
                Day1_StartTime.Items.Add(i + ":00");
                Day1_EndTime.Items.Add(i + ":00");
            }

            for (int i = 8; i < 22; i++)
            {
                Day2_StartTime.Items.Add(i + ":00");
                Day2_EndTime.Items.Add(i + ":00");
            }

            for (int i = 8; i < 22; i++)
            {
                Day3_StartTime.Items.Add(i + ":00");
                Day3_EndTime.Items.Add(i + ":00");
            }

            for (int i = 8; i < 22; i++)
            {
                Day4_StartTime.Items.Add(i + ":00");
                Day4_EndTime.Items.Add(i + ":00");
            }

            for (int i = 8; i < 22; i++)
            {
                Day5_StartTime.Items.Add(i + ":00");
                Day5_EndTime.Items.Add(i + ":00");
            }

            for (int i = 8; i < 22; i++)
            {
                Day6_StartTime.Items.Add(i + ":00");
                Day6_EndTime.Items.Add(i + ":00");
            }
        }

        private void Insert_constraines_Click(object sender, EventArgs e)
        {
            //in this function we will insert the constraints the lecturer/practitioner checked to the system
            string HoursAvail = "";

            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataSet dataset;

            try
            {

                if (Day1.Checked)
                {
                    for (int i = Int32.Parse(Day1_StartTime.SelectedItem.ToString().Substring(0, Day1_StartTime.SelectedItem.ToString().LastIndexOf(":"))); i < Int32.Parse(Day1_EndTime.SelectedItem.ToString().Substring(0, Day1_EndTime.SelectedItem.ToString().LastIndexOf(":"))) + 1; i++)
                    {
                        HoursAvail += (i + ",");
                    }
                    HoursAvail = HoursAvail.Substring(0, HoursAvail.Length - 1);
                    dataset = SqlWorker.GetDataSet("INSERT INTO Constraines_PraLec(TeacherId,Day,StartingTime,EndingTime,HoursAvail) VALUES('" + Teacher.ID.ToString() + "','Sunday','" + Day1_StartTime.SelectedItem.ToString() + "','" + Day1_EndTime.SelectedItem.ToString() + "','" + HoursAvail + "')");
                }

                HoursAvail = "";
                if (Day2.Checked)
                {
                    for (int i = Int32.Parse(Day2_StartTime.SelectedItem.ToString().Substring(0, Day2_StartTime.SelectedItem.ToString().LastIndexOf(":"))); i < Int32.Parse(Day2_EndTime.SelectedItem.ToString().Substring(0, Day2_EndTime.SelectedItem.ToString().LastIndexOf(":"))) + 1; i++)
                    {
                        HoursAvail += (i + ",");
                    }
                    HoursAvail = HoursAvail.Substring(0, HoursAvail.Length-1);
                    dataset = SqlWorker.GetDataSet("INSERT INTO Constraines_PraLec(TeacherId,Day,StartingTime,EndingTime,HoursAvail) VALUES('" + Teacher.ID.ToString() + "','Monday','" + Day2_StartTime.SelectedItem.ToString() + "','" + Day2_EndTime.SelectedItem.ToString() + "','" + HoursAvail + "')");
                }

                HoursAvail = "";
                if (Day3.Checked)
                {
                    for (int i = Int32.Parse(Day3_StartTime.SelectedItem.ToString().Substring(0, Day3_StartTime.SelectedItem.ToString().LastIndexOf(":"))); i < Int32.Parse(Day3_EndTime.SelectedItem.ToString().Substring(0, Day3_EndTime.SelectedItem.ToString().LastIndexOf(":"))) + 1; i++)
                    {
                        HoursAvail += (i + ",");
                    }
                    HoursAvail = HoursAvail.Substring(0, HoursAvail.Length - 1);
                    dataset = SqlWorker.GetDataSet("INSERT INTO Constraines_PraLec(TeacherId,Day,StartingTime,EndingTime,HoursAvail) VALUES('" + Teacher.ID.ToString() + "','Tuesday','" + Day3_StartTime.SelectedItem.ToString() + "','" + Day3_EndTime.SelectedItem.ToString() + "','" + HoursAvail + "')");
                }

                HoursAvail = "";
                if (Day4.Checked)
                {
                    for (int i = Int32.Parse(Day4_StartTime.SelectedItem.ToString().Substring(0, Day4_StartTime.SelectedItem.ToString().LastIndexOf(":"))); i < Int32.Parse(Day4_EndTime.SelectedItem.ToString().Substring(0, Day4_EndTime.SelectedItem.ToString().LastIndexOf(":"))) + 1; i++)
                    {
                        HoursAvail += (i + ",");
                    }
                    HoursAvail = HoursAvail.Substring(0, HoursAvail.Length - 1);
                    dataset = SqlWorker.GetDataSet("INSERT INTO Constraines_PraLec(TeacherId,Day,StartingTime,EndingTime,HoursAvail) VALUES('" + Teacher.ID.ToString() + "','Wednesday','" + Day4_StartTime.SelectedItem.ToString() + "','" + Day4_EndTime.SelectedItem.ToString() + "','" + HoursAvail + "')");
                }

                HoursAvail = "";
                if (Day5.Checked)
                {
                    for (int i = Int32.Parse(Day5_StartTime.SelectedItem.ToString().Substring(0, Day5_StartTime.SelectedItem.ToString().LastIndexOf(":"))); i < Int32.Parse(Day5_EndTime.SelectedItem.ToString().Substring(0, Day5_EndTime.SelectedItem.ToString().LastIndexOf(":"))) + 1; i++)
                    {
                        HoursAvail += (i + ",");
                    }
                    HoursAvail = HoursAvail.Substring(0, HoursAvail.Length - 1);
                    dataset = SqlWorker.GetDataSet("INSERT INTO Constraines_PraLec(TeacherId,Day,StartingTime,EndingTime,HoursAvail) VALUES('" + Teacher.ID.ToString() + "','Thursday','" + Day5_StartTime.SelectedItem.ToString() + "','" + Day5_EndTime.SelectedItem.ToString() + "','" + HoursAvail + "')");
                }

                HoursAvail = "";
                if (Day6.Checked)
                {
                    for (int i = Int32.Parse(Day6_StartTime.SelectedItem.ToString().Substring(0, Day6_StartTime.SelectedItem.ToString().LastIndexOf(":"))); i < Int32.Parse(Day6_EndTime.SelectedItem.ToString().Substring(0, Day6_EndTime.SelectedItem.ToString().LastIndexOf(":"))) + 1; i++)
                    {
                        HoursAvail += (i + ",");
                    }
                    HoursAvail = HoursAvail.Substring(0, HoursAvail.Length - 1);
                    dataset = SqlWorker.GetDataSet("INSERT INTO Constraines_PraLec(TeacherId,Day,StartingTime,EndingTime,HoursAvail) VALUES('" + Teacher.ID.ToString() + "','Friday','" + Day6_StartTime.SelectedItem.ToString() + "','" + Day6_EndTime.SelectedItem.ToString() + "','" + HoursAvail + "')");
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Invalid input.\nAll fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (SqlException)
            {
                MessageBox.Show("There is already a record with this ID and day in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Adding has succeeded!", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
            this.Close();

            return;
           
        }
        //in the following functions we are enabaling or disabeling the comboboxes of start time and end time 
        private void Day1_CheckedChanged(object sender, EventArgs e)
        {
            if (Day1.Checked == true)
            {
                Day1_StartTime.Enabled = true;
                
            }
            else
            {
                Day1_StartTime.Enabled = false;
                Day1_EndTime.Enabled = false;
            }
        }

        private void Day2_CheckedChanged(object sender, EventArgs e)
        {
            if (Day2.Checked == true)
            {
                Day2_StartTime.Enabled = true;
                
            }
            else
            {
                Day2_StartTime.Enabled = false;
                Day2_EndTime.Enabled = false;
            }
        }

        private void Day3_CheckedChanged(object sender, EventArgs e)
        {
            if (Day3.Checked == true)
            {
                Day3_StartTime.Enabled = true;
                
            }
            else
            {
                Day3_StartTime.Enabled = false;
                Day3_EndTime.Enabled = false;
            }
        }

        private void Day4_CheckedChanged(object sender, EventArgs e)
        {
            if (Day4.Checked == true)
            {
                Day4_StartTime.Enabled = true;
                
            }
            else
            {
                Day4_StartTime.Enabled = false;
                Day4_EndTime.Enabled = false;
            }
        }

        private void Day5_CheckedChanged(object sender, EventArgs e)
        {
            if (Day5.Checked == true)
            {
                Day5_StartTime.Enabled = true;
                
            }
            else
            {
                Day5_StartTime.Enabled = false;
                Day5_EndTime.Enabled = false;
            }
        }

        private void Day6_CheckedChanged(object sender, EventArgs e)
        {
            if (Day6.Checked == true)
            {
                Day6_StartTime.Enabled = true;
                
            }
            else
            {
                Day6_StartTime.Enabled = false;
                Day6_EndTime.Enabled = false;
            }
        }

        private void Practitioner_Constraines_Form_Load(object sender, EventArgs e)
        {
            //in the formload we will change the label of the ID according to the user that is connected 
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataSet dataset;
            string Id="";
            dataset = SqlWorker.GetDataSet("SELECT * From Users WHERE id='" + this.Teacher.ID.ToString() + "'");
            Id = dataset.Tables[0].Rows[0]["id"].ToString();
           

            ID.Text = Id;
            if(Teacher is Practitioner) Label1.Text = "Practitioner ID:";
            else Label1.Text = "Lecturer ID:";
            
        }

        //in the following functions we will limit the ending time comboboxes according to the selected item of the start time combobox
        private void Day1_StartTime_SelectedIndexChanged(object sender, EventArgs e){
            string cur_itm = ((ComboBox)sender).SelectedItem.ToString();
            cur_itm = cur_itm.Split(':')[0];
            int cur_h = Int32.Parse(cur_itm);
            Day1_EndTime.Enabled = true;
            Day1_EndTime.SelectedIndex = -1;
            Day1_EndTime.Items.Clear();
            for(int i = (cur_h + 1); i < 22; i++) Day1_EndTime.Items.Add(i + ":00");
        }

        private void Day2_StartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cur_itm = ((ComboBox)sender).SelectedItem.ToString();
            cur_itm = cur_itm.Split(':')[0];
            int cur_h = Int32.Parse(cur_itm);
            Day2_EndTime.Enabled = true;
            Day2_EndTime.SelectedIndex = -1;
            Day2_EndTime.Items.Clear();
            for (int i = (cur_h + 1); i < 22; i++) Day2_EndTime.Items.Add(i + ":00");
        }

        private void Day3_StartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cur_itm = ((ComboBox)sender).SelectedItem.ToString();
            cur_itm = cur_itm.Split(':')[0];
            int cur_h = Int32.Parse(cur_itm);
            Day3_EndTime.Enabled = true;
            Day3_EndTime.SelectedIndex = -1;
            Day3_EndTime.Items.Clear();
            for (int i = (cur_h + 1); i < 22; i++) Day3_EndTime.Items.Add(i + ":00");
        }

        private void Day4_StartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cur_itm = ((ComboBox)sender).SelectedItem.ToString();
            cur_itm = cur_itm.Split(':')[0];
            int cur_h = Int32.Parse(cur_itm);
            Day4_EndTime.Enabled = true;
            Day4_EndTime.SelectedIndex = -1;
            Day4_EndTime.Items.Clear();
            for (int i = (cur_h + 1); i < 22; i++) Day4_EndTime.Items.Add(i + ":00");
        }

        private void Day5_StartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cur_itm = ((ComboBox)sender).SelectedItem.ToString();
            cur_itm = cur_itm.Split(':')[0];
            int cur_h = Int32.Parse(cur_itm);
            Day5_EndTime.Enabled = true;
            Day5_EndTime.SelectedIndex = -1;
            Day5_EndTime.Items.Clear();
            for (int i = (cur_h + 1); i < 22; i++) Day5_EndTime.Items.Add(i + ":00");
        }

        private void Day6_StartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cur_itm = ((ComboBox)sender).SelectedItem.ToString();
            cur_itm = cur_itm.Split(':')[0];
            int cur_h = Int32.Parse(cur_itm);
            Day6_EndTime.Enabled = true;
            Day6_EndTime.SelectedIndex = -1;
            Day6_EndTime.Items.Clear();
            for (int i = (cur_h + 1); i < 22; i++) Day6_EndTime.Items.Add(i + ":00");
        }

    }

}
