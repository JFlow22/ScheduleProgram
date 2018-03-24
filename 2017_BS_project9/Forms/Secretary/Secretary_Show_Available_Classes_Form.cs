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
    public partial class Secretary_Show_Available_Classes_Form : MetroForm
    {
        private int[] hours = new int[22];
        public Secretary_Show_Available_Classes_Form()
        {
            InitializeComponent();
            for (int i = 8; i < hours.Length; i++)
            {
                hours[i] = i;
            }
            Day.Items.Add("Sunday");
            Day.Items.Add("Monday");
            Day.Items.Add("Wednesday");
            Day.Items.Add("Tuesday");
            Day.Items.Add("Thursday");
            Day.Items.Add("Friday");
            for (int i = 8; i < 21; i++)
            {
                StartTime.Items.Add(i + ":00");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            //this function seraches the class according to the user's choise in the combobox of choosing a lecture/practice ID
            label2.Visible = true;
            Classes.Visible = true;
            Classes.Items.Clear();
            Classes.ResetText();
            int Start, End, count = 0, val2 = 0, D = 0;
            string Time = "", val = "";

            DataSet dataset;
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Start = Int32.Parse(StartTime.SelectedItem.ToString().Split(':')[0]);
            End = Int32.Parse(EndTime.SelectedItem.ToString().Split(':')[0]);
            for (int i = Start; i < End; i++)
            {
                Time += i;
                if (i != End - 1)
                    Time += ',';
            }
            D = Int32.Parse(getday(Day.SelectedItem.ToString()));
            dataset = SqlWorker.GetDataSet("SELECT Hours ,Days,Room From Class");        
            val2 = dataset.Tables[0].Rows.Count;
            while (val2 > count)
            {
                val = dataset.Tables[0].Rows[count]["Hours"].ToString();
                if (val.Contains(Time)  &&  D == Int32.Parse(dataset.Tables[0].Rows[count]["Days"].ToString()))
                    if (!((val[0] == '0' && Time == "8") || (val[1] == '0' && Time == "9")))
                        Classes.Items.Add(dataset.Tables[0].Rows[count]["Room"].ToString());
                count++;
            }
            if (Classes.Items.Count == 0)
            {
                MessageBox.Show("No match was found, please try to search again with new data.", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartTime.Enabled = true;
            Classes.Items.Clear();
            Classes.ResetText();
        }

        private void StartTime_SelectedIndexChanged(object sender, EventArgs e)
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
        public string getday(string day)
        {//this function gets a day's name and returns its number accordingly
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

        private void EndTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search.Enabled = true;
        }
    }
}
