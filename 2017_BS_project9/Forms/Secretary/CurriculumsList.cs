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
    public partial class CurriculumsList : MetroForm
    {
        public CurriculumsList(List<Curriculum> l_c)
        {
            InitializeComponent();
            if (l_c == null)
                return;
            foreach (Curriculum cur in l_c)
            {
                switch (cur.Semester)
                {
                    case 1:
                        foreach (Course cour in cur.Courses)
                            this.sem1.Items.Add(cour);
                        break;
                    case 2:
                        foreach (Course cour in cur.Courses)
                            this.sem2.Items.Add(cour);
                        break;
                    case 3:
                        foreach (Course cour in cur.Courses)
                            this.sem3.Items.Add(cour);
                        break;
                    case 4:
                        foreach (Course cour in cur.Courses)
                            this.sem4.Items.Add(cour);
                        break;
                    case 5:
                        foreach (Course cour in cur.Courses)
                            this.sem5.Items.Add(cour);
                        break;
                    case 6:
                        foreach (Course cour in cur.Courses)
                            this.sem6.Items.Add(cour);
                        break;
                    case 7:
                        foreach (Course cour in cur.Courses)
                            this.sem7.Items.Add(cour);
                        break;
                    case 8:
                        foreach (Course cour in cur.Courses)
                            this.sem8.Items.Add(cour);
                        break;
                }
            }
        }

        private void Show_Curriculum_Load(object sender, EventArgs e)
        {

        }

    }
}
