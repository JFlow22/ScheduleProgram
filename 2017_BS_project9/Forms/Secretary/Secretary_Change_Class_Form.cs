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
    public partial class Secretary_Change_Class_Form : MetroForm
    {
        private int[] hours = new int[22]; //array for the hours we will change to 
        private int[] CurrentHours = new int[22];//array for the hours we are changing from
        private string Lesson;//indicates the whether we are dealing with a lecture or a practice
        public Secretary_Change_Class_Form()
        {
            InitializeComponent();
        }

        private void Practice_CheckedChanged(object sender, EventArgs e)
        {
            //the function checks if the checkbox that was checked is practice
            //if it does, the function will load the practices info into the listboxes accordingly
            int Count = 0, val = 0;
            if (Lecture.Checked && Practice.Checked)
            {
                Lecture.Checked = false;
            }
            if (!Practice.Checked)
            {
                Lecture_Select.Enabled = false;
                Class_Search.Enabled = false;
                UpdateDB.Visible = false;
                Current_Class.Visible = false;
                Classes.Visible = false;
                Classes.ResetText();
                Classes.Items.Clear();
            }
            else
            {
                ID.ResetText();
                ID.Items.Clear();
                Start_Time.ResetText();
                Start_Time.Items.Clear();
                End_Time.ResetText();
                End_Time.Items.Clear();
                Courses.ResetText();
                Courses.Items.Clear();
                Days.ResetText();
                Days.Items.Clear();
                Lecture_Select.Enabled = true;
                Lecture_Select.Items.Clear();
                Lecture_Select.ResetText();
                Lesson = "Practice";
    
                if (!SqlWorker.CheckForInternetConnection())
                {
                    MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
 
                DataSet TableShow = SqlWorker.GetDataSet("SELECT CourseName , StartTime , EndTime , Day , ID From TeachingExercises");
                val = TableShow.Tables[0].Rows.Count;
                while (val > Count)
                {
                    Lecture_Select.Items.Add(TableShow.Tables[0].Rows[Count]["ID"].ToString());
                    ID.Items.Add(TableShow.Tables[0].Rows[Count]["ID"].ToString());
                    Courses.Items.Add(TableShow.Tables[0].Rows[Count]["CourseName"].ToString());
                    Start_Time.Items.Add(TableShow.Tables[0].Rows[Count]["StartTime"].ToString());
                    End_Time.Items.Add(TableShow.Tables[0].Rows[Count]["EndTime"].ToString());
                    Days.Items.Add(TableShow.Tables[0].Rows[Count]["Day"].ToString());
                    Count++;
                    progressBar1.Value += 100 / val;
                }
                progressBar1.Value = 100;
                MessageBox.Show("Loading completed.", "Load", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                progressBar1.Value = 0;
            }
        }

        private void Lecture_CheckedChanged(object sender, EventArgs e)
        {
            //the function checks if the checkbox that was checked is lecture
            //if it does, the function will load the lectures info into the listboxes accordingly
            int Count = 0, val = 0;
            if (Lecture.Checked && Practice.Checked)
            {
                Practice.Checked = false;
            }
            if (!Lecture.Checked)
            {
                Lecture_Select.Enabled = false;
                Class_Search.Enabled = false;
                UpdateDB.Visible = false;
                Current_Class.Visible = false;
                Classes.Visible = false;
                Classes.ResetText();
                Classes.Items.Clear();
            }
            else
            {
                ID.ResetText();
                ID.Items.Clear();
                Start_Time.ResetText();
                Start_Time.Items.Clear();
                End_Time.ResetText();
                End_Time.Items.Clear();
                Courses.ResetText();
                Courses.Items.Clear();
                Days.ResetText();
                Days.Items.Clear();
                Lecture_Select.Enabled = true;
                Lecture_Select.Items.Clear();
                Lecture_Select.ResetText();
                Lesson = "Lecture";
 
                if (!SqlWorker.CheckForInternetConnection())
                {
                    MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
      
                DataSet TableShow = SqlWorker.GetDataSet("SELECT CourseName , StartTime , Day ,EndTime , ID From Lecture");
                val = TableShow.Tables[0].Rows.Count;
                while (val > Count)
                {
                    Lecture_Select.Items.Add(TableShow.Tables[0].Rows[Count]["ID"].ToString());
                    ID.Items.Add(TableShow.Tables[0].Rows[Count]["ID"].ToString());
                    Courses.Items.Add(TableShow.Tables[0].Rows[Count]["CourseName"].ToString());
                    Start_Time.Items.Add(TableShow.Tables[0].Rows[Count]["StartTime"].ToString());
                    End_Time.Items.Add(TableShow.Tables[0].Rows[Count]["EndTime"].ToString());
                    Days.Items.Add(TableShow.Tables[0].Rows[Count]["Day"].ToString());
                    Count++;
                    progressBar1.Value += 100 / val;
                }
                progressBar1.Value = 100;
                MessageBox.Show("Loading completed.", "Load", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                progressBar1.Value = 0;
            }
        }


        private void Class_Search_Click(object sender, EventArgs e)
        {
            Classes.Items.Clear();
            Classes.ResetText();
            //this function seraches the class according to the user's choise in the combobox of choosing a lecture/practice ID
            label2.Visible = true;
            Classes.Visible = true;
            int Start, End, count = 0, Projector = -1, IsLab = -1, P = -1, L = -1,val2=0 , D=0;
            string Time = "", val = "", Current_C = "";
            int TeacherID = 0;
 
            DataSet dataset, pref;
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
  
            if (Lesson == "Lecture")
            {
                dataset = SqlWorker.GetDataSet("SELECT * From Lecture WHERE ID LIKE'" + Lecture_Select.SelectedItem.ToString() + "'");
                TeacherID = Int32.Parse(dataset.Tables[0].Rows[0]["Lecturer"].ToString());
                D = Int32.Parse(dataset.Tables[0].Rows[0]["Day"].ToString());
                
            }
            else
            {
                dataset = SqlWorker.GetDataSet("SELECT * From TeachingExercises WHERE ID LIKE'" + Lecture_Select.SelectedItem.ToString() + "'");
                TeacherID = Int32.Parse(dataset.Tables[0].Rows[0]["Practitioner"].ToString());
                D = Int32.Parse(dataset.Tables[0].Rows[0]["Day"].ToString());
            }
            
            pref = SqlWorker.GetDataSet("SELECT * From ClassRequest WHERE TeacherID ='" + TeacherID + "'");
            Current_C = dataset.Tables[0].Rows[0]["Class"].ToString();
            Current_Class.Text = Current_C;
            Start = Int32.Parse(dataset.Tables[0].Rows[0]["StartTime"].ToString().Split(':')[0]);
            End = Int32.Parse(dataset.Tables[0].Rows[0]["EndTime"].ToString().Split(':')[0]);
            if (pref.Tables[0].Rows.Count > 0)
            {
                Projector = Int32.Parse(pref.Tables[0].Rows[0]["Projector"].ToString());
                IsLab = Int32.Parse(pref.Tables[0].Rows[0]["Lab"].ToString());
            }
            else
            {
                Projector = 0;
                IsLab = 0;
            }
            for (int i = Start; i < End; i++)
            {
                Time += i;
                if (i != End - 1)
                    Time += ',';
            }
            dataset = SqlWorker.GetDataSet("SELECT Hours , Room , HasProjector, Days , IsLab From Class");
            val2 = dataset.Tables[0].Rows.Count;
            while (dataset.Tables[0].Rows.Count > count)
            {
                val = dataset.Tables[0].Rows[count]["Hours"].ToString();
                P = Int32.Parse(dataset.Tables[0].Rows[count]["HasProjector"].ToString());
                L = Int32.Parse(dataset.Tables[0].Rows[count]["IsLab"].ToString());
                if (val.Contains(Time) && P == Projector && L == IsLab && dataset.Tables[0].Rows[count]["Room"].ToString() != Current_C && D == Int32.Parse(dataset.Tables[0].Rows[count]["Days"].ToString()))
                    if (!((val[0] == '0' && Time == "8") || (val[1] == '0' && Time == "9")))
                    {
                        Classes.Items.Add(dataset.Tables[0].Rows[count]["Room"].ToString());
                    }
                count++;
                progressBar1.Value = 100/val2;
            }
            UpdateDB.Visible = true;
            progressBar1.Value = 100;
            MessageBox.Show("Loading completed.", "Load", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            progressBar1.Value = 0;
            if (Classes.Items.Count == 0 )
            {
                label2.Visible = false;
                Classes.Visible = false;
                UpdateDB.Visible = false;
                MessageBox.Show("No class was found, please try to search again with new data.", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Lecture_Select_SelectedIndexChanged(object sender, EventArgs e)
        { //in this function we will load the array with the hours that we need according to the user's choise
            label2.Visible = false;
            Classes.Visible = false;
            Class_Search.Enabled = true;
            UpdateDB.Visible = false;
            string Hour = "";
     
            DataSet dataset,dataset2;
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (Lesson == "Lecture")
            {
                dataset = SqlWorker.GetDataSet("SELECT Class , Day From Lecture WHERE ID LIKE'" + Lecture_Select.SelectedItem.ToString() + "'");
                dataset2 = SqlWorker.GetDataSet("SELECT Hours From Class WHERE Room LIKE'" + dataset.Tables[0].Rows[0]["Class"].ToString() + "'AND Days LIKE'" + dataset.Tables[0].Rows[0]["Day"].ToString() + "'");
                Hour = dataset2.Tables[0].Rows[0]["Hours"].ToString();
                Convert(CurrentHours, Hour);
            }
            else
            {
                dataset = SqlWorker.GetDataSet("SELECT Class, Day From TeachingExercises WHERE ID LIKE'" + Lecture_Select.SelectedItem.ToString() + "'");
                dataset2 = SqlWorker.GetDataSet("SELECT Hours From Class WHERE Room LIKE'" + dataset.Tables[0].Rows[0]["Class"].ToString() + "'AND Days LIKE'" + dataset.Tables[0].Rows[0]["Day"].ToString() + "'");
                Hour = dataset2.Tables[0].Rows[0]["Hours"].ToString();
                Convert(CurrentHours, Hour);
            }
            Current_Class.Text = dataset.Tables[0].Rows[0]["Class"].ToString();
            Current_Class.Visible = true;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            UpdateClass(Lecture_Select.SelectedItem.ToString(), hours, CurrentHours, Classes.SelectedItem.ToString(),Lesson,Current_Class.Text);
        }

        private void Classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //in this function we will load the arrays with the hours that we need according to the user's choise 
            UpdateDB.Enabled = true;
            string Hour = "";
            DataSet dataset,Les;
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
 
            if (Lesson == "Lecture")
            {
                Les = SqlWorker.GetDataSet("SELECT Day From Lecture WHERE ID LIKE'" + Lecture_Select.SelectedItem.ToString() + "'");
            }
            else
            {
                Les = SqlWorker.GetDataSet("SELECT Day From TeachingExercises WHERE ID LIKE'" + Lecture_Select.SelectedItem.ToString() + "'");
            }
            dataset = SqlWorker.GetDataSet("SELECT Hours From Class WHERE Room LIKE'" + Classes.SelectedItem.ToString() + "'AND Days LIKE'" + Les.Tables[0].Rows[0]["Day"].ToString() + "'");
            Hour = dataset.Tables[0].Rows[0]["Hours"].ToString();
            Convert(hours, Hour);
        }

        public void Convert(int []hours, string Hour)
        {//the function takes the values in the string she gets and inserts them as an int to the array she gets 
            UpdateDB.Enabled = true;
            int count = 0, i = 8, val;
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
                        hours[i] = -1;
                    else
                        hours[i] = val;
                    i++;
                    count++;
                }
                else
                    count++;
            }
        }

        private void Secretary_Change_Class_Form_Load(object sender, EventArgs e)
        {

        }

        public void UpdateClass(string LectureID,int[] Nhours, int[] Chours,string Classes,string Les,string Class2)
        {
            //this function updateds the records in the database according to the user's choise
            string NewHours = "", CurrentHoursStr = "";
            int Start = 0, End = 0, i = 8;

            DataSet dataset, Lec;
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //the Lec variable will get the value according to the choise in the checkbox
            if (Les == "Lecture")
            {
                Lec = SqlWorker.GetDataSet("SELECT StartTime , EndTime , Day From Lecture WHERE ID LIKE'" + LectureID + "'");
            }
            else
            {
                Lec = SqlWorker.GetDataSet("SELECT StartTime , EndTime , Day From TeachingExercises WHERE ID LIKE'" + LectureID + "'");
            }
            Start = Int32.Parse(Lec.Tables[0].Rows[0]["StartTime"].ToString().Split(':')[0]);
            End = Int32.Parse(Lec.Tables[0].Rows[0]["EndTime"].ToString().Split(':')[0]);

            while (i < Nhours.Length)
            {
                if (Nhours[i] != 0 && (Nhours[i] >= Start && Nhours[i] <= End))
                    NewHours += 0;
                else
                    NewHours += hours[i];
                if (i < hours.Length - 1)
                    NewHours += ',';
                i++;
            }
            i = 8;
            while (i < Chours.Length)
            {
                if (i >= Start && i <= End)
                    CurrentHoursStr += i;
                else
                    CurrentHoursStr +=  Nhours[i];
                if (i < CurrentHours.Length - 1)
                    CurrentHoursStr += ',';
                i++;
            }
            //updating the database
            dataset = SqlWorker.GetDataSet("SELECT Hours From Class WHERE Room LIKE'" + Classes + "'AND Days LIKE'" + Lec.Tables[0].Rows[0]["Day"].ToString() + "'");
            dataset = SqlWorker.GetDataSet("UPDATE Class SET Hours='" + NewHours + "' WHERE Room LIKE'" + Classes + "'AND Days LIKE'" + Lec.Tables[0].Rows[0]["Day"].ToString() + "'");

            dataset = SqlWorker.GetDataSet("SELECT Hours From Class WHERE Room LIKE'" + Current_Class.Text + "'AND Days LIKE'" + Lec.Tables[0].Rows[0]["Day"].ToString() + "'");
            dataset = SqlWorker.GetDataSet("UPDATE Class SET Hours='" + CurrentHoursStr + "' WHERE Room LIKE'" + Class2 + "'AND Days LIKE'" + Lec.Tables[0].Rows[0]["Day"].ToString() + "'");
            if (Les == "Lecture")
            {
                dataset = SqlWorker.GetDataSet("UPDATE Lecture SET Class='" + Classes + "' WHERE ID LIKE'" + LectureID + "'");
            }
            else
            {
                dataset = SqlWorker.GetDataSet("UPDATE TeachingExercises SET Class='" + Classes + "' WHERE ID LIKE'" + LectureID + "'");
            }

            MessageBox.Show("Update has succeeded!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
            return;
        }
    }
    
    
}
