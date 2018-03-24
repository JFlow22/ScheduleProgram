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
    public partial class SearchForSubstitute_Form : MetroForm
    {
        public SearchForSubstitute_Form()
        {
            InitializeComponent();
        }

        private void SearchForSubstitute_Form_Load(object sender, EventArgs e)
        {
            DataSet dataset;


            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataset = SqlWorker.GetDataSet("SELECT CourseName From Courses");
            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                course_chooser.Items.Add(dataset.Tables[0].Rows[i][0]);
            }

        }

        private void course_chooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dataset, dataset1;
   
            sPrac.Items.Clear();
            sLec.Items.Clear();
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataset = SqlWorker.GetDataSet("SELECT Practitioner,Lecturer From Courses WHERE CourseName LIKE '" + ((ComboBox)sender).SelectedItem.ToString() + "'");

            dataset1 = SqlWorker.GetDataSet("SELECT Name From Users WHERE ID ='" + dataset.Tables[0].Rows[0][0] + "'"); //PRAC ID
            cPrac.Text = dataset1.Tables[0].Rows[0][0].ToString();

            dataset1 = SqlWorker.GetDataSet("SELECT Name From Users WHERE ID ='" + dataset.Tables[0].Rows[0][1] + "'"); //LEC ID
            cLec.Text = dataset1.Tables[0].Rows[0][0].ToString();

            dataset1 = SqlWorker.GetDataSet("SELECT Name From Users WHERE ID != '" + dataset.Tables[0].Rows[0][0] + "' AND Type like 'Practitioner'"); // get the rest prac
            for (int i = 0; i < dataset1.Tables[0].Rows.Count; i++)
            {
                sPrac.Items.Add(dataset1.Tables[0].Rows[i][0]);
            }

            dataset1 = SqlWorker.GetDataSet("SELECT Name From Users WHERE ID != '" + dataset.Tables[0].Rows[0][1] + "' AND Type like 'Lecturer'"); // get the rest lec
            for (int i = 0; i < dataset1.Tables[0].Rows.Count; i++)
            {
                sLec.Items.Add(dataset1.Tables[0].Rows[i][0]);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {

            DataSet dataset, dataset1, dataset2,dataset3;
            int id = -1;
            if ((sPrac.SelectedIndex == -1) && (sLec.SelectedIndex == -1))
            {
                MessageBox.Show("please enter substitute lecturer or practitioner!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //----------------------------------------practitioner test-------------------------------------
            if (sPrac.SelectedIndex != -1)
            {

                
                if (!SqlWorker.CheckForInternetConnection())
                {
                    MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // get the practitioner id from the course
                dataset = SqlWorker.GetDataSet("SELECT ID From Users WHERE Name LIKE '" + sPrac.SelectedItem + "'"); 

                id = Int32.Parse(dataset.Tables[0].Rows[0][0].ToString());

                // get the all courses that the practitioner have.
                dataset1 = SqlWorker.GetDataSet("SELECT CourseName From Courses WHERE Practitioner = '" + id + "'");

                // get the all TE that the traget courses have
                dataset2 = SqlWorker.GetDataSet("SELECT StartTime,EndTime,Day From TeachingExercises WHERE CourseName LIKE '" + course_chooser.SelectedItem + "'");

                //any course the prac have
                for (int i = 0; i < dataset1.Tables[0].Rows.Count; i++) 
                {
                    //get the teaching exercing for the course
                    dataset = SqlWorker.GetDataSet("SELECT StartTime,EndTime,Day From TeachingExercises WHERE CourseName LIKE '" + dataset1.Tables[0].Rows[i][0] + "'");
                    
                    //go to any te for the courses
                    for (int j = 0; j < dataset.Tables[0].Rows.Count; j++) 
                    {
                        //check with every te in the current course
                        for (int k = 0; k < dataset2.Tables[0].Rows.Count; k++)
                        {
                            //dataset -> te that the prac have
                            //dataset2 -> te that the current course have

                            string PS, PE, CS, CE, CD, PD;

                            PS = dataset.Tables[0].Rows[j][0].ToString();
                            PE = dataset.Tables[0].Rows[j][1].ToString();
                            PD = dataset.Tables[0].Rows[j][2].ToString();

                            CS = dataset2.Tables[0].Rows[k][0].ToString();
                            CE = dataset2.Tables[0].Rows[k][1].ToString();
                            CD = dataset2.Tables[0].Rows[k][2].ToString();
                            if (toMin(PD) == toMin(CD))
                            {
                                if ((toMin(PS) <= toMin(CS) && toMin(CS) < toMin(PE)) || (toMin(PS) < toMin(CE) && toMin(CS) <= toMin(PE)))
                                {
                                    MessageBox.Show("the practitioner is not available for that days!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            switch (CD)
                            {
                                case ("1"):
                                    CD = "Sunday";
                                    break;
                                case ("2"):
                                    CD = "Monday";
                                    break;
                                case ("3"):
                                    CD = "Tuesday";
                                    break;
                                case ("4"):
                                    CD = "Wednesday";
                                    break;
                                case ("5"):
                                    CD = "Thursday";
                                    break;
                                case ("6"):
                                    CD = "Friday";
                                    break;

                            }

                            dataset3 = SqlWorker.GetDataSet("SELECT StartingTime, EndingTime, Day From Constraines_PraLec WHERE TeacherId = '" + id + "' AND Day Like '"+CD+"'");
                            
                            if (dataset3.Tables[0].Rows.Count >= 1)
                            {
                                PS = dataset3.Tables[0].Rows[j][0].ToString();
                                PE = dataset3.Tables[0].Rows[j][1].ToString();
                                if (!(toMin(PS)<= toMin(CS) && toMin(PE) >= toMin(CE)))
                                {
                                    MessageBox.Show("the practitioner is not available for that days!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("the practitioner is not available for that days!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                        }
                    }
                }

                SqlWorker.GetDataSet("UPDATE Courses SET Practitioner = '" + id + "' WHERE CourseName like '" + course_chooser.SelectedItem + "'");
                SqlWorker.GetDataSet("UPDATE TeachingExercises SET Practitioner = '" + id + "' WHERE CourseName like '" + course_chooser.SelectedItem + "'");

            }

            
            
            //----------------------------------------practitioner test-------------------------------------"
            //----------------------------------------lecturer test-----------------------------------------
            if (sLec.SelectedIndex != -1)
            {

                if (!SqlWorker.CheckForInternetConnection())
                {
                    MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // get the lecturer id from the course
                dataset = SqlWorker.GetDataSet("SELECT ID From Users WHERE Name LIKE '" + sLec.SelectedItem + "'");

                id = Int32.Parse(dataset.Tables[0].Rows[0][0].ToString());

                // get the all courses that the practitioner have.
                dataset1 = SqlWorker.GetDataSet("SELECT CourseName From Courses WHERE Lecturer = '" + id + "'");

                // get the all TE that the traget courses have
                dataset2 = SqlWorker.GetDataSet("SELECT StartTime,EndTime,Day From Lecture WHERE CourseName LIKE '" + course_chooser.SelectedItem + "'");

                //any course the lec have
                for (int i = 0; i < dataset1.Tables[0].Rows.Count; i++)
                {
                    //get the teaching exercing for the course
                    dataset = SqlWorker.GetDataSet("SELECT StartTime,EndTime,Day From Lecture WHERE CourseName LIKE '" + dataset1.Tables[0].Rows[i][0] + "'");
                    //go to any te for the courses
                    for (int j = 0; j < dataset.Tables[0].Rows.Count; j++)
                    {
                        //check with every te in the current course
                        for (int k = 0; k < dataset2.Tables[0].Rows.Count; k++)
                        {
                            //dataset -> te that the prac have
                            //dataset2 -> te that the current course have

                            string PS, PE, CS, CE, CD, PD;

                            PS = dataset.Tables[0].Rows[j][0].ToString();
                            PE = dataset.Tables[0].Rows[j][1].ToString();
                            PD = dataset.Tables[0].Rows[j][2].ToString();

                            CS = dataset2.Tables[0].Rows[k][0].ToString();
                            CE = dataset2.Tables[0].Rows[k][1].ToString();
                            CD = dataset2.Tables[0].Rows[k][2].ToString();

                            if (toMin(PD) == toMin(CD))
                            {
                                if ((toMin(PS) <= toMin(CS) && toMin(CS) < toMin(PE)) || (toMin(PS) < toMin(CE) && toMin(CS) <= toMin(PE)))
                                {
                                    MessageBox.Show("the lecturer is not available for that days!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }

                            switch (CD)
                            {
                                case ("1"):
                                    CD = "Sunday";
                                    break;
                                case ("2"):
                                    CD = "Monday";
                                    break;
                                case ("3"):
                                    CD = "Tuesday";
                                    break;
                                case ("4"):
                                    CD = "Wednesday";
                                    break;
                                case ("5"):
                                    CD = "Thursday";
                                    break;
                                case ("6"):
                                    CD = "Friday";
                                    break;

                            }

                            dataset3 = SqlWorker.GetDataSet("SELECT StartingTime, EndingTime, Day From Constraines_PraLec WHERE TeacherId = '" + id + "' AND Day Like '" + CD + "'");
                           
                            if (dataset3.Tables[0].Rows.Count >= 1)
                            {
                                PS = dataset3.Tables[0].Rows[j][0].ToString();
                                PE = dataset3.Tables[0].Rows[j][1].ToString();

                                if (!(toMin(PS) <= toMin(CS) && toMin(PE) >= toMin(CE)))
                                {
                                    MessageBox.Show("the Lecturer is not available for that days!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("the Lecturer is not available for that days!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }

                SqlWorker.GetDataSet("UPDATE Courses SET Lecturer = '"+id+ "' WHERE CourseName like '" + course_chooser.SelectedItem+"'");
                SqlWorker.GetDataSet("UPDATE Lecture SET Lecturer = '" + id + "' WHERE CourseName like '" + course_chooser.SelectedItem + "'");
            }



            //----------------------------------------lecturer test-----------------------------------------
            
            MessageBox.Show("Substitute completed Successfully!", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
           

        }

        private int toMin(string hour)
        {
            return Int32.Parse(hour.Split(':')[0]) * 60;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}
