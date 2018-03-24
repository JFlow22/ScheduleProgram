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
    public partial class Searching_Filtering_Lectures_Form : MetroForm
    {
        public Searching_Filtering_Lectures_Form()
        {
            InitializeComponent();
        }

        private void CourseNames_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lecturesNum = 0;

            id_list.Items.Clear(); class_list.Items.Clear(); lecturers_list.Items.Clear();
            endTime_list.Items.Clear(); startTime_list.Items.Clear();

            id_combo.Items.Clear(); class_combo.Items.Clear(); lecturers_combo.Items.Clear();
            endTime_combo.Items.Clear(); startTime_combo.Items.Clear();

            int count = 0;

            bool flag = false;

 
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CourseNames_combo.Text == "")
            {
                MessageBox.Show("Please select a course before searching!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataSet dataset, dataset1;

            dataset = SqlWorker.GetDataSet("SELECT * From Lecture");

            while (dataset.Tables[0].Rows.Count > count)
            {
                if (CourseNames_combo.SelectedItem.ToString() == dataset.Tables[0].Rows[count]["CourseName"].ToString())
                {
                    flag = true;
                    id_list.Items.Add(dataset.Tables[0].Rows[count]["ID"].ToString());
                    startTime_list.Items.Add(dataset.Tables[0].Rows[count]["StartTime"].ToString());
                    endTime_list.Items.Add(dataset.Tables[0].Rows[count]["EndTime"].ToString());
                    class_list.Items.Add(dataset.Tables[0].Rows[count]["Class"].ToString());
                    dataset1 = SqlWorker.GetDataSet("SELECT Name From Users WHERE ID='" + dataset.Tables[0].Rows[count]["Lecturer"].ToString() + "'");
                    lecturers_list.Items.Add(dataset1.Tables[0].Rows[0][0].ToString());
                    lecturesNum++;
                }
                count++;
            }
            if (flag == false)
            {
                MessageBox.Show("No lecture was found for this course.", "Error"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] StartTime_array = new string[lecturesNum], EndTime_array = new string[lecturesNum], Class_array = new string[lecturesNum], ID_array = new string[lecturesNum], Lecturer_array = new string[lecturesNum];

            count = 0;
            int arrayCount = 0;
            while (dataset.Tables[0].Rows.Count > count)
            {
                if (CourseNames_combo.SelectedItem.ToString() == dataset.Tables[0].Rows[count]["CourseName"].ToString())
                {
                    StartTime_array[arrayCount] = (dataset.Tables[0].Rows[count]["StartTime"].ToString()).Substring(0, (dataset.Tables[0].Rows[count]["StartTime"].ToString().LastIndexOf(":")));
                    EndTime_array[arrayCount] = (dataset.Tables[0].Rows[count]["EndTime"].ToString()).Substring(0, (dataset.Tables[0].Rows[count]["EndTime"].ToString().LastIndexOf(":")));
                    Class_array[arrayCount] = dataset.Tables[0].Rows[count]["Class"].ToString();
                    dataset1 = SqlWorker.GetDataSet("SELECT Name From Users WHERE ID='" + dataset.Tables[0].Rows[count]["Lecturer"].ToString() + "'");
                    Lecturer_array[arrayCount] = dataset1.Tables[0].Rows[0][0].ToString();
                    ID_array[arrayCount] = dataset.Tables[0].Rows[count]["ID"].ToString();
                    arrayCount++;
                }
                count++;
            }

            int[] StartTime_array_int = Array.ConvertAll(StartTime_array, int.Parse);
            Array.Sort(StartTime_array_int);
            StartTime_array = StartTime_array_int.Select(x => x.ToString()).ToArray();

            for (int i = 0; i < StartTime_array_int.Length; i++)
            {
                startTime_combo.Items.Add(StartTime_array[i] + ":00");
            }

            int[] EndTime_array_int = Array.ConvertAll(EndTime_array, int.Parse);

            EndTime_array_int = Array.ConvertAll(EndTime_array, int.Parse);
            Array.Sort(EndTime_array_int);
            EndTime_array = EndTime_array_int.Select(x => x.ToString()).ToArray();

            for (int i = 0; i < EndTime_array_int.Length; i++)
            {
                endTime_combo.Items.Add(EndTime_array[i] + ":00");
            }

            var sorted_string_Class_array = Class_array.Distinct().ToArray();

            for (int i = 0; i < sorted_string_Class_array.Length; i++)
            {
                class_combo.Items.Add(sorted_string_Class_array[i]);
            }

            var sorted_string_ID_array = ID_array.Distinct().ToArray();

            for (int i = 0; i < sorted_string_ID_array.Length; i++)
            {
                id_combo.Items.Add(sorted_string_ID_array[i]);
            }

            var sorted_string_Lecturer_array = Lecturer_array.Distinct().ToArray();

            for (int i = 0; i < sorted_string_Lecturer_array.Length; i++)
            {
                lecturers_combo.Items.Add(sorted_string_Lecturer_array[i]);
            }
        }

        private void Searching_Filtering_Lectures_Form_Load(object sender, EventArgs e)
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

            dataset = SqlWorker.GetDataSet("SELECT * From Courses");
            while (dataset.Tables[0].Rows.Count > count)
            {
                courseName = dataset.Tables[0].Rows[count]["CourseName"].ToString();
                CourseNames_combo.Items.Add(courseName);
                count++;
            }
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            id_combo.SelectedIndex = -1; class_combo.SelectedIndex = -1; lecturers_combo.SelectedIndex = -1;
            endTime_combo.SelectedIndex = -1; startTime_combo.SelectedIndex = -1;
        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            int count = 0;
            DataSet dataset, dataset1;

  
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CourseNames_combo.Text == "")
            {
                MessageBox.Show("Please select a course before filtering!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (startTime_combo.SelectedIndex > -1 && endTime_combo.SelectedIndex > -1)
            {
                if (Int32.Parse((startTime_combo.SelectedItem.ToString()).Substring(0, startTime_combo.SelectedItem.ToString().LastIndexOf(":"))) >= Int32.Parse((endTime_combo.SelectedItem.ToString()).Substring(0, endTime_combo.SelectedItem.ToString().LastIndexOf(":"))))
                { 
                    MessageBox.Show("Hours are incorrect! Please try again!", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string startTime = null, endTime = null, Class = null, lecturer = null, id = null;

            if (startTime_combo.SelectedIndex > -1)
            {
                startTime = startTime_combo.SelectedItem.ToString();
            }

            if (endTime_combo.SelectedIndex > -1)
            {
                endTime = endTime_combo.SelectedItem.ToString();
            }

            if (class_combo.SelectedIndex > -1)
            {
                Class = class_combo.SelectedItem.ToString();
            }

            if (lecturers_combo.SelectedIndex > -1)
            {
                dataset1 = SqlWorker.GetDataSet("SELECT ID From Users WHERE Name='" + lecturers_combo.SelectedItem.ToString() + "'");
                lecturer = dataset1.Tables[0].Rows[0][0].ToString();
            }

            if (id_combo.SelectedIndex > -1)
            {
                id = id_combo.SelectedItem.ToString();
            }

            dataset = searchLecture(startTime, endTime, Class, lecturer, id);

            if (dataset == null)
            {
                MessageBox.Show("No Filter was inserted! Please try again!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            id_list.Items.Clear(); class_list.Items.Clear(); lecturers_list.Items.Clear();
            endTime_list.Items.Clear(); startTime_list.Items.Clear();

            while (dataset.Tables[0].Rows.Count > count)
            {
                if (CourseNames_combo.SelectedItem.ToString() == dataset.Tables[0].Rows[count]["CourseName"].ToString())
                {
                    id_list.Items.Add(dataset.Tables[0].Rows[count]["ID"].ToString());
                    startTime_list.Items.Add(dataset.Tables[0].Rows[count]["StartTime"].ToString());
                    endTime_list.Items.Add(dataset.Tables[0].Rows[count]["EndTime"].ToString());
                    class_list.Items.Add(dataset.Tables[0].Rows[count]["Class"].ToString());
                    dataset1 = SqlWorker.GetDataSet("SELECT Name From Users WHERE ID='" + dataset.Tables[0].Rows[count]["Lecturer"].ToString() + "'");
                    lecturers_list.Items.Add(dataset1.Tables[0].Rows[0][0].ToString());
                }
                count++;
            }

            if (dataset.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No lecture found with this filter!", "Message"
                   , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }

        public DataSet searchLecture(string startTime, string endTime, string Class, string lecturer, string id)
        {
            string sql_string = "WHERE ";

            if (startTime != null)
            {
                sql_string += "StartTime LIKE '" + startTime + "' AND ";
            }

            if (endTime != null)
            {
                sql_string += "EndTime LIKE '" + endTime + "' AND ";
            }

            if (Class != null)
            {
                sql_string += "Class LIKE '" + Class + "' AND ";
            }

            if (lecturer != null)
            {
                sql_string += "Lecturer LIKE '" + lecturer + "' AND ";
            }

            if (id != null)
            {
                sql_string += "ID LIKE '" + id + "' AND ";
            }

            if (sql_string == "WHERE ")
            {
                return null;
            }

            sql_string = sql_string.Substring(0, sql_string.Length - 5);
            return SqlWorker.GetDataSet("Select * From Lecture " + sql_string);
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
