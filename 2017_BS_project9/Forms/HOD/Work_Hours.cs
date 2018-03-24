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

namespace _2017_BS_project9
{
    public partial class Work_Hours : MetroForm
    {
        //Ctor
        public Work_Hours()
        {
            InitializeComponent();
            //Fill comboboxes of lecturers and practitioners
            if(SqlWorker.getAmountOfLecturers() > 0 || SqlWorker.getAmountOfPractitioners() > 0)
            {
                chart_type_combo.SelectedIndex = 0;
                if (SqlWorker.getAmountOfLecturers() > 0)
                {
                    lecturers_combo.DataSource = SqlWorker.GetDataSet("SELECT * From Users Where type='Lecturer'").Tables[0];
                    lecturers_combo.DisplayMember = "Name";
                    lecturers_combo.SelectedIndex = 0;
                }
                else
                {
                    All_lectures_radio.Enabled = false;
                    Lecturer_radio.Enabled = false;
                    lecturers_combo.Enabled = false;

                }
                if (SqlWorker.getAmountOfPractitioners() > 0)
                {
                    practitioner_combo.DataSource = SqlWorker.GetDataSet("SELECT * From Users Where type='Practitioner'").Tables[0];
                    practitioner_combo.DisplayMember = "Name";
                    practitioner_combo.SelectedIndex = 0;
                }
                else
                {
                    all_practitioner_radio.Enabled = false;
                    practitioner_radio.Enabled = false;
                    practitioner_combo.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("There is no practitioners/lecturers in the system!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            All_lectures_radio.Checked = true;
        }

        //Change the chart type
        private void chart_type_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (chart_type_combo.SelectedItem.ToString())
            {
                case "Column":
                    chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
                case "Doughnut":
                    chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
                    updatePieChart();
                    break;
            }
        }

        //If lecturer radio button changed
        private void Lecturer_radio_CheckedChanged(object sender, EventArgs e)
        {
            //If the radio button is checked
            if (Lecturer_radio.Checked == true)
            {
                //Clear chart
                chart.Series["Work Hours"].Points.Clear();
                //Enable combobox of lecturers
                lecturers_combo.Enabled = true;
                string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                //Get name and id of the lecturer
                DataRowView oDataRowView = lecturers_combo.SelectedItem as DataRowView;
                string name = oDataRowView.Row["Name"] as string;
                int id = (int)oDataRowView.Row["ID"];
                //Change title
                chart_title.Text = name + " work hours";
                lecturers_combo.Enabled = true;
                int workHours;
                DataSet LecturerDS;
                //Get all lectures of the lecturer
                LecturerDS = SqlWorker.GetDataSet("Select * From Lecture Where Lecturer='" + id + "'");
                for (int i = 1; i <= 6; i++)
                {
                    //Add each day work hours to the chart
                    workHours = SqlWorker.getWorkHours(Convert.ToInt32(id), false, i);
                    chart.Series["Work Hours"].Points.AddXY(days[i - 1], workHours);
                }
                //Remove lables with zero values in the pie chart
                updatePieChart();
            }
            else
                lecturers_combo.Enabled = false;
            
        }

        //If practitioner radio button changed
        private void practitioner_radio_CheckedChanged(object sender, EventArgs e)
        {
            if(practitioner_radio.Checked == true)
            {
                //Clear chart
                chart.Series["Work Hours"].Points.Clear();
                //Enable combobox of practitioners
                practitioner_combo.Enabled = true;
                string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                //Get name and id of the practitioner
                DataRowView oDataRowView = practitioner_combo.SelectedItem as DataRowView;
                string name = oDataRowView.Row["Name"] as string;
                int id = (int)oDataRowView.Row["ID"];
                int workHours;
                DataSet practitionerDS;
                //Change title
                chart_title.Text = name + " work hours";


                //Get all teaching exercises of the practitioner
                practitionerDS = SqlWorker.GetDataSet("Select * From TeachingExercises Where Practitioner='" + id + "'");
                for (int i = 1; i <= 6; i++)
                {
                    //Add each day work hours to the chart
                    workHours = SqlWorker.getWorkHours(Convert.ToInt32(id), true, i);
                    chart.Series["Work Hours"].Points.AddXY(days[i - 1], workHours);
                }
                //Remove lables with zero values in the pie chart
                updatePieChart();
            }
            else
                practitioner_combo.Enabled = false;
            
        }

        //If all lectures radio button changed
        private void All_lectures_radio_CheckedChanged(object sender, EventArgs e)
        {
            //If the radio button is checked
            if (All_lectures_radio.Checked == true)
            {
                //Clear chart
                chart.Series["Work Hours"].Points.Clear();
                //Change title
                chart_title.Text = "Lecturers work hours";

                int amountOfLecturers;
                //Get table of all lecturers
                DataSet lecturersDS = SqlWorker.GetDataSet("Select * from Users where type='Lecturer'");
                amountOfLecturers = SqlWorker.getAmountOfLecturers();
                //Get work houres for each lecturer and puit it on the chart
                for (int i = 0; i < amountOfLecturers; i++)
                {
                    String name = lecturersDS.Tables[0].Rows[i]["Name"].ToString();
                    String id = lecturersDS.Tables[0].Rows[i]["ID"].ToString();
                    int workHours = SqlWorker.getWorkHours(Convert.ToInt32(id), false,-1);
                    chart.Series["Work Hours"].Points.AddXY(name, workHours);
                }
                //Remove lables with zero values in the pie chart
                updatePieChart();
            }
        }

        //If all practitioners radio button was changed
        private void all_practitioner_radio_CheckedChanged(object sender, EventArgs e)
        {
            //If the radio button is checked
            if (all_practitioner_radio.Checked == true)
            {
                //Clear chart
                chart.Series["Work Hours"].Points.Clear();
                //Change title
                chart_title.Text = "Practitioners work hours";

                int amountOfPractitioners;
                //Get table containing all the practitioners
                DataSet practitionersDS = SqlWorker.GetDataSet("Select * from Users where type='Practitioner'");
                amountOfPractitioners = SqlWorker.getAmountOfPractitioners();
                //Get work hours for each practitioner and put it on the chart
                for (int i = 0; i < amountOfPractitioners; i++)
                {
                    String name = practitionersDS.Tables[0].Rows[i]["Name"].ToString();
                    String id = practitionersDS.Tables[0].Rows[i]["ID"].ToString();
                    int workHours = SqlWorker.getWorkHours(Convert.ToInt32(id), true,-1);
                    chart.Series["Work Hours"].Points.AddXY(name, workHours);
                }
                //Remove lables with zero values in the pie chart
                updatePieChart();
            }
        }

        //If selected item of lecturers combobox was changed
        private void lecturers_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Update the chart by updating the lecturer radio button
            DataRowView oDataRowView = lecturers_combo.SelectedItem as DataRowView;
            string name = oDataRowView.Row["Name"] as string;
            chart_title.Text = name + " work hours";
            Lecturer_radio.Checked = false;
            Lecturer_radio.Checked = true;

        }

        //If selected item of practitioners combobox was changed
        private void practitioner_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Update the chart by updating the practitioner radio button
            DataRowView oDataRowView = practitioner_combo.SelectedItem as DataRowView;
            string name = oDataRowView.Row["Name"] as string;
            chart_title.Text = name + " work hours";
            practitioner_radio.Checked = false;
            practitioner_radio.Checked = true;

        }

        //Remove lables with zero values in the pie chart
        private void updatePieChart()
        {
            foreach (System.Windows.Forms.DataVisualization.Charting.DataPoint point in chart.Series[0].Points)
            {
                if (point.YValues.Length > 0 && (double)point.YValues.GetValue(0) == 0)
                {
                    point.IsEmpty = true;
                }
                else
                {
                    point.IsEmpty = false;
                }
            }
        }

        //Get the lecturer/s that works the most
        private void lecturer_most_button_Click(object sender, EventArgs e)
        {

            //Get all lecturers
            DataSet lecturers = SqlWorker.GetDataSet("Select * from Users Where type='Lecturer'");
            //Show error message and exit if there is no lecturers
            if (lecturers.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("There is no lecturers in the system!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int maxWorkHours = 0, id, numOfLecturers = 0 ;
            //Find max of work hours
            for (int i = 0; i < lecturers.Tables[0].Rows.Count; i++)
            {
                id = Convert.ToInt32(lecturers.Tables[0].Rows[i]["ID"].ToString());
                int tmpWorkHours = SqlWorker.getWorkHours(id, false, -1);
                if (tmpWorkHours > maxWorkHours)
                    maxWorkHours = tmpWorkHours;
            }
            //Show error message and exit if none of the lecturers is working
            if (maxWorkHours == 0)
            {
                MessageBox.Show("There is no lecturer that is working!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Find the amount of lecturers with the maximum amount of work hours
            for (int i = 0; i < lecturers.Tables[0].Rows.Count; i++)
            {
                id = Convert.ToInt32(lecturers.Tables[0].Rows[i]["ID"].ToString());
                if (maxWorkHours == SqlWorker.getWorkHours(id, false, -1))
                    numOfLecturers++;
            }
            //Create the message
            String msg;
            if (numOfLecturers == 1)
                msg = "The lecturer with the most hours is\n";
            else
                msg = "The lecturers with the most hours are\n";
            //Add all lecturers to the message
            for (int i = 0; i < lecturers.Tables[0].Rows.Count; i++)
            {
                id = Convert.ToInt32(lecturers.Tables[0].Rows[i]["ID"].ToString());
                if (maxWorkHours == SqlWorker.getWorkHours(id, false, -1))
                {
                    msg += "Name: " + SqlWorker.getNameById(id.ToString()) + "\n";
                    msg += "ID: " + id + "\n";
                    msg += "Number of work hours: " + maxWorkHours.ToString() + "\n\n";
                }
            }
            //Show all lecturers with maximum amount of work hours
            MessageBox.Show(msg, "Works the most", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void practitioner_most_button_Click(object sender, EventArgs e)
        {
            //Get all practitioners
            DataSet practitioners = SqlWorker.GetDataSet("Select * from Users Where type='Practitioner'");
            //Show error message and exit if there is no practitioners
            if (practitioners.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("There is no practitioners in the system!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int maxWorkHours = 0, id, numOfLecturers = 0;
            //Find max of work hours
            for (int i = 0; i < practitioners.Tables[0].Rows.Count; i++)
            {
                id = Convert.ToInt32(practitioners.Tables[0].Rows[i]["ID"].ToString());
                int tmpWorkHours = SqlWorker.getWorkHours(id, true, -1);
                if (tmpWorkHours > maxWorkHours)
                    maxWorkHours = tmpWorkHours;
            }
            //Show error message and exit if none of the practitioners is working
            if (maxWorkHours == 0)
            {
                MessageBox.Show("There is no practitioner that is working!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Find the amount of practitioners with the maximum amount of work hours
            for (int i = 0; i < practitioners.Tables[0].Rows.Count; i++)
            {
                id = Convert.ToInt32(practitioners.Tables[0].Rows[i]["ID"].ToString());
                if (maxWorkHours == SqlWorker.getWorkHours(id, true, -1))
                    numOfLecturers++;
            }
            String msg;
            //Create the message
            if (numOfLecturers == 1)
                msg = "The practitioner with the most hours is\n";
            else
                msg = "The practitioners with the most hours are\n";
            //Add all practitioners to the message
            for (int i = 0; i < practitioners.Tables[0].Rows.Count; i++)
            {
                id = Convert.ToInt32(practitioners.Tables[0].Rows[i]["ID"].ToString());
                if (maxWorkHours == SqlWorker.getWorkHours(id, true, -1))
                {
                    msg += "Name: " + SqlWorker.getNameById(id.ToString()) + "\n";
                    msg += "ID: " + id + "\n";
                    msg += "Number of work hours: " + maxWorkHours.ToString() + "\n\n";
                }
            }
            //Show all lecturers with maximum amount of work hours
            MessageBox.Show(msg, "Works the most", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
