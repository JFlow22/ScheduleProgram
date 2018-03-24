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
    public partial class Adding_Lecture_Form : MetroForm
    {
        // The days in the week
        private string[] Days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        private int lecturerID;
        private DataSet Course;


        public Adding_Lecture_Form()
        {
            InitializeComponent();
        }

        private void Adding_Lecture_Load(object sender, EventArgs e)
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
            DayTime_combo.Items.Clear();

            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

   
            // Filling all the information to the secretary about the course like lecture duration, etc.
            Course = SqlWorker.GetDataSet("SELECT * From Courses WHERE CourseName='" + CourseNames_combo.SelectedItem.ToString() + "'");

            lecturerID = Int32.Parse(Course.Tables[0].Rows[0]["Lecturer"].ToString());

            DataSet data = SqlWorker.GetDataSet("SELECT * From Users WHERE ID=" + lecturerID);
            LecturerName_Label.Text = data.Tables[0].Rows[0]["Name"].ToString();
            LecturerName_Label.Visible = true;

            LectureDuration_Label.Text = Course.Tables[0].Rows[0]["LectureDuration"].ToString();
            LectureDuration_Label.Visible = true;

            data = SqlWorker.GetDataSet("SELECT * From Constraines_PraLec WHERE TeacherID=" + lecturerID);
            string[] day_time_array = new string[data.Tables[0].Rows.Count];

            // Checking for constraints of the lecturer.
            // If there are no constraints, a lecture cannot be scheduled
            if (data.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No constrains where found for the lecturer!\nPlease ask the lecturer to insert his constrains.", "Error"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < day_time_array.Length; i++)
            {
                day_time_array[i] = data.Tables[0].Rows[i]["Day"].ToString() + " | " + data.Tables[0].Rows[i]["StartingTime"].ToString() + " - " + data.Tables[0].Rows[i]["EndingTime"].ToString();
                DayTime_combo.Items.Add(day_time_array[i]);
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
                if (DayTime_combo.SelectedIndex != -1)
                {
                    // Selecting the class request for the lecturer
                    DataSet data = SqlWorker.GetDataSet("SELECT * From ClassRequest WHERE TeacherID=" + lecturerID + " AND CourseName='" + CourseNames_combo.SelectedItem.ToString() + "'");
                    bool needProj = false;

                    int day = 0;

                    string str = (DayTime_combo.SelectedItem.ToString()).Substring(0, DayTime_combo.SelectedItem.ToString().LastIndexOf("|") - 1);

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
                        if (data.Tables[0].Rows[0]["Projector"].ToString() == "1")
                        {
                            needProj = true;
                        }

                        string sql_string = "";
                        if (needProj)
                        {
                            sql_string = "SELECT * From Class WHERE HasProjector='1'"; 
                        }
                        else
                        {
                            sql_string = "SELECT * From Class WHERE HasProjector='0'";
                        }

                        data = SqlWorker.GetDataSet(sql_string + " AND Days='" + day + "'");

                        if (data.Tables[0].Rows.Count == 0)
                        {
                            data = SqlWorker.GetDataSet("SELECT * From Class WHERE Days ='" + day + "'");
                        }
                    }

                    // Checking the lecturer's constraints
                    DataSet LecturerConstraines = SqlWorker.GetDataSet("SELECT * From Constraines_PraLec WHERE TeacherId=" + Course.Tables[0].Rows[0]["Lecturer"].ToString() + " AND Day='" + Days[day] + "'");
                    
                    if (data.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("No class available in " + Days[day - 1] + "!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    char[] delimiterChars = { ',' };

                    string[] HoursLecturer = LecturerConstraines.Tables[0].Rows[0]["HoursAvail"].ToString().Split(delimiterChars);
                    string[] HoursClass = null;

                    string startTime = "";
                    int classNumInData = 0;

                    bool matchFound = false;
                    bool Break = false;

                    // This for loop will run on all the class
                    for (int m = 0; m < data.Tables[0].Rows.Count; m++)
                    {
                        Break = false;
                        matchFound = false;
                        HoursClass = data.Tables[0].Rows[m]["Hours"].ToString().Split(delimiterChars);

                        // This for loop will run on all the availabe hours of the lecturer that day
                        for (int i = 0; i < HoursLecturer.Length; i++)
                        {
                            // This for loop will run on all the availabe hours of the class that day
                            for (int j = 0; j < HoursClass.Length; j++)
                            {
                                if (HoursLecturer[i] == HoursClass[j] && HoursLecturer[i] != "0" && HoursClass[j] != "0")
                                {
                                    // This for will check if the class and the lecutrer are available for the lecture time
                                    for (int k = 0; k < Int32.Parse(Course.Tables[0].Rows[0]["LectureDuration"].ToString()); k++)
                                    {
                                        // Finding the match
                                        if (HoursLecturer.Length <= (i + k) || HoursClass.Length <= (j + k))
                                        {
                                            Break = true;
                                            break;
                                        }
                                        else
                                        {
                                            if (HoursLecturer[i + k] != HoursClass[j + k] || HoursLecturer[i + k] == "0" || HoursClass[j + k] == "0")
                                            {
                                                Break = true;
                                                break;
                                            }
                                        }
                                    } // end for (k)

                                    if (!Break)
                                    {
                                        classNumInData = m;
                                        startTime = HoursLecturer[i];
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
                        string endTime = (Int32.Parse(startTime) + Int32.Parse(Course.Tables[0].Rows[0]["LectureDuration"].ToString())).ToString();

                        DataSet searchTE = SqlWorker.GetDataSet("SELECT * From TeachingExercises WHERE CourseName LIKE '" + Course.Tables[0].Rows[0]["CourseName"].ToString() + "'");

                        // Checking if the lecture was scheduled before the practice/lab
                        // If the lecture is after the practice/lab, system will search for another time to schedule the lecture
                        // This for will run on all the teaching exercises of the course
                        for (int i = 0; i < searchTE.Tables[0].Rows.Count; i++)
                        {
                            if (Int32.Parse(searchTE.Tables[0].Rows[i]["Day"].ToString()) < day)
                            {
                                MessageBox.Show("The practice is in " + Days[Int32.Parse(searchTE.Tables[0].Rows[i]["Day"].ToString()) - 1] + " and the lecture was requested in " + Days[day - 1] +
                                    "\nA lecture will not be schedualed after the practice!\nPlease change the day of the practice or choose to schedule the lecture in other day", "Error"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else if (Int32.Parse(searchTE.Tables[0].Rows[i]["Day"].ToString()) == day) //If the lecture and the practice are in the same day
                            {
                                if (Int32.Parse(searchTE.Tables[0].Rows[i]["StartTime"].ToString().Substring(0, searchTE.Tables[0].Rows[i]["StartTime"].ToString().LastIndexOf(":"))) <= Int32.Parse(endTime))
                                {
                                    DataSet numTEInDay = SqlWorker.GetDataSet("SELECT * From TeachingExercises WHERE CourseName LIKE '" + Course.Tables[0].Rows[0]["CourseName"].ToString() + "' AND Day='" + day + "'");

                                    string secEndTime = numTEInDay.Tables[0].Rows[0]["StartTime"].ToString().Substring(0, numTEInDay.Tables[0].Rows[0]["StartTime"].ToString().LastIndexOf(":"));
                                    string[] TempHoursLecturer = HoursLecturer.Where(val => Int32.Parse(val) < Int32.Parse(secEndTime)).ToArray();
                                    // Same proccess like before
                                    for (int m = 0; m < data.Tables[0].Rows.Count; m++)
                                    {
                                        Break = false;
                                        matchFound = false;
                                        HoursClass = data.Tables[0].Rows[m]["Hours"].ToString().Split(delimiterChars);

                                        for (int h = 0; h < TempHoursLecturer.Length; h++)
                                        {
                                            for (int j = 0; j < HoursClass.Length; j++)
                                            {
                                                if (TempHoursLecturer[h] == HoursClass[j] && TempHoursLecturer[h] != "0" && HoursClass[j] != "0")
                                                {
                                                    for (int k = 0; k < Int32.Parse(Course.Tables[0].Rows[0]["LectureDuration"].ToString()); k++)
                                                    {
                                                        if (TempHoursLecturer.Length <= (h + k) || HoursClass.Length <= (j + k))
                                                        {
                                                            Break = true;
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            if (TempHoursLecturer[h + k] != HoursClass[j + k] || TempHoursLecturer[h + k] == "0" || HoursClass[j + k] == "0")
                                                            {
                                                                Break = true;
                                                                break;
                                                            }
                                                        }
                                                    } // end for (k)

                                                    if (!Break)
                                                    {
                                                        classNumInData = m;
                                                        startTime = TempHoursLecturer[h];
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
                                        MessageBox.Show("The practice and the lecture are in " + Days[day - 1] + 
                                            ", but the starting hours of the practice is smaller then the " +
                                            "end time of the lecture!\nPlease insert other day for the lecture or change the practice hours!", "Error"
                                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                } // end if
                            } // end else if
                        } // end for (i)


                        // Fixing the new hours for the lecturer and the class
                        string NewLecturerHours = "", NewClassHours = "";
                        for (int i = 0; i < HoursLecturer.Length; i++)
                        {
                            if (HoursLecturer[i] == startTime)
                            {
                                for (int j = 0; j < Int32.Parse(Course.Tables[0].Rows[0]["LectureDuration"].ToString()); j++)
                                {
                                    NewLecturerHours += "0,";
                                }
                                i = i + Int32.Parse(Course.Tables[0].Rows[0]["LectureDuration"].ToString()) - 1;
                            }
                            else
                            {
                                NewLecturerHours += (HoursLecturer[i] + ",");
                            }
                        }
                        NewLecturerHours = NewLecturerHours.Substring(0, NewLecturerHours.Length - 1);

                        for (int i = 0; i < HoursClass.Length; i++)
                        {
                            if (HoursClass[i] == startTime)
                            {
                                for (int j = 0; j < Int32.Parse(Course.Tables[0].Rows[0]["LectureDuration"].ToString()); j++)
                                {
                                    NewClassHours += "0,";
                                }
                                i = i + Int32.Parse(Course.Tables[0].Rows[0]["LectureDuration"].ToString()) - 1;
                            }
                            else
                            {
                                NewClassHours += (HoursClass[i] + ",");
                            }
                        }
                        NewClassHours = NewClassHours.Substring(0, NewClassHours.Length - 1);

                        int numOfLectures = 0;

                        if (DBNull.Value.Equals(Course.Tables[0].Rows[0]["NumOfLectures"]))
                        {
                            numOfLectures++;
                        }
                        else
                        {
                            numOfLectures = Int32.Parse(Course.Tables[0].Rows[0]["NumOfLectures"].ToString()) + 1;
                        }

                        // Updating the database
                        SqlWorker.GetDataSet("UPDATE Class SET Hours='" + NewClassHours + "' WHERE Room='" + data.Tables[0].Rows[classNumInData]["Room"].ToString() + "' AND Days='" + day + "'");

                        SqlWorker.GetDataSet("UPDATE Courses SET NumOfLectures='" + numOfLectures + "' WHERE CourseName LIKE '" + Course.Tables[0].Rows[0]["CourseName"].ToString() + "'");

                        SqlWorker.GetDataSet("UPDATE Constraines_PraLec SET HoursAvail='" + NewLecturerHours + "' WHERE TeacherID='" + Course.Tables[0].Rows[0]["Lecturer"].ToString() + "' AND Day='" + Days[day - 1] + "'");

                        endTime = (Int32.Parse(startTime) + Int32.Parse(Course.Tables[0].Rows[0]["LectureDuration"].ToString())).ToString();

                        SqlWorker.GetDataSet("INSERT INTO Lecture(StartTime,EndTime,Class,Lecturer,CourseName,Day,AmountOfStudents) VALUES('" + startTime + ":00','" + endTime + ":00','" + data.Tables[0].Rows[classNumInData]["Room"].ToString()
                            + "','" + Course.Tables[0].Rows[0]["Lecturer"].ToString() + "','" + Course.Tables[0].Rows[0]["CourseName"].ToString() + "','" + day + "','0')");

                        MessageBox.Show("A new lecture was added:\nStart Time: " + startTime + ":00\nEnd Time: " + endTime + ":00\nClass: "
                            + data.Tables[0].Rows[classNumInData]["Room"].ToString() + "\nLecturer: " + LecturerName_Label.Text + "\nCourse Name: " + CourseNames_combo.SelectedItem.ToString() + "\nDay: " + Days[day - 1], "Message"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;
                    }
                    else
                    {
                        MessageBox.Show("No class available in this day that matchs the lecturer's requirment!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

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

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DayTime_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DayTime_combo.SelectedIndex != -1)
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
