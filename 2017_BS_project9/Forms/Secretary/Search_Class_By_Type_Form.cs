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
    public partial class Search_Class_By_Type_Form : MetroForm
    {
        public Search_Class_By_Type_Form()
        {
            InitializeComponent();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            int count = 0;
            class_list.Items.Clear();
            lab_check.Checked = false;
            projector_check.Checked = false;
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataSet dataset;
            string className;

            dataset = searchClass(flag_has_projector.Checked, flag_is_lab.Checked);
            if (dataset != null)
            {
                while (dataset.Tables[0].Rows.Count > count)
                {
                    className = dataset.Tables[0].Rows[count]["Room"].ToString();
                    class_list.Items.Add(className);
                    count++;
                }
            }
        }

        // A function for searching the class in the DB
        public DataSet searchClass(bool has_projector, bool is_lab)
        {
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            string sql_string = "";

            if (has_projector == true && is_lab == true)
            {
                sql_string = "SELECT * From Class WHERE HasProjector = '1' AND IsLab = '1'";
            }

            if (has_projector == true && is_lab == false)
            {
                sql_string = "SELECT * From Class WHERE HasProjector = '1' AND IsLab = '0'";
            }

            if (is_lab == true && has_projector == false)
            {
                sql_string = "SELECT * From Class WHERE HasProjector = '0' AND IsLab = '1'";
            }

            if (has_projector == false && is_lab == false)
            {
                sql_string = "SELECT * From Class WHERE HasProjector = '0' AND IsLab = '0'";
            }

            return SqlWorker.GetDataSet(sql_string);
        }

        private void Search_Class_By_Type_Form_Load(object sender, EventArgs e)
        {
            class_list.Items.Clear();
            label2.Visible = false;
            textBox1.Visible = false;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
 
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataSet dataset;

            // updating the class type
            string sql_string_TE = "UPDATE TeachingExercises SET ";
            string sql_string_C = "UPDATE Class SET ";

            if (lab_check.Checked)
            {
                if (textBox1.Text != "")
                {
                    sql_string_C += "IsLab='1', NumOfComputers=" + textBox1.Text + ", ";
                }
                else
                {
                    MessageBox.Show("Please enter the number of the computers!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sql_string_TE += "Type='Lab' WHERE Class LIKE '" + class_list.SelectedItem.ToString() + "'";
            }
            else
            {
                sql_string_C += "IsLab='0', NumOfComputers=0, ";
                sql_string_TE += "Type='Practice' WHERE Class LIKE '" + class_list.SelectedItem.ToString() + "'";
            }
            if (projector_check.Checked)
            {
                sql_string_C += "HasProjector='1', ";
            }
            else
            {
                sql_string_C += "HasProjector='0', ";
            }

            sql_string_C = sql_string_C.Substring(0, sql_string_C.Length - 2);
            sql_string_C += " WHERE Room LIKE '" + class_list.SelectedItem.ToString() + "'";
            dataset = SqlWorker.GetDataSet(sql_string_C);
            dataset = SqlWorker.GetDataSet(sql_string_TE);
            MessageBox.Show("Update Has Succeeded.", "Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void class_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            lab_check.Checked = false;
            projector_check.Checked = false;
 
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataSet dataset, dataset1;
            dataset = SqlWorker.GetDataSet("SELECT * From Class WHERE Room LIKE '" + class_list.SelectedItem.ToString() + "'");
            
            if (dataset.Tables[0].Rows[0]["IsLab"].ToString() == "1")
            {
                lab_check.Checked = true;
                dataset1 = SqlWorker.GetDataSet("SELECT * From Class WHERE Room LIKE '" + class_list.SelectedItem.ToString() + "'");
                textBox1.Text = dataset1.Tables[0].Rows[0]["NumOfComputers"].ToString();
            }
            else
            {
                lab_check.Checked = false;
            }
            if (dataset.Tables[0].Rows[0]["HasProjector"].ToString() == "1")
            {
                projector_check.Checked = true;
            }
            else
            {
                projector_check.Checked = false;
            }

        }

        private void lab_check_CheckedChanged(object sender, EventArgs e)
        {
            if (lab_check.Checked == true)
            {
                textBox1.Visible = true;
                label2.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                label2.Visible = false;
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
