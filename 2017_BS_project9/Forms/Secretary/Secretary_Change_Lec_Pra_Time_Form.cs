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
    public partial class Secretary_Change_Lec_Pra_Time_Form : MetroForm
    {
        private int[] hours = new int[22];
        private string Lesson="";
        public Secretary_Change_Lec_Pra_Time_Form()
        {
            InitializeComponent();
            Day.Items.Add("Sunday");
            Day.Items.Add("Monday");
            Day.Items.Add("Wednesday");
            Day.Items.Add("Tuesday");
            Day.Items.Add("Thursday");
            Day.Items.Add("Friday");
            for (int i = 8; i < hours.Length; i++)
            {
                hours[i] = i;
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
                Lecture_Select.Enabled = false;
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
                Day.Text = "";
                Teacher_ID.ResetText();
                Teacher_ID.Items.Clear();
                Lecture_Select.Enabled = true;
                Lecture_Select.Items.Clear();
                Lecture_Select.ResetText();
                Search.Enabled = false;
                StartTime.ResetText();
                StartTime.Items.Clear();
                EndTime.ResetText();
                EndTime.Items.Clear();
                Teacher.ResetText();
                Teacher.Items.Clear();
                ClassCombobox.ResetText();
                ClassCombobox.Items.Clear();
                ClassCombobox.Enabled = false;
                Teacher.Enabled = false;
                StartTime.Enabled = false;
                EndTime.Enabled = false;
                Day.Enabled = false;
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
                Day.Text = "";
                Teacher_ID.ResetText();
                Teacher_ID.Items.Clear();
                Lecture_Select.Enabled = true;
                Lecture_Select.Items.Clear();
                Lecture_Select.ResetText();
                Search.Enabled = false;
                StartTime.ResetText();
                StartTime.Items.Clear();
                EndTime.ResetText();
                EndTime.Items.Clear();
                Teacher.ResetText();
                Teacher.Items.Clear();
                ClassCombobox.ResetText();
                ClassCombobox.Items.Clear();
                ClassCombobox.Enabled = false;
                Teacher.Enabled = false;
                StartTime.Enabled = false;
                EndTime.Enabled = false;
                Day.Enabled = false;
                if (StartTime.Items.Count == 0)
                {
                    for (int i = 8; i < 21; i++)
                    {
                        StartTime.Items.Add(i + ":00");
                    }
                }
                Lesson = "Lecture";

                if (!SqlWorker.CheckForInternetConnection())
                {
                    MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
    
                DataSet TableShow = SqlWorker.GetDataSet("SELECT CourseName , StartTime , Day ,EndTime , Lecturer, ID From Lecture");
                val = TableShow.Tables[0].Rows.Count;
                while (val > Count)
                {
                    Lecture_Select.Items.Add(TableShow.Tables[0].Rows[Count]["ID"].ToString());
                    ID.Items.Add(TableShow.Tables[0].Rows[Count]["ID"].ToString());
                    Courses.Items.Add(TableShow.Tables[0].Rows[Count]["CourseName"].ToString());
                    Start_Time.Items.Add(TableShow.Tables[0].Rows[Count]["StartTime"].ToString());
                    End_Time.Items.Add(TableShow.Tables[0].Rows[Count]["EndTime"].ToString());
                    Days.Items.Add(TableShow.Tables[0].Rows[Count]["Day"].ToString());
                    Teacher_ID.Items.Add(TableShow.Tables[0].Rows[Count]["Lecturer"].ToString());
                    Count++;
                }
            }
        }

        private void Practice_CheckedChanged(object sender, EventArgs e)
        {
            //the function checks if the checkbox that was checked is lecture
            //if it does, the function will load the lectures info into the listboxes accordingly
            int Count = 0, val = 0;
            if (Lecture.Checked && Practice.Checked)
            {
                Lecture.Checked = false;
            }
            if (!Practice.Checked)
            {
                Lecture_Select.Enabled = false;
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
                Day.Text = "";
                Teacher_ID.ResetText();
                Teacher_ID.Items.Clear();
                Lecture_Select.Enabled = true;
                Lecture_Select.Items.Clear();
                Lecture_Select.ResetText();
                Search.Enabled = false;
                StartTime.ResetText();
                StartTime.Items.Clear();
                EndTime.ResetText();
                EndTime.Items.Clear();
                Teacher.ResetText();
                Teacher.Items.Clear();
                ClassCombobox.ResetText();
                ClassCombobox.Items.Clear();
                ClassCombobox.Enabled = false;
                Teacher.Enabled = false;
                StartTime.Enabled = false;
                EndTime.Enabled = false;
                Day.Enabled = false;
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
                Day.Text = "";
                Teacher_ID.ResetText();
                Teacher_ID.Items.Clear();
                Lecture_Select.Enabled = true;
                Lecture_Select.Items.Clear();
                Lecture_Select.ResetText();
                Search.Enabled = false;
                StartTime.ResetText();
                StartTime.Items.Clear();
                EndTime.ResetText();
                EndTime.Items.Clear();
                Teacher.ResetText();
                Teacher.Items.Clear();
                ClassCombobox.ResetText();
                ClassCombobox.Items.Clear();
                ClassCombobox.Enabled = false;
                Teacher.Enabled = false;
                StartTime.Enabled = false;
                EndTime.Enabled = false;
                Day.Enabled = false;
                if (StartTime.Items.Count == 0)
                {
                    for (int i = 8; i < 21; i++)
                    {
                        StartTime.Items.Add(i + ":00");
                    }
                }
                Lesson = "Practice";
                if (!SqlWorker.CheckForInternetConnection())
                {
                    MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
   
                DataSet TableShow = SqlWorker.GetDataSet("SELECT CourseName , StartTime , EndTime , Day , ID, Practitioner From TeachingExercises");
                val = TableShow.Tables[0].Rows.Count;
                while (val > Count)
                {
                    Lecture_Select.Items.Add(TableShow.Tables[0].Rows[Count]["ID"].ToString());
                    ID.Items.Add(TableShow.Tables[0].Rows[Count]["ID"].ToString());
                    Courses.Items.Add(TableShow.Tables[0].Rows[Count]["CourseName"].ToString());
                    Start_Time.Items.Add(TableShow.Tables[0].Rows[Count]["StartTime"].ToString());
                    End_Time.Items.Add(TableShow.Tables[0].Rows[Count]["EndTime"].ToString());
                    Days.Items.Add(TableShow.Tables[0].Rows[Count]["Day"].ToString());
                    Teacher_ID.Items.Add(TableShow.Tables[0].Rows[Count]["Practitioner"].ToString());
                    Count++;
                }
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            //here we will search for a suiting class and practitioner/lecturer according to the data we have
            New_Teacher_ID.ResetText();
            New_Teacher_ID.Items.Clear();
            New_Teacher_Name.ResetText();
            New_Teacher_Name.Items.Clear();
            Class.ResetText();
            Class.Items.Clear();
            Teacher.Items.Clear();
            Teacher.ResetText();
            ClassCombobox.ResetText();
            ClassCombobox.Items.Clear();
            Teacher.Enabled = true;
            ClassCombobox.Enabled = true;
            UpdateDB.Enabled = true;

            string AvailTime = "", Time = "",TeacherKind="",Teacherid="",Name="";
            int countClass = 0, countUsers = 0, countConst = 0, Start_h = 0, End_h = 0, IsLab = -1, TeacherID = 0; 
            DataSet dataset1, dataset2 = null, dataset3 = null,Classes=null, ArrLength=null;
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Lesson == "Practice")
            {
                dataset1 = SqlWorker.GetDataSet("SELECT ID,Name From Users WHERE Type LIKE 'Practitioner'");
                dataset3 = SqlWorker.GetDataSet("SELECT Practitioner, StartTime, EndTime, Day,Type From TeachingExercises WHERE ID LIKE'" + Lecture_Select.SelectedItem.ToString() + "'");
                TeacherKind = "Practitioner";
                Teacherid = dataset3.Tables[0].Rows[0]["Practitioner"].ToString();
                dataset2 = SqlWorker.GetDataSet("SELECT HoursAvail,Day From Constraines_PraLec WHERE TeacherId ='" + Teacherid + "'AND Day LIKE'" + Day.SelectedItem.ToString() + "'");
            }
            else
            {
                dataset1 = SqlWorker.GetDataSet("SELECT ID,Name From Users WHERE Type LIKE 'Lecturer'");
                dataset3 = SqlWorker.GetDataSet("SELECT Lecturer, StartTime, EndTime, Day From Lecture WHERE ID LIKE'" + Lecture_Select.SelectedItem.ToString() + "'");
                TeacherKind = "Lecturer";
                Teacherid = dataset3.Tables[0].Rows[0]["Lecturer"].ToString();
                dataset2 = SqlWorker.GetDataSet("SELECT HoursAvail,Day From Constraines_PraLec WHERE TeacherId ='" + Teacherid + "'AND Day LIKE'" + Day.SelectedItem.ToString() + "'");
            }
            Classes= SqlWorker.GetDataSet("SELECT * From Class WHERE Days LIKE'" + getday(Day.SelectedItem.ToString()) + "'");
            Start_h = Int32.Parse(StartTime.SelectedItem.ToString().Split(':')[0]);
            End_h = Int32.Parse(EndTime.SelectedItem.ToString().Split(':')[0]);

            for (int i = Start_h; i < End_h; i++)
            {
                Time += i;
                if (i != End_h - 1)
                    Time += ',';
            }

            Start_h = Int32.Parse(dataset3.Tables[0].Rows[0]["StartTime"].ToString().Split(':')[0]);
            End_h = Int32.Parse(dataset3.Tables[0].Rows[0]["EndTime"].ToString().Split(':')[0]);

            ArrLength = SqlWorker.GetDataSet("SELECT StartingTime, EndingTime From Constraines_PraLec WHERE TeacherId LIKE'" + Teacherid + "'AND Day LIKE'" + Day.SelectedItem.ToString() + "'");
            int Len = Int32.Parse(ArrLength.Tables[0].Rows[0]["EndingTime"].ToString().Split(':')[0]) - Int32.Parse(ArrLength.Tables[0].Rows[0]["StartingTime"].ToString().Split(':')[0]) + 1;
            int[] LPhours = new int[Len];
            int j = Start_h;
            if (dataset3.Tables[0].Rows[0]["Day"].ToString() == Day.SelectedItem.ToString())
            {
                Convert(LPhours, dataset2.Tables[0].Rows[0]["HoursAvail"].ToString(),true);
                for(int i= 0; i< LPhours.Length-1; i++)
                {
                    if (Start_h!= 8 && LPhours[i] >= Start_h-1 && LPhours[i] < End_h)
                    {
                        LPhours[i+1] = j;
                        j++;
                    }
                    else if (Start_h == 8)
                        LPhours[i] = 8;
                }
                for (int i = 0; i < LPhours.Length; i++)
                {
                    AvailTime += LPhours[i];
                    if (i != LPhours.Length-1)
                        AvailTime += ',';
                }
            }
            else
                AvailTime = dataset2.Tables[0].Rows[0]["HoursAvail"].ToString();
            if (AvailTime.Contains(Time))
            {
                if (!((AvailTime[0] == '0' && Time == "8") || (AvailTime[1] == '0' && Time == "9")))
                {
                    while (dataset1.Tables[0].Rows.Count > countUsers)
                    {
                        if (dataset1.Tables[0].Rows[countUsers]["ID"].ToString() == Teacherid)
                            Name = dataset1.Tables[0].Rows[0]["Name"].ToString();
                        countUsers++;
                    }
                    Teacher.Items.Add(Teacherid);
                    New_Teacher_ID.Items.Add(Teacherid);
                    New_Teacher_Name.Items.Add(Name);
                }
            }
            countUsers = 0;
            if (Teacher.Items.Count==0)
            {
                dataset2 = SqlWorker.GetDataSet("SELECT TeacherId,HoursAvail,Day From Constraines_PraLec WHERE Day LIKE'" + Day.SelectedItem.ToString() + "'");
                while (dataset1.Tables[0].Rows.Count > countUsers)
                {
                    while (dataset1.Tables[0].Rows.Count > countConst)
                    {
                        if (dataset1.Tables[0].Rows[countUsers]["ID"].ToString() == dataset2.Tables[0].Rows[countConst]["TeacherId"].ToString())
                        {
                            ArrLength = SqlWorker.GetDataSet("SELECT StartingTime, EndingTime From Constraines_PraLec WHERE TeacherId LIKE'" + Teacherid + "'AND Day LIKE'" + Day.SelectedItem.ToString() + "'");
                            Len = Int32.Parse(ArrLength.Tables[0].Rows[0]["EndingTime"].ToString().Split(':')[0]) - Int32.Parse(ArrLength.Tables[0].Rows[0]["StartingTime"].ToString().Split(':')[0]) + 1;
                            LPhours = new int[Len];
                            if (dataset3.Tables[0].Rows[0]["Day"].ToString() == Day.SelectedItem.ToString())
                            {
                                Convert(LPhours, dataset2.Tables[0].Rows[0]["HoursAvail"].ToString(), true);
                                j = Start_h;
                                for (int i = 0; i < LPhours.Length-1; i++)
                                {
                                    if (Start_h != 8 && LPhours[i] >= Start_h - 1 && LPhours[i] < End_h)
                                    {
                                        LPhours[i+1] = j;
                                        j++;
                                    }
                                    else if (Start_h == 8)
                                        LPhours[i] = 8;
                                }
                                for (int i = 0; i < LPhours.Length; i++)
                                {
                                    AvailTime += LPhours[i];
                                    if (i != LPhours.Length - 1)
                                        AvailTime += ',';
                                }
                            }
                            else
                                AvailTime = dataset2.Tables[0].Rows[0]["HoursAvail"].ToString();
                            if (AvailTime.Contains(Time))
                            {
                                if (!((AvailTime[0] == '0' && Time == "8") || (AvailTime[1] == '0' && Time == "9")))
                                {
                                    Teacher.Items.Add(dataset2.Tables[0].Rows[countConst]["TeacherId"].ToString());
                                    New_Teacher_ID.Items.Add(dataset2.Tables[0].Rows[countConst]["TeacherId"].ToString());
                                    New_Teacher_Name.Items.Add(dataset1.Tables[0].Rows[countConst]["Name"].ToString());
                                }
                            }
                            AvailTime = "";
                        }
                        countConst++;
                    }
                    countUsers++;
                    countConst = 0;
                }

            }

            if (New_Teacher_ID.Items.Count == 0 && New_Teacher_Name.Items.Count == 0)
            {
                UpdateDB.Enabled = false;
                MessageBox.Show("No teacher was found, please try to search again with new data.", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AvailTime = "";
            countClass = 0;    
            
            while (Classes.Tables[0].Rows.Count > countClass)
            {
                if (dataset3.Tables[0].Rows[0]["Day"].ToString() == Day.SelectedItem.ToString())
                {
                    Convert(hours, Classes.Tables[0].Rows[0]["Hours"].ToString(), false);
                    for (int i = Start_h; i < End_h; i++)
                    {
                        hours[i] = i;
                    }
                    for (int i = 0; i < hours.Length; i++)
                    {
                        AvailTime += hours[i];
                        if (i != hours.Length - 1)
                            AvailTime += ',';
                    }
                }
                else
                    AvailTime = Classes.Tables[0].Rows[countClass]["Hours"].ToString();

                if (Lesson == "Practice")
                {
                    IsLab = Int32.Parse(Classes.Tables[0].Rows[countClass]["IsLab"].ToString());
                    if (AvailTime.Contains(Time) && (CheckIfLab(dataset3.Tables[0].Rows[0]["Type"].ToString()) == IsLab))
                    {
                        if (!((AvailTime[0] == '0' && Time == "8") || (AvailTime[1] == '0' && Time == "9")))
                        {
                            ClassCombobox.Items.Add(Classes.Tables[0].Rows[countClass]["Room"].ToString());
                            Class.Items.Add(Classes.Tables[0].Rows[countClass]["Room"].ToString());
                        }
                    }
                }
                else
                {
                    if (AvailTime.Contains(Time))
                    {
                        if (!((AvailTime[0] == '0' && Time == "8") || (AvailTime[1] == '0' && Time == "9")))
                        {
                            ClassCombobox.Items.Add(Classes.Tables[0].Rows[countClass]["Room"].ToString());
                            Class.Items.Add(Classes.Tables[0].Rows[countClass]["Room"].ToString());
                        }
                    }
                }
                AvailTime = "";
                countClass++;
            }

            if (Class.Items.Count == 0 )
            {
                UpdateDB.Enabled = true;
                MessageBox.Show("No class was found, please try to search again with new data.", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

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

        private void StartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cur_itm = ((ComboBox)sender).SelectedItem.ToString();
            cur_itm = cur_itm.Split(':')[0];
            int cur_h = Int32.Parse(cur_itm);
            EndTime.Enabled = true;
            EndTime.SelectedIndex = -1;
            EndTime.Items.Clear();
            for (int i = (cur_h + 1); i < 22; i++) EndTime.Items.Add(i + ":00");
            if (Day.SelectedItem.ToString() != "")
            {
                EndTime.Enabled = true;
            }
            else
            {
                EndTime.Enabled = false;
            }
            if(Search.Enabled==true)
            {
                Search.Enabled =false;
            }

            if (Teacher.Enabled == true)
            {
                Teacher.Enabled = false;
                Teacher.SelectedIndex = -1;
            }

            if (ClassCombobox.Enabled == true)
            {
                ClassCombobox.Enabled = false;
                ClassCombobox.SelectedIndex = -1;
            }

            if (UpdateDB.Enabled == true)
            {
                UpdateDB.Enabled = false;
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            //this function updateds the records in the database according to the user's choise
            int[] Chours = new int[22];
            string Teacherid = "", OldTime="";
            int K = 0;         
            string NewHours = "";
            int Start = 0, End = 0, i = 8,OldStart=0,OldEnd=0;
  
            DataSet dataset, Lec,ArrLength,DayDataset, OldDay,ClassDataset;
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
    
            //the Lec variable will get the value according to the choise in the checkbox
            if (Lesson == "Lecture")
            {
                Lec = SqlWorker.GetDataSet("SELECT AmountOfStudents,CourseName From Lecture WHERE ID LIKE'" + Lecture_Select.SelectedItem.ToString() + "'");
            }
            else
            {
                Lec = SqlWorker.GetDataSet("SELECT AmountOfStudents,CourseName,Type From TeachingExercises WHERE ID LIKE'" + Lecture_Select.SelectedItem.ToString() + "'");
            }
            dataset = SqlWorker.GetDataSet("SELECT Hours From Class WHERE Room LIKE'" + ClassCombobox.SelectedItem.ToString() + "'AND Days LIKE'" + getday(Day.SelectedItem.ToString()) + "'");
            Start = Int32.Parse(StartTime.SelectedItem.ToString().Split(':')[0]);
            End = Int32.Parse(EndTime.SelectedItem.ToString().Split(':')[0]);

            ArrLength = SqlWorker.GetDataSet("SELECT StartingTime, EndingTime From Constraines_PraLec WHERE TeacherId LIKE'" + Teacher.SelectedItem.ToString() + "'AND Day LIKE'" + Day.SelectedItem.ToString() + "'");
            int Len= Int32.Parse(ArrLength.Tables[0].Rows[0]["EndingTime"].ToString().Split(':')[0])-Int32.Parse(ArrLength.Tables[0].Rows[0]["StartingTime"].ToString().Split(':')[0])+1;
            int[] LPhours = new int[Len];
            i = 0;

            //updating the database

            dataset = SqlWorker.GetDataSet("SELECT HoursAvail From Constraines_PraLec WHERE TeacherId LIKE'" + Teacher.SelectedItem.ToString() + "'AND Day LIKE'" + Day.SelectedItem.ToString() + "'");

          
            if (Lesson == "Lecture")
            {
                DayDataset = SqlWorker.GetDataSet("SELECT Lecturer, StartTime, EndTime, Day,Class From Lecture WHERE ID LIKE'" + Lecture_Select.SelectedItem.ToString() + "'");
                dataset = SqlWorker.GetDataSet("UPDATE Lecture SET Day='" + Int32.Parse(getday(Day.SelectedItem.ToString())) + "',StartTime = '" + StartTime.SelectedItem.ToString() + "',EndTime = '" + EndTime.SelectedItem.ToString() + "',Class = '" + ClassCombobox.SelectedItem.ToString() + "',Lecturer = '" + Teacher.SelectedItem.ToString() + "' WHERE ID LIKE'" + Lecture_Select.SelectedItem.ToString() + "'");
                Teacherid = DayDataset.Tables[0].Rows[0]["Lecturer"].ToString();
                OldDay = SqlWorker.GetDataSet("SELECT HoursAvail From Constraines_PraLec WHERE TeacherId LIKE'" + Teacherid + "'AND Day LIKE'" + Reversegetday(DayDataset.Tables[0].Rows[0]["Day"].ToString()) + "'");
                OldStart = Int32.Parse(DayDataset.Tables[0].Rows[0]["StartTime"].ToString().Split(':')[0]);
                OldEnd = Int32.Parse(DayDataset.Tables[0].Rows[0]["EndTime"].ToString().Split(':')[0]);
                string d = OldDay.Tables[0].Rows[0]["HoursAvail"].ToString();
                ArrLength = SqlWorker.GetDataSet("SELECT StartingTime, EndingTime From Constraines_PraLec WHERE TeacherId LIKE'" + Teacher.SelectedItem.ToString() + "'AND Day LIKE'" + Day.SelectedItem.ToString() + "'");
                Len = Int32.Parse(ArrLength.Tables[0].Rows[0]["EndingTime"].ToString().Split(':')[0]) - Int32.Parse(ArrLength.Tables[0].Rows[0]["StartingTime"].ToString().Split(':')[0]) + 1;
                LPhours = new int[Len];
                i = 0;

                if (!(DayDataset.Tables[0].Rows[0]["Day"].ToString() == Day.SelectedItem.ToString() && DayDataset.Tables[0].Rows[0]["StartTime"].ToString()== StartTime.SelectedItem.ToString() && DayDataset.Tables[0].Rows[0]["EndTime"].ToString() == EndTime.SelectedItem.ToString()))
                {
                    Convert(LPhours, OldDay.Tables[0].Rows[0]["HoursAvail"].ToString(), true);
                    K = OldStart;
                    for (int j = 0; j < LPhours.Length-1; j++)
                    {
                        if (OldStart != 8 && LPhours[j] >= OldStart - 1 && LPhours[j] < OldEnd)
                        {
                            LPhours[j+1] = K;
                            K++;
                        }
                        else if (OldStart == 8)
                            LPhours[j] = 8;
                    }
                    for (int j = 0; j < LPhours.Length; j++)
                    {
                        OldTime += LPhours[j];
                        if (j != LPhours.Length - 1)
                            OldTime += ',';
                    }
                }
                dataset = SqlWorker.GetDataSet("UPDATE Constraines_PraLec SET HoursAvail='" + OldTime + "'WHERE TeacherId ='" + Teacherid + "'AND Day LIKE'" + Reversegetday(DayDataset.Tables[0].Rows[0]["Day"].ToString()) + "'");
                dataset = SqlWorker.GetDataSet("SELECT Hours From Class WHERE Room LIKE'" + DayDataset.Tables[0].Rows[0]["Class"].ToString() + "'AND Days LIKE'" + DayDataset.Tables[0].Rows[0]["Day"].ToString() + "'");
                LPhours = new int[22];
                OldTime = "";
                if (!(DayDataset.Tables[0].Rows[0]["Day"].ToString() == Day.SelectedItem.ToString() && DayDataset.Tables[0].Rows[0]["StartTime"].ToString() == StartTime.SelectedItem.ToString() && DayDataset.Tables[0].Rows[0]["EndTime"].ToString() == EndTime.SelectedItem.ToString()))
                {
                    Convert(LPhours, dataset.Tables[0].Rows[0]["Hours"].ToString(), false);
                    K = OldStart;
                    for (int j = 0; j < LPhours.Length-1; j++)
                    {
                        if (OldStart != 8 && LPhours[j] >= OldStart-1 && LPhours[j] < OldEnd)
                        {
                            LPhours[j+1] = K;
                            K++;
                        }
                        else if (OldStart == 8)
                            LPhours[j] = 8;
                    }
                    for (int j = 8; j < LPhours.Length; j++)
                    {
                        OldTime += LPhours[j];
                        if (j != LPhours.Length - 1)
                            OldTime += ',';
                    }
                }
                ClassDataset = SqlWorker.GetDataSet("UPDATE Class SET Hours='" + OldTime + "' WHERE Room LIKE'" + DayDataset.Tables[0].Rows[0]["Class"].ToString() + "'AND Days LIKE'" + DayDataset.Tables[0].Rows[0]["Day"].ToString() + "'");
            }
            else
            {
                DayDataset = SqlWorker.GetDataSet("SELECT Practitioner, StartTime, EndTime, Day,Class From TeachingExercises WHERE ID LIKE'" + Lecture_Select.SelectedItem.ToString() + "'");
                dataset = SqlWorker.GetDataSet("UPDATE TeachingExercises SET Day='" + Int32.Parse(getday(Day.SelectedItem.ToString())) + "',StartTime = '" + StartTime.SelectedItem.ToString() + "',EndTime = '" + EndTime.SelectedItem.ToString() + "',Class = '" + ClassCombobox.SelectedItem.ToString() + "',Practitioner = '" + Teacher.SelectedItem.ToString() + "' WHERE ID LIKE'" + Lecture_Select.SelectedItem.ToString() + "'");
                Teacherid = DayDataset.Tables[0].Rows[0]["Practitioner"].ToString();
                OldDay = SqlWorker.GetDataSet("SELECT HoursAvail From Constraines_PraLec WHERE TeacherId LIKE'" + Teacherid + "'AND Day LIKE'" + Reversegetday(DayDataset.Tables[0].Rows[0]["Day"].ToString()) + "'");
                OldStart = Int32.Parse(DayDataset.Tables[0].Rows[0]["StartTime"].ToString().Split(':')[0]);
                OldEnd = Int32.Parse(DayDataset.Tables[0].Rows[0]["EndTime"].ToString().Split(':')[0]);
                string d = OldDay.Tables[0].Rows[0]["HoursAvail"].ToString();
                ArrLength = SqlWorker.GetDataSet("SELECT StartingTime, EndingTime From Constraines_PraLec WHERE TeacherId LIKE'" + Teacher.SelectedItem.ToString() + "'AND Day LIKE'" + Day.SelectedItem.ToString() + "'");
                Len = Int32.Parse(ArrLength.Tables[0].Rows[0]["EndingTime"].ToString().Split(':')[0]) - Int32.Parse(ArrLength.Tables[0].Rows[0]["StartingTime"].ToString().Split(':')[0]) + 1;
                LPhours = new int[Len];
                i = 0;

                if (!(DayDataset.Tables[0].Rows[0]["Day"].ToString() == Day.SelectedItem.ToString() && DayDataset.Tables[0].Rows[0]["StartTime"].ToString() == StartTime.SelectedItem.ToString() && DayDataset.Tables[0].Rows[0]["EndTime"].ToString() == EndTime.SelectedItem.ToString()))
                {
                    Convert(LPhours, OldDay.Tables[0].Rows[0]["HoursAvail"].ToString(), true);
                    K = OldStart;
                    for (int j = 0; j < LPhours.Length - 1; j++)
                    {
                        if (OldStart != 8 && LPhours[j] >= OldStart - 1 && LPhours[j] < OldEnd)
                        {
                            LPhours[j + 1] = K;
                            K++;
                        }
                        else if (OldStart == 8)
                            LPhours[j] = 8;
                    }
                    for (int j = 0; j < LPhours.Length; j++)
                    {
                        OldTime += LPhours[j];
                        if (j != LPhours.Length - 1)
                            OldTime += ',';
                    }
                }
                dataset = SqlWorker.GetDataSet("UPDATE Constraines_PraLec SET HoursAvail='" + OldTime + "'WHERE TeacherId ='" + Teacherid + "'AND Day LIKE'" + Reversegetday(DayDataset.Tables[0].Rows[0]["Day"].ToString()) + "'");
                dataset = SqlWorker.GetDataSet("SELECT Hours From Class WHERE Room LIKE'" + DayDataset.Tables[0].Rows[0]["Class"].ToString() + "'AND Days LIKE'" + DayDataset.Tables[0].Rows[0]["Day"].ToString() + "'");
                LPhours = new int[22];
                OldTime = "";
                if (!(DayDataset.Tables[0].Rows[0]["Day"].ToString() == Day.SelectedItem.ToString() && DayDataset.Tables[0].Rows[0]["StartTime"].ToString() == StartTime.SelectedItem.ToString() && DayDataset.Tables[0].Rows[0]["EndTime"].ToString() == EndTime.SelectedItem.ToString()))
                {
                    Convert(LPhours, dataset.Tables[0].Rows[0]["Hours"].ToString(), false);
                    K = OldStart;
                    for (int j = 0; j < LPhours.Length - 1; j++)
                    {
                        if (OldStart != 8 && LPhours[j] >= OldStart - 1 && LPhours[j] < OldEnd)
                        {
                            LPhours[j + 1] = K;
                            K++;
                        }
                        else if (OldStart == 8)
                            LPhours[j] = 8;
                    }
                    for (int j = 8; j < LPhours.Length; j++)
                    {
                        OldTime += LPhours[j];
                        if (j != LPhours.Length - 1)
                            OldTime += ',';
                    }
                }
                ClassDataset = SqlWorker.GetDataSet("UPDATE Class SET Hours='" + OldTime + "' WHERE Room LIKE'" + DayDataset.Tables[0].Rows[0]["Class"].ToString() + "'AND Days LIKE'" + DayDataset.Tables[0].Rows[0]["Day"].ToString() + "'");
            }
            ArrLength = SqlWorker.GetDataSet("SELECT StartingTime, EndingTime From Constraines_PraLec WHERE TeacherId LIKE'" + Teacher.SelectedItem.ToString() + "'AND Day LIKE'" + Day.SelectedItem.ToString() + "'");
            Len = Int32.Parse(ArrLength.Tables[0].Rows[0]["EndingTime"].ToString().Split(':')[0]) - Int32.Parse(ArrLength.Tables[0].Rows[0]["StartingTime"].ToString().Split(':')[0]) + 1;
            LPhours = new int[Len];
            i = 0;
            dataset = SqlWorker.GetDataSet("SELECT HoursAvail From Constraines_PraLec WHERE TeacherId LIKE'" + Teacher.SelectedItem.ToString() + "'AND Day LIKE'" + Day.SelectedItem.ToString() + "'");
            Convert(LPhours, dataset.Tables[0].Rows[0]["HoursAvail"].ToString(), true);
            NewHours = "";
            while (i < LPhours.Length)
            {
                if (LPhours[i] != 0 && (LPhours[i] >= Start && LPhours[i] < End))
                    NewHours += 0;
                else
                    NewHours += LPhours[i];
                if (i < LPhours.Length - 1)
                    NewHours += ',';
                i++;
            }
            dataset = SqlWorker.GetDataSet("UPDATE Constraines_PraLec SET HoursAvail='" + NewHours + "' WHERE TeacherId LIKE'" + Teacher.SelectedItem.ToString() + "'AND Day LIKE'" + Day.SelectedItem.ToString() + "'");
            dataset = SqlWorker.GetDataSet("SELECT Hours From Class WHERE Room LIKE'" + ClassCombobox.SelectedItem.ToString() + "'AND Days LIKE'" + getday(Day.SelectedItem.ToString()) + "'");
            Convert(Chours, dataset.Tables[0].Rows[0]["Hours"].ToString(), false);
            Start = Int32.Parse(StartTime.SelectedItem.ToString().Split(':')[0]);
            End = Int32.Parse(EndTime.SelectedItem.ToString().Split(':')[0]);
            while (i < Chours.Length)
            {
                if (Chours[i] != 0 && (Chours[i] >= Start && Chours[i] < End))
                    NewHours += 0;
                else
                    NewHours += Chours[i];
                if (i < hours.Length - 1)
                    NewHours += ',';
                i++;
            }
            dataset = SqlWorker.GetDataSet("UPDATE Class SET Hours='" + NewHours + "' WHERE Room LIKE'" + ClassCombobox.SelectedItem.ToString() + "'AND Days LIKE'" + getday(Day.SelectedItem.ToString()) + "'");
            MessageBox.Show("Update has succeeded!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
            return;
        }

        private void Convert(int[] hours, string Hour,bool c)
        {//the function takes the values in the string she gets and inserts them as an int to the array she gets 
            UpdateDB.Enabled = true;
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

        private void Secretary_Change_Lec_Pra_Time_Form_Load(object sender, EventArgs e)
        {
            for (int i = 8; i < 21; i++)
            {
                StartTime.Items.Add(i + ":00");
            }
        }

        private void Lecture_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lecture_Select.SelectedItem.ToString() != "")
            {
                Day.Enabled = true;

            }
            else
            {
                Day.Enabled = false;
            }

            if (EndTime.Enabled == true)
            {
                EndTime.SelectedIndex = -1;
            }

            if (Search.Enabled == true)
            {
                Search.Enabled = false;
            }

            if (Teacher.Enabled == true)
            {
                Teacher.Enabled = false;
                Teacher.SelectedIndex = -1;
            }

            if (ClassCombobox.Enabled == true)
            {
                ClassCombobox.Enabled = false;
                ClassCombobox.SelectedIndex = -1;
            }

            if (UpdateDB.Enabled == true)
            {
                UpdateDB.Enabled = false;
            }


        }

        private void Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Day.SelectedItem.ToString() != "")
            {
                StartTime.Enabled = true;
            }
            else
            {
                StartTime.Enabled = false;
            }

            if (EndTime.Enabled == true)
            {
                EndTime.SelectedIndex = -1;
            }

            if (Search.Enabled == true)
            {
                Search.Enabled = false;
            }

            if (Teacher.Enabled == true)
            {
                Teacher.Enabled = false;
            }

            if (ClassCombobox.Enabled == true)
            {
                ClassCombobox.Enabled = false;
            }

            if (UpdateDB.Enabled == true)
            {
                UpdateDB.Enabled = false;
            }




        }

        private void EndTime_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (Search.Enabled == true)
            {
                Search.Enabled = false;
            }

            if (Teacher.Enabled == true)
            {
                Teacher.Enabled = false;
                Teacher.SelectedIndex = -1;
            }

            if (ClassCombobox.Enabled == true)
            {
                ClassCombobox.Enabled = false;
                ClassCombobox.SelectedIndex = -1;
            }

            if (UpdateDB.Enabled == true)
            {
                UpdateDB.Enabled = false;
            }
            Search.Enabled = true;

        }
        
        public int CheckIfLab(string l)
        {
            if (l == "Lab")
                return 1;
            return 0;
        }

        public string Reversegetday(string day)
        {//this function gets a day's number and returns his name
            if (day == "1")
                return "Sunday";
            if (day == "2")
                return "Monday";
            if (day == "4")
                return "Wednesday";
            if (day == "3")
                return "Tuesday";
            if (day == "5")
                return "Thursday";
            return "6";
        }
    }
}
