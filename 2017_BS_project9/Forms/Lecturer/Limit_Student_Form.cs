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
    
    public partial class Limit_Student_Form : MetroForm
    {
        private User person;
        private string cn;
        public Limit_Student_Form()
        {
            person = Globals._session;
            InitializeComponent();
            
        }

        private void course_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Enabled = false;
            nmax.Enabled = true;
            cn  = ((ComboBox)sender).SelectedItem.ToString();
            DataSet dataset;

            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataset = SqlWorker.GetDataSet("SELECT MaxStudent From Courses WHERE CourseName LIKE '" + cn + "'");
            cmax.Text = dataset.Tables[0].Rows[0][0].ToString();
            this.Enabled = true;


        }

        private void Limit_Student_Form_Load(object sender, EventArgs e)
        {
            int Count = 0;
            
 
            DataSet dataset;
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string CourseName = "";

            if (person is Practitioner)
            {
                dataset = SqlWorker.GetDataSet("SELECT * From Courses WHERE Practitioner LIKE '" + this.person.ID.ToString() + "'");
               
            }
            else
            {

                dataset = SqlWorker.GetDataSet("SELECT * From Courses WHERE Lecturer LIKE '" + this.person.ID.ToString() + "'");
                
            }

            while (dataset.Tables[0].Rows.Count > Count)
            {
                CourseName = dataset.Tables[0].Rows[Count]["CourseName"].ToString();
                course_name.Items.Add(CourseName);
                Count++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int lim;

            if (IsDigitsOnly(nmax.Text)) {
                 lim = Int32.Parse(nmax.Text);
            }
            else
            {
                MessageBox.Show("invalid input!", "Error"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SqlWorker.LimitAmountOfStu(lim, cn))
            {
                MessageBox.Show("Update has succeeded!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("student limit must be at least 20!", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
