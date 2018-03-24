using MetroFramework.Forms;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017_BS_project9.Forms
{
    public partial class ChoosePrcForm : MetroForm
    {
        private User l;

        public ChoosePrcForm()
        {
            InitializeComponent();
            l = Globals._session;
            courses_combo.Items.Clear();
           
        }

        private void ChoosePrcForm_Load(object sender, EventArgs e)
        {
   
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            DataSet dataset;
            int count = 0;
            dataset = SqlWorker.GetDataSet("SELECT CourseName From Courses WHERE Lecturer=" + l.ID.ToString() + "");
            for(int i=0;i<dataset.Tables[0].Rows.Count; i++)
            { 
                courses_combo.Items.Add(dataset.Tables[0].Rows[i][0]);
                count++;
            }

            dataset = SqlWorker.GetDataSet("SELECT Name From Users WHERE Type LIKE 'Practitioner'");
            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                PrcList.Items.Add(dataset.Tables[0].Rows[i][0]);
                count++;
            }
            PrcList.Sorted = true;
            courses_combo.Sorted = true;

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            //check
            if(PrcList.CheckedItems.Count > 3)
            {
                MessageBox.Show("You can not choose more then 3 practitioners!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (PrcList.CheckedItems.Count == 0)
            {
                MessageBox.Show("You need to choose at least one practitoner!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (courses_combo.SelectedIndex == -1)
            {
                MessageBox.Show("You need to choose a course!", "Error"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //do
            DataSet dataset;
            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataset = SqlWorker.GetDataSet("SELECT CourseId From Courses WHERE CourseName like '" + courses_combo.SelectedItem.ToString() + "'");
            String cid = dataset.Tables[0].Rows[0][0].ToString();

            dataset = SqlWorker.GetDataSet("SELECT LecturerId From PracReq WHERE LecturerId = '" + l.ID.ToString() + "' AND CourseId = '" + cid + "'");
            if (dataset.Tables[0].Rows.Count == 0)
            {
                string sqlstring = "INSERT INTO PracReq(LecturerId,Prc1,Prc2,Prc3,CourseId) VALUES('" + l.ID.ToString() + "',";
                for (int i = 0; i < 3; i++)
                {
                    if (i < PrcList.CheckedItems.Count)
                        sqlstring += "'" + PrcList.CheckedItems[i].ToString() + "'";
                    else
                        sqlstring += "NULL";
                    if (i != 2)
                        sqlstring += ",";
                }
                sqlstring += ",'" + cid + "')";
                SqlWorker.GetDataSet(sqlstring);
                MessageBox.Show("The request added!", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;

            }else{

                string sqlstring = "UPDATE PracReq SET ";
                for (int i = 0; i < 3; i++)
                {
                    sqlstring += "Prc" + (i+1) +" = ";
                    if (i < PrcList.CheckedItems.Count)
                        sqlstring += "'"+ PrcList.CheckedItems[i] + "'";
                    else
                        sqlstring += "NULL";

                    if (i != 2)
                        sqlstring += ", ";

                }
                sqlstring += " WHERE LecturerId = '" + l.ID.ToString() + "' AND CourseId = '" + cid + "'";
                SqlWorker.GetDataSet(sqlstring);
                MessageBox.Show("The request updated!", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
