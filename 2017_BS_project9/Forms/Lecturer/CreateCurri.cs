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
    public partial class CreateCurri : MetroForm
    {
        Curriculum[] sm;

        public CreateCurri(List<Course> l_c)
        {
            InitializeComponent();

            String[] arr = new String[8];
            sm = new Curriculum [8];   
            for (int i = 0; i < 8; i++)
            {
                sm[i] = new Curriculum();
                sm[i].Courses = new List<Course>();
                string[] words = SqlWorker.GetCurriculumString(i + 1).Split(',');
                foreach (string word in words)
                {
                    if (word == "")
                        continue;
                    Course temp = l_c.Find(crs => crs.Name == word);
                    sm[i].Courses.Add(temp);
                }
            }
            foreach (Course cur in this.sm[0].Courses)
            {
                if (cur == null)
                    continue;
                this.semester_list_box.Items.Add(cur);
            }

            foreach (Course cur in l_c)
            {
                Boolean flag = true;
                for (int i = 0; i < 8; i++)
                    if (sm[i].Courses != null)
                    {
                        foreach (Course c in sm[i].Courses)
                            if (cur.Name == c.Name)
                                flag = false;
                    }
                if(flag)
                   this.courses_list_box.Items.Add(cur);
            }

            this.add_btn.Enabled = false;
            this.rem_btn.Enabled = false;
            this.rem_btn.BackColor = Color.Gray;
            this.add_btn.BackColor = Color.Gray;
        }



        private void courses_list_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.courses_list_box.SelectedItem == null)
                return;
            this.rem_btn.Enabled = false;
            this.rem_btn.BackColor = Color.Gray;
            this.add_btn.Enabled = true;
            this.add_btn.BackColor = Color.Green;

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (this.courses_list_box.SelectedItem == null)
                return;
            this.semester_list_box.Items.Add((Course)this.courses_list_box.SelectedItem);
            switch ((int)this.select_semester.Value)
            {
                case 1:
                    this.sm[0].Courses.Add((Course)this.courses_list_box.SelectedItem);
                    break;
                case 2:
                    this.sm[1].Courses.Add((Course)this.courses_list_box.SelectedItem);
                    break;
                case 3:
                    this.sm[2].Courses.Add((Course)this.courses_list_box.SelectedItem);
                    break;
                case 4:
                    this.sm[3].Courses.Add((Course)this.courses_list_box.SelectedItem);
                    break;
                case 5:
                    this.sm[4].Courses.Add((Course)this.courses_list_box.SelectedItem);
                    break;
                case 6:
                    this.sm[5].Courses.Add((Course)this.courses_list_box.SelectedItem);
                    break;
                case 7:
                    this.sm[6].Courses.Add((Course)this.courses_list_box.SelectedItem);
                    break;
                case 8:
                    this.sm[7].Courses.Add((Course)this.courses_list_box.SelectedItem);
                    break;
            }
            if (this.courses_list_box.SelectedItem != null)
                this.courses_list_box.Items.Remove(this.courses_list_box.SelectedItem);
            this.add_btn.Enabled = false;
            this.add_btn.BackColor = Color.Gray;
        }

        private void select_semester_ValueChanged(object sender, EventArgs e)
        {
            this.semester_list_box.Items.Clear();
            switch ((int)this.select_semester.Value)
            {
                case 1:
                    if (this.sm[0].Courses != null)
                        foreach (Course cur in this.sm[0].Courses)
                        {
                            this.semester_list_box.Items.Add(cur);
                        }
                    break;
                case 2:
                    if (this.sm[1].Courses != null)
                        foreach (Course cur in this.sm[1].Courses)
                        {
                            this.semester_list_box.Items.Add(cur);
                        }
                    break;
                case 3:
                    if (this.sm[2].Courses != null)
                        foreach (Course cur in this.sm[2].Courses)
                        {
                            this.semester_list_box.Items.Add(cur);
                        }
                    break;
                case 4:
                    if (this.sm[3].Courses != null)
                        foreach (Course cur in this.sm[3].Courses)
                        {
                            this.semester_list_box.Items.Add(cur);
                        }
                    break;
                case 5:
                    if (this.sm[4].Courses != null)
                        foreach (Course cur in this.sm[4].Courses)
                        {
                            this.semester_list_box.Items.Add(cur);
                        }
                    break;
                case 6:
                    if (this.sm[5].Courses != null)
                        foreach (Course cur in this.sm[5].Courses)
                        {
                            this.semester_list_box.Items.Add(cur);
                        }
                    break;
                case 7:
                    if (this.sm[6].Courses != null)
                        foreach (Course cur in this.sm[6].Courses)
                        {
                            this.semester_list_box.Items.Add(cur);
                        }
                    break;
                case 8:
                    if (this.sm[7].Courses != null)
                        foreach (Course cur in this.sm[7].Courses)
                        {
                            this.semester_list_box.Items.Add(cur);
                        }
                    break;
            }
        }

        private void semester_list_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.semester_list_box.SelectedItem == null)
                return;
            this.rem_btn.Enabled = true;
            this.rem_btn.BackColor = Color.Red;
            this.add_btn.Enabled = false;
            this.add_btn.BackColor = Color.Gray;
        }

        private void rem_btn_Click(object sender, EventArgs e)
        {
            if (this.semester_list_box.SelectedItem == null)
                return;
            this.courses_list_box.Items.Add((Course)this.semester_list_box.SelectedItem);
            switch ((int)this.select_semester.Value)
            {
                case 1:
                    this.sm[0].Courses.Remove((Course)this.semester_list_box.SelectedItem);
                    break;
                case 2:
                    this.sm[1].Courses.Remove((Course)this.semester_list_box.SelectedItem);
                    break;
                case 3:
                    this.sm[2].Courses.Remove((Course)this.semester_list_box.SelectedItem);
                    break;
                case 4:
                    this.sm[3].Courses.Remove((Course)this.semester_list_box.SelectedItem);
                    break;
                case 5:
                    this.sm[4].Courses.Remove((Course)this.semester_list_box.SelectedItem);
                    break;
                case 6:
                    this.sm[5].Courses.Remove((Course)this.semester_list_box.SelectedItem);
                    break;
                case 7:
                    this.sm[6].Courses.Remove((Course)this.semester_list_box.SelectedItem);
                    break;
                case 8:
                    this.sm[7].Courses.Remove((Course)this.semester_list_box.SelectedItem);
                    break;
            }
            this.semester_list_box.Items.Remove(this.semester_list_box.SelectedItem);
            this.rem_btn.Enabled = false;
            this.rem_btn.BackColor = Color.Gray;
        }

        private void saveBT_Click(object sender, EventArgs e)
        {
            for(int i =0;i<8;i++)
            {
                sm[i].Semester = i + 1;
                SqlWorker.SetCurriculum(sm[i]);
            }
            MessageBox.Show("Saved Secc!");
            SqlWorker.ClearCurr();
            this.Close();
        }
    }

    
}
