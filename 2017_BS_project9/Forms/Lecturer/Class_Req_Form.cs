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
    public partial class Class_Req_Form : MetroForm
    {
        private User person;
        public Class_Req_Form()
        {
            InitializeComponent();
            person = Globals._session;
        }

        private void Practitioner_Class_Req_Form_Load(object sender, EventArgs e)
        {
            int Count = 0;
            
            DataSet dataset;
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string CourseName="";
            DataSet dataset1 = SqlWorker.GetDataSet("SELECT * From Users WHERE id='" + this.person.ID.ToString() + "'");
            string Id = dataset1.Tables[0].Rows[0]["id"].ToString();
            ID.Text = Id;
            if (person is Practitioner) {
                dataset = SqlWorker.GetDataSet("SELECT * From Courses WHERE Practitioner LIKE '" + this.person.ID.ToString() + "'");
                label2.Text = "Practitioner ID: ";
            }
            else
            {
                Lab.Visible = false;
                dataset = SqlWorker.GetDataSet("SELECT * From Courses WHERE Lecturer LIKE '" + this.person.ID.ToString() + "'");
                label2.Text = "Lecturer ID: ";
            }
            while (dataset.Tables[0].Rows.Count > Count)
            {
                CourseName = dataset.Tables[0].Rows[Count]["CourseName"].ToString();
                Course.Items.Add(CourseName);
                Count++;
            }

        }

        private void Insert_Request_Click(object sender, EventArgs e)
        {
            
            int ProjectorC = 0, LabC = 0;
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (person is Practitioner){
                if (Projector.Checked == true)
                    ProjectorC = 1;
                if (Lab.Checked == true)
                    LabC = 1;
            }
            else
            {
                if (Projector.Checked == true)
                   ProjectorC = 1;
                LabC = -1;
                    
            }

            switch(SqlWorker.setClassRequest(person.ID.ToString(), Course.SelectedItem.ToString(), ProjectorC, LabC))
            {
                case 0:
                    MessageBox.Show("invalid input!.", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 1:
                    MessageBox.Show("Adding has succeeded!", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;

                case 2:
                    MessageBox.Show("updating has succeeded!", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;

            }


        }
    }
}
