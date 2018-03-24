using System.Data.SqlClient;
using MetroFramework.Forms;
using System.Windows.Forms;
using System;

namespace _2017_BS_project9
{
    public partial class StaffInfoView : MetroForm
    {
        public StaffInfoView(Event ev)
        {
            InitializeComponent();
            this.name_lable.Text += ": " + ev.EventStaffMemeber;
            this.teaching_lable.Text += ": " + ev.ParentCourse;
            this.reception_lable.Text += ": " + ev.EventStaffMemeber.respHours;
        }        
    }
}
