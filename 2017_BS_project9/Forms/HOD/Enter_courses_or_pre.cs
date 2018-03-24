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
    public partial class Enter_courses_or_pre : MetroForm
    {

        //Ctor
        public Enter_courses_or_pre()
        {
            InitializeComponent();
        }

        //Open new add form in case the add new course button was pressed
        private void new_course_button_Click(object sender, EventArgs e)
        {
            Add_new_course add_form = new Add_new_course();
            this.Hide();
            add_form.ShowDialog();
            this.Show();
        }

        //Open new set pre course form in case the set pre course button was pressed
        private void set_pre_course_button_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Set_pres_courses set = new Set_pres_courses();
            set.ShowDialog();
            this.Enabled = true;

        }
    }
}
