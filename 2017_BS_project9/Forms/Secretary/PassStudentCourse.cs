using MetroFramework.Forms;
using System;
using System.Collections;
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
    public partial class PassStudentCourse : MetroForm
    {
        private List<Student> StudentsList;
        
        public PassStudentCourse(List<Student> list)
        {
            InitializeComponent();
            this.StudentsList = list;
        } 

        public void PassStudentCourse_Load(object sender, EventArgs e)
        {
            this.student_list.Items.AddRange(this.StudentsList.ToArray());
        }

        public void student_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList dupClear = new ArrayList();
            courses_list.Items.Clear();
            for (int sem_count = 1; sem_count <= ((Student)this.student_list.SelectedItem).Curriculum.Semester; sem_count++)
            {
                Curriculum CURRENT_CURR = new Curriculum(sem_count);
                foreach (Course crs in CURRENT_CURR.Courses)
                {
                    if (((Student)this.student_list.SelectedItem).PassedCourses.Contains(crs.Name.ToString()))
                        continue;
                    if (!dupClear.Contains(crs))
                        dupClear.Add(crs);
                }
            }
            

            //if (((Student)this.student_list.SelectedItem).ActiveEventsList != null)
            //{
            //    foreach (Event ev in ((Student)this.student_list.SelectedItem).ActiveEventsList)
            //    {
            //        if (!dupClear.Contains(ev.ParentCourse))
            //            dupClear.Add(ev.ParentCourse);
            //    }
            //}
            this.courses_list.Items.AddRange(dupClear.ToArray());
        }

        public void pass_btn_Click(object sender, EventArgs e)
        {
            Boolean Flag;
            string ACtiveLects="";
            if (this.student_list.SelectedItem != null && this.courses_list.SelectedItem != null)
            {
                ((Student)this.student_list.SelectedItem).PassedCourses += ((Course)this.courses_list.SelectedItem).Name + ",";
                string [] ev = ((Student)this.student_list.SelectedItem).ActiveLects.Split(',');
                 for (int i = 0; i < ev.Length; i++)
                    {
                        Flag = true;
                        foreach (Event eve in ((Course)this.courses_list.SelectedItem).LectEventsList)
                          if (eve.ID.ToString() == ev[i] && ev[i]!="")
                            Flag = false;
                    if (Flag && ev[i] != "")
                        ACtiveLects += ev[i] + ',';
                }
                ((Student)this.student_list.SelectedItem).ActiveLects = ACtiveLects;


                ACtiveLects = "";
                ev = ((Student)this.student_list.SelectedItem).ActivePracLabs.Split(',');
                for (int i = 0; i < ev.Length; i++)
                {
                    Flag = true;
                    foreach (Event eve in ((Course)this.courses_list.SelectedItem).PractEventsList)
                        if (eve.ID.ToString() == ev[i] && ev[i] != "")
                            Flag = false;
                    if (Flag && ev[i] != "")
                        ACtiveLects += ev[i] + ',';
                }
                ((Student)this.student_list.SelectedItem).ActivePracLabs = ACtiveLects;


                ACtiveLects = "";
                ev = ((Student)this.student_list.SelectedItem).ActivePracLabs.Split(',');
                for (int i = 0; i < ev.Length; i++)
                {
                    Flag = true;
                    foreach (Event eve in ((Course)this.courses_list.SelectedItem).LabsEventsList)
                        if (eve.ID.ToString() == ev[i] && ev[i] != "")
                            Flag = false;
                    if (Flag && ev[i] != "")
                        ACtiveLects += ev[i] + ',';
                }
                ((Student)this.student_list.SelectedItem).ActivePracLabs = ACtiveLects;


                SqlWorker.SaveUser((Student)this.student_list.SelectedItem);
                this.courses_list.Items.Remove(this.courses_list.SelectedItem);
                MessageBox.Show("Course passed successfuly!");
            }
        }
    }
}
