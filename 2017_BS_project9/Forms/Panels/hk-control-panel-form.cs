using MetroFramework.Forms;
using _2017_BS_project9;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace _2017_BS_project9
{
    public partial class HouseKeeperControlPanelForm : MetroForm
    {
        List<Curriculum> CurriculumsList;
        int[] SemEqCount;
        int[] WeekEqCount;

        public HouseKeeperControlPanelForm()
        {
            InitializeComponent();
            // if user has a facebook login, hide the btn
            if (Globals._session.FB_ID != null)
                this.facebook_login_btn.Hide();

            CurriculumsList = new List<Curriculum>();
            SemEqCount = new int[Globals.MaxSem];
            WeekEqCount = new int[Globals.MaxDay];
            BuildList();
        }

        private void BuildList()
        {
            for (int curr = 1; curr <= Globals.MaxSem; curr++)
                CurriculumsList.Add(new Curriculum(curr));

            foreach (Curriculum curr in CurriculumsList)
            {
                foreach (Course crs in curr.Courses)
                {
                    foreach (Event ev in crs.LectEventsList)
                    {
                        int num = SqlWorker.getRoomEq(ev.Room);
                        if (num == 0)
                            continue;
                        SemEqCount[curr.Semester - 1] += num;
                        WeekEqCount[ev.Day - 1] += num;
                        ev.Equpment = num;
                        this.ev_list.Items.Add(ev);
                    }

                    foreach (Event ev in crs.PractEventsList)
                    {
                        int num = SqlWorker.getRoomEq(ev.Room);
                        if (num == 0)
                            continue;
                        SemEqCount[curr.Semester] += num;
                        WeekEqCount[ev.Day] += num;
                        ev.Equpment = num;
                        this.ev_list.Items.Add(ev);
                    }

                    foreach (Event ev in crs.LabsEventsList)
                    {
                        int num = SqlWorker.getRoomEq(ev.Room);
                        if (num == 0)
                            continue;
                        SemEqCount[curr.Semester] += num;
                        WeekEqCount[ev.Day] += num;
                        ev.Equpment = num;
                        this.ev_list.Items.Add(ev);
                    }
                }
            }


            setSemTilesText();
            setWeekTilesText();
        }

        private void setWeekTilesText()
        {
            this.day_1_tile.Text = WeekEqCount[0].ToString();
            this.day_2_tile.Text = WeekEqCount[1].ToString();
            this.day_3_tile.Text = WeekEqCount[2].ToString();
            this.day_4_tile.Text = WeekEqCount[3].ToString();
            this.day_5_tile.Text = WeekEqCount[4].ToString();
            this.day_6_tile.Text = WeekEqCount[5].ToString();
        }

        private void setSemTilesText()
        {
            
            this.sem_1_tile.Text = SemEqCount[0].ToString();
            this.sem_2_tile.Text = SemEqCount[1].ToString();
            this.sem_3_tile.Text = SemEqCount[2].ToString();
            this.sem_4_tile.Text = SemEqCount[3].ToString();
            this.sem_5_tile.Text = SemEqCount[4].ToString();
            this.sem_6_tile.Text = SemEqCount[5].ToString();
            this.sem_7_tile.Text = SemEqCount[6].ToString();
            this.sem_8_tile.Text = SemEqCount[7].ToString();
        }

        private void HouseKeeperControlPanelForm_Load(object sender, System.EventArgs e)
        {

        }

        private void ev_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Event ev = (Event)this.ev_list.SelectedItem;
            if (ev != null)
            {
                this.ev_day_txt.Text = ev.Day.ToString();
                this.ev_time_txt.Text = ev.StartTime + ":00 - " + ev.EndTime + ":00";
                this.eve_room_txt.Text = ev.Room.ToString();
                this.ev_eq_txt.Text = ev.Equpment.ToString();
            }
        }

        private void facebook_login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Globals._session.FB_ID = this.facebook_login_btn.getLoginData()["id"];
                if (Globals._session.FB_ID != null && Globals._session.FB_ID != "")
                    if (SqlWorker.SaveUser(Globals._session))
                    {
                        MessageBox.Show("User Was Connected To Facebook seccessfuly!");
                        this.Close();
                    }
            }catch
            {
                MessageBox.Show("Login with Facebook Failded!\n Please try again!");
            }
        }
    }
}
