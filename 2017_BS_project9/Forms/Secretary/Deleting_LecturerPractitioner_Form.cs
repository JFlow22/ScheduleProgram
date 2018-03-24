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
    public partial class Deleting_LecturerPractitioner_Form : MetroForm
    {
        private string ID = "";
        private string name = "";
        public Deleting_LecturerPractitioner_Form()
        {
            InitializeComponent();
        }

        private void Deleting_LecturerPractitioner_Form_Load(object sender, EventArgs e)
        {
            lecpra_combo.SelectedIndex = 0;
            comboBox1.Visible = false;
            label2.Visible = false;
        }

        private void lecpra_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            id_list.Items.Clear();

            int count = 0;
            


            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataSet dataset;

            dataset = SqlWorker.GetDataSet("SELECT ID,Name From Users WHERE Type='" + lecpra_combo.Text + "'");
            while (dataset.Tables[0].Rows.Count > count)
            {
                ID = dataset.Tables[0].Rows[count][0].ToString();
                name = dataset.Tables[0].Rows[count][1].ToString();
                id_list.Items.Add(name + " | " + ID);
                count++;
            }
        }

        private bool check_replacement()
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter " + lecpra_combo.SelectedItem.ToString() + " to replace!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void practice_filter_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                //-------------------------------------------------------------------------------------------------------


                if (!SqlWorker.CheckForInternetConnection())
                {
                    MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataSet dataset;
                ID = (id_list.SelectedItem.ToString().Split('|'))[1];
                ID = ID.Split(' ')[1];
                String RPC_ID = "";
                if (comboBox1.SelectedIndex != -1)
                {
                    RPC_ID = (comboBox1.SelectedItem.ToString().Split(' '))[2];
                }
                
                dataset = SqlWorker.GetDataSet("SELECT "+ lecpra_combo.SelectedItem.ToString() + " From Courses WHERE "+ lecpra_combo.SelectedItem.ToString() + "='" + ID + "'");
                if (dataset.Tables[0].Rows.Count != 0)
                {
                    if (!check_replacement()) return;
                    SqlWorker.GetDataSet("UPDATE Courses SET " + lecpra_combo.SelectedItem.ToString() + "='" + RPC_ID + "' WHERE " + lecpra_combo.SelectedItem.ToString() + "='" + ID + "'");
                }

                String q1="", q2="";
                switch (lecpra_combo.SelectedItem.ToString())
                {
                    case "Practitioner":
                        q1 = "SELECT Practitioner From TeachingExercises WHERE Practitioner LIKE '" + ID + "'";
                        q2 = "UPDATE TeachingExercises SET Practitioner='" + RPC_ID + "' WHERE Practitioner LIKE '" + ID + "'";
                        break;
                    case "Lecturer":
                        q1 = "SELECT Lecturer From Lecture WHERE Lecturer LIKE '" + ID + "'";
                        q2 = "UPDATE Lecture SET Lecturer='" + RPC_ID + "' WHERE Lecturer LIKE '" + ID + "'";
                        break;
                }
                dataset = SqlWorker.GetDataSet(q1);
                if (dataset.Tables[0].Rows.Count != 0)
                {
                    if (!check_replacement()) return;
                    SqlWorker.GetDataSet(q2);
                }

                //NO NEED IN REPLACEMENT
                dataset = SqlWorker.GetDataSet("SELECT TeacherID From ClassRequest WHERE TeacherID='" + ID + "'");
                if (dataset.Tables[0].Rows.Count != 0)
                {
                    SqlWorker.GetDataSet("DELETE FROM ClassRequest WHERE TeacherID='" + ID + "'");
                }

                dataset = SqlWorker.GetDataSet("SELECT TeacherId From Constraines_PraLec WHERE TeacherId='" + ID + "'");
                if (dataset.Tables[0].Rows.Count != 0)
                {
                    SqlWorker.GetDataSet("DELETE FROM Constraines_PraLec WHERE TeacherID='" + ID + "'");
                }

                dataset = SqlWorker.GetDataSet("SELECT TeacherID From ClassRequest WHERE TeacherID='" + ID + "'");
                if (dataset.Tables[0].Rows.Count != 0)
                {
                    SqlWorker.GetDataSet("DELETE FROM ClassRequest WHERE TeacherID='" + ID + "'");
                }

                dataset = SqlWorker.GetDataSet("SELECT ID From Users WHERE ID='" + ID + "'");
                if (dataset.Tables[0].Rows.Count != 0)
                {
                    SqlWorker.GetDataSet("DELETE FROM Users WHERE ID='" + ID + "'");
                }

                Deleting_LecturerPractitioner_Form_Load(sender, e);

                MessageBox.Show(lecpra_combo.SelectedItem.ToString() + " was deleted!", "Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                //-------------------------------------------------------------------------------------------------------
            }
        }

        private void id_list_SelectedIndexChanged(object sender, EventArgs e)
        {


            comboBox1.Items.Clear();
            for (int i = 0; i < id_list.Items.Count; i++)
            {
                if(i != id_list.SelectedIndex)
                {
                    comboBox1.Items.Add(id_list.Items[i].ToString());
                }
            }
            label2.Visible = true;
            comboBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
