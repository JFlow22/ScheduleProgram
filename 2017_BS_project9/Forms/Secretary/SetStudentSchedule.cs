using MetroFramework.Forms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2017_BS_project9
{
    public partial class SetStudentSchedule : MetroForm
    {
        public SetStudentSchedule(List<Student> Students_List)
        {
            InitializeComponent();

            if (Students_List != null)
            {
                foreach(Student student in Students_List)
                {
                    this.student_list.Items.Add(student);
                }
            }
        }

        public void set_schedule_Click(object sender, System.EventArgs e)
        {
            Student selected = (Student)this.student_list.SelectedItem;
            if (selected != null)
            {
                Form form = new StudentScheduler(selected);
                form.Show();
            }
        }
    }
}
