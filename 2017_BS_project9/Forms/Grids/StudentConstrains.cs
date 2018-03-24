using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2017_BS_project9
{
    public partial class StudentConstains : MetroForm
    {
        private Student currentStudent;


        /// <summary>
        /// 
        /// </summary>
        public StudentConstains(Student currentStudent)
        {
            InitializeComponent();
            this.constrainsWeekGrid.buildGrid();
            if (currentStudent != null)
                this.currentStudent = currentStudent;
            else
                this.currentStudent = Globals._session as Student;

            this.constrainsWeekGrid.MultiSelect = true;
        }


        private void StudentConstains_Load(object sender, EventArgs e)
        {
            this.constrainsWeekGrid.ClearSelection();

            if (currentStudent.Constraints != null)
            {
                string[] constraints = currentStudent.Constraints.Split(';');
                foreach(string constrain in constraints)
                {
                    if (constrain == "")
                        break;
                    MatchCollection match = Regex.Matches(constrain, @"[0-9]+");
                    int col = int.Parse(match[0].ToString());
                    int row = int.Parse(match[1].ToString());
                    this.constrainsWeekGrid[col,row].Selected = true;
                }
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            String constraints = "";
            for (int col = 1; col < this.constrainsWeekGrid.ColumnCount; col++)
            {
                for (int row = 0; row < this.constrainsWeekGrid.RowCount; row++)
                {
                    if (this.constrainsWeekGrid[col, row].Selected)
                    {
                        constraints += "Day: " + col + " Hour: " + row + ";";
                    }
                }
            }

            currentStudent.Constraints = constraints;
            if (SqlWorker.SaveUser(currentStudent))
                MessageBox.Show("Saved successfully!");

            this.Close();
        }
    }
}
