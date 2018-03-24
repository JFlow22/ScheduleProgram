using MetroFramework.Forms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2017_BS_project9
{
    public partial class DeleteStudent : MetroForm
    {
        public DeleteStudent(List<Student> Students_List)
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
                if (SqlWorker.DeleteStudent(selected))
                {
                    this.student_list.Items.Remove(selected);
                    MessageBox.Show("Student Removed");
                }
            }
        }
    }
}
