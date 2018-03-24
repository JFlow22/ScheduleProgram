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
    public partial class SeeAvailableHoursForm : MetroForm
    {
        public SeeAvailableHoursForm()
        {
            InitializeComponent();
            Prac_lec.Text = "Choose";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Prac_lec_SelectedIndexChanged(object sender, EventArgs e)
        {
            teacher_chooser.Items.Clear();
            s1.Text = "--";
            s2.Text = "--";
            m1.Text = "--";
            m2.Text = "--";
            tu1.Text = "--";
            tu2.Text = "--";
            w1.Text = "--";
            w2.Text = "--";
            tu1.Text = "--";
            tu2.Text = "--";
            f1.Text = "--";
            f2.Text = "--";
            DataSet dataset;


            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataset = SqlWorker.GetDataSet("SELECT Name From Users WHERE Type LIKE '"+((ComboBox)sender).SelectedItem.ToString()+"'");
            for(int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                teacher_chooser.Items.Add(dataset.Tables[0].Rows[i][0]);
            }

            if(teacher_chooser.Items.Count > 0)
            {
                teacher_chooser.SelectedIndex = 0;
            }
        }

        private void teacher_chooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            s1.Text = "--";
            s2.Text = "--";
            m1.Text = "--";
            m2.Text = "--";
            tu1.Text = "--";
            tu2.Text = "--";
            w1.Text = "--";
            w2.Text = "--";
            tu1.Text = "--";
            tu2.Text = "--";
            f1.Text = "--";
            f2.Text = "--";

            DataSet dataset;
 
            int id;
  

            if (!SqlWorker.CheckForInternetConnection())
            {
                MessageBox.Show("There is no internet connection.\nPlease try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string q = "SELECT ID From Users WHERE Name like '" + teacher_chooser.SelectedItem + "'";
            dataset = SqlWorker.GetDataSet(q);

            if (dataset.Tables[0].Rows.Count == 0) return;

            id = Int32.Parse(dataset.Tables[0].Rows[0][0].ToString());

            dataset = SqlWorker.GetDataSet("SELECT Day,StartingTime,EndingTime From Constraines_PraLec WHERE TeacherId = '" + id + "'");
            for(int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                switch (dataset.Tables[0].Rows[i][0].ToString())
                {
                    case ("Sunday"):
                        s1.Text = dataset.Tables[0].Rows[i][1].ToString();
                        s2.Text = dataset.Tables[0].Rows[i][2].ToString();
                        break;

                    case ("Monday"):
                        m1.Text = dataset.Tables[0].Rows[i][1].ToString();
                        m2.Text = dataset.Tables[0].Rows[i][2].ToString();
                        break;

                    case ("Tuesday"):
                        tu1.Text = dataset.Tables[0].Rows[i][1].ToString();
                        tu2.Text = dataset.Tables[0].Rows[i][2].ToString();
                        break;

                    case ("Wednesday"):
                        w1.Text = dataset.Tables[0].Rows[i][1].ToString();
                        w2.Text = dataset.Tables[0].Rows[i][2].ToString();
                        break;

                    case ("Thursday"):
                        tu1.Text = dataset.Tables[0].Rows[i][1].ToString();
                        tu2.Text = dataset.Tables[0].Rows[i][2].ToString();
                        break;
                    case ("Friday"):
                        f1.Text = dataset.Tables[0].Rows[i][1].ToString();
                        f2.Text = dataset.Tables[0].Rows[i][2].ToString();
                        break;
                }



            }
        }
    }
}
