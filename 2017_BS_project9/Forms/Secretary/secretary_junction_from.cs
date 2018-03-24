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
    public partial class secretary_junction_from : MetroForm
    {
        public secretary_junction_from()
        {
            InitializeComponent();
            userNameLable.Text = "Welcome, " + Globals._session.Name;
        }

        private void info_btn_Click(object sender, System.EventArgs e)
        {
            UserInfoEditor form = new UserInfoEditor(ref this.userNameLable, null);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecretarySchduleStudetnsForm cpanel = new SecretarySchduleStudetnsForm();
            cpanel.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecretarySchduleStaffForm cpanel = new SecretarySchduleStaffForm();
            cpanel.ShowDialog();
            this.Show();
        }
    }
}
