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
    public partial class Adding_PracticeLab_Form : MetroForm
    {
        // The days in the week
        private string[] Days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        private int PractitionerID;
        private DataSet Course;


        public Adding_PracticeLab_Form()
        {
            InitializeComponent();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Adding_PracticeLab_Form_Load(object sender, EventArgs e)
        {
            int count = 0;
            string courseName = "";

  
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataSet dataset;

            // Putting the list of the courses in the comboBox
            dataset = SqlWorker.GetDataSet("SELECT * From Courses");
            while (dataset.Tables[0].Rows.Count > count)
            {
                courseName = dataset.Tables[0].Rows[count]["CourseName"].ToString();
                CourseNames_combo.Items.Add(courseName);
                count++;
            }
        }

        private void CourseNames_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Adding.Enabled = false;
            DayTimeLab_combo.Items.Clear();
            DayTimePractice_combo.Items.Clear();

            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Filling all the information to the secretary about the course like practice duration, etc.
            Course = SqlWorker.GetDataSet("SELECT * From Courses WHERE CourseName='" + CourseNames_combo.SelectedItem.ToString() + "'");

            PractitionerID = Int32.Parse(Course.Tables[0].Rows[0]["Practitioner"].ToString());

            DataSet data = SqlWorker.GetDataSet("SELECT * From Users WHERE ID=" + PractitionerID);
            PractitionerName_Label.Text = data.Tables[0].Rows[0]["Name"].ToString();
            PractitionerName_Label.Visible = true;

            if (DBNull.Value.Equals(Course.Tables[0].Rows[0]["LabDuration"]))
            {
                LabDuration_label.Text = "No Lab Exist.";
                DayTimeLab_label.Visible = false;
                DayTimeLab_combo.Visible = false;
            }
            else
            {
                LabDuration_label.Text = Course.Tables[0].Rows[0]["LabDuration"].ToString();
                DayTimeLab_label.Visible = true;
                DayTimeLab_combo.Visible = true;

            }
            LabDuration_label.Visible = true;

            if (DBNull.Value.Equals(Course.Tables[0].Rows[0]["PracticeDuration"]))
            {
                PracticeDuration_Label.Text = "No Practice Exist.";
                label6.Visible = false;
                DayTimePractice_combo.Visible = false;
            }
            else
            {
                PracticeDuration_Label.Text = Course.Tables[0].Rows[0]["PracticeDuration"].ToString();
                label6.Visible = true;
                DayTimePractice_combo.Visible = true;
            }
            PracticeDuration_Label.Visible = true;

            data = SqlWorker.GetDataSet("SELECT * From Constraines_PraLec WHERE TeacherID=" + PractitionerID);
            string[] day_time_array = new string[data.Tables[0].Rows.Count];

            // Checking for constraints of the lecturer.
            // If there are no constraints, a lecture cannot be scheduled
            if (data.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No constrains where found for the practitioner!\nPlease ask the practitioner to insert his constrains.", "Error"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < day_time_array.Length; i++)
            {
                day_time_array[i] = data.Tables[0].Rows[i]["Day"].ToString() + " | " + data.Tables[0].Rows[i]["StartingTime"].ToString() + " - " + data.Tables[0].Rows[i]["EndingTime"].ToString();
                DayTimeLab_combo.Items.Add(day_time_array[i]);
                DayTimePractice_combo.Items.Add(day_time_array[i]);
            }


        }

        private void DayTimeLab_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DayTimeLab_combo.SelectedIndex != -1 || DayTimePractice_combo.SelectedIndex != -1)
            {
                Adding.Enabled = true;
            }
            else
            {
                Adding.Enabled = false;
            }
        }

        private void schedulePractice(string type)
        {

            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Selecting the class request for the practitioner
            DataSet data = SqlWorker.GetDataSet("SELECT * From ClassRequest WHERE TeacherID=" + PractitionerID + " AND CourseName='" + CourseNames_combo.SelectedItem.ToString() + "'");
            bool needProj = false, needLab = false;
            int day = 0;

            string str = "";

            if (type == "Lab")
            {
                str = (DayTimeLab_combo.SelectedItem.ToString()).Substring(0, DayTimeLab_combo.SelectedItem.ToString().LastIndexOf("|") - 1);
            }
            else
            {
                str = (DayTimePractice_combo.SelectedItem.ToString()).Substring(0, DayTimePractice_combo.SelectedItem.ToString().LastIndexOf("|") - 1);
            }

            for (int i = 0; i < Days.Length; i++)
            {
                if (Days[i] == str)
                {
                    day = i;
                }
            }
            day++;

            // If there is no class that stands with the request, the system will search for all the class 
            if (data.Tables[0].Rows.Count == 0)
            {
                data = SqlWorker.GetDataSet("SELECT * From Class WHERE Days ='" + day + "'");
            }
            else
            {
                if (type == "Lab")
                {
                    needLab = true;
                }

                if (data.Tables[0].Rows[0]["Projector"].ToString() == "1")
                {
                    needProj = true;
                }

                string sql_string = "";
                if (needProj && needLab)
                {
                    sql_string = "SELECT * From Class WHERE HasProjector='1' AND IsLab = '1'";
                }

                if (needProj && !needLab)
                {
                    sql_string = "SELECT * From Class WHERE HasProjector = '1' AND IsLab = '0'";
                }

                if (!needProj && needLab)
                {
                    sql_string = "SELECT * From Class WHERE HasProjector = '0' AND IsLab = '1'";
                }

                if (!needProj && !needLab)
                {
                    sql_string = "SELECT * From Class WHERE HasProjector = '0' AND IsLab = '0'";
                }

                data = SqlWorker.GetDataSet(sql_string + " AND Days='" + day + "'");

                if (data.Tables[0].Rows.Count == 0)
                {
                    data = SqlWorker.GetDataSet("SELECT * From Class WHERE Days ='" + day + "'");
                }
            }
            // Checking the practitioner's constraints
            DataSet PractitionerConstraines = SqlWorker.GetDataSet("SELECT * From Constraines_PraLec WHERE TeacherId=" + Course.Tables[0].Rows[0]["Practitioner"].ToString() + " AND Day='" + Days[day - 1] + "'");

            if (data.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No class available in " + Days[day - 1] + "!", "Error"
            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            char[] delimiterChars = { ',' };
            string[] HoursPractitioner = PractitionerConstraines.Tables[0].Rows[0]["HoursAvail"].ToString().Split(delimiterChars);
            string[] HoursClass = null;

            string startTime = "";
            int classNumInData = 0;

            string forDB = "";

            bool matchFound = false;
            bool Break = false;

            // This for loop will run on all the class
            for (int m = 0; m < data.Tables[0].Rows.Count; m++)
            {
                Break = false;
                matchFound = false;
                HoursClass = data.Tables[0].Rows[m]["Hours"].ToString().Split(delimiterChars);

                // This for loop will run on all the availabe hours of the practitioner that day
                for (int i = 0; i < HoursPractitioner.Length; i++)
                {
                    // This for loop will run on all the availabe hours of the class that day
                    for (int j = 0; j < HoursClass.Length; j++)
                    {
                        if (HoursPractitioner[i] == HoursClass[j] && HoursPractitioner[i] != "0" && HoursClass[j] != "0")
                        {
                            forDB = type + "Duration";
                            // This for will check if the class and the practitioner are available for the practice/lab time
                            for (int k = 0; k < Int32.Parse(Course.Tables[0].Rows[0][forDB].ToString()); k++)
                            {
                                if (HoursPractitioner.Length <= (i + k) || HoursClass.Length <= (j + k))
                                {
                                    Break = true;
                                    break;
                                }
                                else
                                {
                                    if (HoursPractitioner[i + k] != HoursClass[j + k] || HoursPractitioner[i + k] == "0" || HoursClass[j + k] == "0")
                                    {
                                        Break = true;
                                        break;
                                    }
                                }
                            } // end for (k)

                            if (!Break)
                            {
                                classNumInData = m;
                                startTime = HoursPractitioner[i];
                                matchFound = true;
                                break;
                            }
                        }
                    } // end for (j)

                    if (matchFound)
                    {
                        break;
                    }
                } // end for (i)

                if (matchFound)
                {
                    break;
                }
            } // end for (m)

            // When the match is found
            if (matchFound)
            {
                DataSet searchLectures = SqlWorker.GetDataSet("SELECT * From Lecture WHERE CourseName LIKE '" + Course.Tables[0].Rows[0]["CourseName"].ToString() + "'");

                // Checking if the practice/lab was scheduled after the lecture
                // If the practice/lab is before the lecture, system will search for another time to schedule the practice/lab
                // This for will run on all the lectures of the course
                for (int i = 0; i < searchLectures.Tables[0].Rows.Count; i++)
                {
                    if (Int32.Parse(searchLectures.Tables[0].Rows[i]["Day"].ToString()) > day)
                    {
                        MessageBox.Show("The lecture is in " + Days[Int32.Parse(searchLectures.Tables[0].Rows[i]["Day"].ToString()) - 1] + " and the " + type + " was requested in " + Days[day - 1] +
                            "\nA " + type + " will not be schedualed before the lecture!\nPlease change the day of the lecture or choose to schedule the " + type + " in other day", "Error"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (Int32.Parse(searchLectures.Tables[0].Rows[i]["Day"].ToString()) == day)
                    {
                        if (Int32.Parse(searchLectures.Tables[0].Rows[i]["EndTime"].ToString().Substring(0, searchLectures.Tables[0].Rows[i]["EndTime"].ToString().LastIndexOf(":"))) >= Int32.Parse(startTime))
                        {
                            DataSet numLecturesInDay = SqlWorker.GetDataSet("SELECT * From Lecture WHERE CourseName LIKE '" + Course.Tables[0].Rows[0]["CourseName"].ToString() + "' AND Day='" + day + "'");

                            string secStartTime = numLecturesInDay.Tables[0].Rows[numLecturesInDay.Tables[0].Rows.Count - 1]["EndTime"].ToString().Substring(0, searchLectures.Tables[0].Rows[numLecturesInDay.Tables[0].Rows.Count - 1]["EndTime"].ToString().LastIndexOf(":"));
                            string[] TempHoursPractitioner = HoursPractitioner.Where(val => Int32.Parse(val) > Int32.Parse(secStartTime)).ToArray();

                            // Same proccess like before
                            for (int m = 0; m < data.Tables[0].Rows.Count; m++)
                            {
                                Break = false;
                                matchFound = false;
                                HoursClass = data.Tables[0].Rows[m]["Hours"].ToString().Split(delimiterChars);

                                for (int h = 0; h < TempHoursPractitioner.Length; h++)
                                {
                                    for (int j = 0; j < HoursClass.Length; j++)
                                    {
                                        if (TempHoursPractitioner[h] == HoursClass[j] && TempHoursPractitioner[h] != "0" && HoursClass[j] != "0")
                                        {
                                            forDB = type + "Duration";
                                            for (int k = 0; k < Int32.Parse(Course.Tables[0].Rows[0][forDB].ToString()); k++)
                                            {
                                                if (TempHoursPractitioner.Length <= (h + k) || HoursClass.Length <= (j + k))
                                                {
                                                    Break = true;
                                                    break;
                                                }
                                                else
                                                {
                                                    if (TempHoursPractitioner[h + k] != HoursClass[j + k] || TempHoursPractitioner[h + k] == "0" || HoursClass[j + k] == "0")
                                                    {
                                                        Break = true;
                                                        break;
                                                    }
                                                }
                                            } // end for (k)

                                            if (!Break)
                                            {
                                                classNumInData = m;
                                                startTime = TempHoursPractitioner[h];
                                                matchFound = true;
                                                break;
                                            }
                                        }
                                    } // end for (j)

                                    if (matchFound)
                                    {
                                        break;
                                    }
                                } // end for (h)

                                if (matchFound)
                                {
                                    break;
                                }
                            } // end for (m)

                            if (!matchFound)
                            {
                                MessageBox.Show("The lecture and the " + type + " are in " + Days[day - 1] + ", but the ending hours of the lecture is bigger then the start time of the " + type +
                                            "!\nPlease insert other day for the " + type + " or change the lecture hours!", "Error"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        } // end if
                    } // end else if
                } // end for (i)

                // Fixing the new hours for the practitioner and the class
                string NewPractitionerHours = "", NewClassHours = "";

                for (int i = 0; i < HoursPractitioner.Length; i++)
                {
                    if (HoursPractitioner[i] == startTime)
                    {
                        forDB = type + "Duration";
                        for (int j = 0; j < Int32.Parse(Course.Tables[0].Rows[0][forDB].ToString()); j++)
                        {
                            NewPractitionerHours += "0,";
                        }
                        i = i + Int32.Parse(Course.Tables[0].Rows[0][forDB].ToString()) - 1;
                    }
                    else
                    {
                        NewPractitionerHours += (HoursPractitioner[i] + ",");
                    }
                }
                NewPractitionerHours = NewPractitionerHours.Substring(0, NewPractitionerHours.Length - 1);

                for (int i = 0; i < HoursClass.Length; i++)
                {
                    if (HoursClass[i] == startTime)
                    {
                        forDB = type + "Duration";
                        for (int j = 0; j < Int32.Parse(Course.Tables[0].Rows[0][forDB].ToString()); j++)
                        {
                            NewClassHours += "0,";
                        }
                        i = i + Int32.Parse(Course.Tables[0].Rows[0][forDB].ToString()) - 1;
                    }
                    else
                    {
                        NewClassHours += (HoursClass[i] + ",");
                    }
                }
                NewClassHours = NewClassHours.Substring(0, NewClassHours.Length - 1);

                int numOfTeachingExercises = 0;

                forDB = "numOf" + type + "s";
                if (DBNull.Value.Equals(Course.Tables[0].Rows[0][forDB]))
                {
                    numOfTeachingExercises++;
                }
                else
                {
                    numOfTeachingExercises = Int32.Parse(Course.Tables[0].Rows[0][forDB].ToString()) + 1;
                }

                // Updating the database
                SqlWorker.GetDataSet("UPDATE Class SET Hours='" + NewClassHours + "' WHERE Room='" + data.Tables[0].Rows[classNumInData]["Room"].ToString() + "' AND Days='" + day + "'");

                SqlWorker.GetDataSet("UPDATE Courses SET " + forDB + "='" + numOfTeachingExercises + "' WHERE CourseName='" + Course.Tables[0].Rows[0]["CourseName"].ToString() + "'");

                SqlWorker.GetDataSet("UPDATE Constraines_PraLec SET HoursAvail='" + NewPractitionerHours + "' WHERE TeacherID='" + Course.Tables[0].Rows[0]["Practitioner"].ToString() + "' AND Day='" + Days[day - 1] + "'");

                forDB = type + "Duration";
                string endTime = (Int32.Parse(startTime) + Int32.Parse(Course.Tables[0].Rows[0][forDB].ToString())).ToString();

                SqlWorker.GetDataSet("INSERT INTO TeachingExercises(StartTime,EndTime,Class,Practitioner,type,CourseName,Day,AmountOfStudents) VALUES('" + startTime + ":00','" + endTime + ":00','" + data.Tables[0].Rows[classNumInData]["Room"].ToString()
                            + "','" + Course.Tables[0].Rows[0]["Practitioner"].ToString() + "','" + type + "','" + Course.Tables[0].Rows[0]["CourseName"].ToString() + "','" + day + "','0')");

                MessageBox.Show("A new " + type + " was added:\nStart Time: " + startTime + ":00\nEnd Time: " + endTime + ":00\nClass: "
                            + data.Tables[0].Rows[classNumInData]["Room"].ToString() + "\nPractitioner: " + PractitionerName_Label.Text + "\nCourse Name: " + CourseNames_combo.SelectedItem.ToString() + "\nDay: " + Days[day - 1], "Message"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            else
            {
                MessageBox.Show("No class available in this day that matchs the practitioner's requirment!", "Error"
            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void Adding_Click(object sender, EventArgs e)
        {

            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CourseNames_combo.SelectedIndex != -1)
            {
                if ((DayTimeLab_combo.SelectedIndex != -1 && DayTimeLab_combo.Visible == true) || (DayTimePractice_combo.SelectedIndex != -1 && DayTimePractice_combo.Visible == true))
                {
                    // Scheduling the practice and the lab
                    if (PracticeDuration_Label.Text != "No Practice Exist." && LabDuration_label.Text != "No Lab Exist.")
                    {
                        schedulePractice("Practice");
                        schedulePractice("Lab");
                    }
                    else if (PracticeDuration_Label.Text == "No Practice Exist." && LabDuration_label.Text != "No Lab Exist.") schedulePractice("Lab");
                    else if (PracticeDuration_Label.Text != "No Practice Exist." && LabDuration_label.Text == "No Lab Exist.") schedulePractice("Practice");
                }
                else
                {
                    MessageBox.Show("No day and time was selected!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("No course was selected!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DayTimePractice_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DayTimeLab_combo.SelectedIndex != -1 || DayTimePractice_combo.SelectedIndex != -1)
            {
                Adding.Enabled = true;
            }
            else
            {
                Adding.Enabled = false;
            }
        }
    }
}
