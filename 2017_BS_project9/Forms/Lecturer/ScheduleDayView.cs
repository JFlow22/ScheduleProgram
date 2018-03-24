using MetroFramework.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Drawing;
using MetroFramework.Controls;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace _2017_BS_project9
{
    public partial class ScheduleDayView : MetroForm
    {

        public struct constraintsStruct
        {
            public int day { get; set; }
            public List<MetroTile> hours { get; set; }
        }

        public struct dayStruct
        {
            public int day { get; set; }
            public List<EventButton> events { get; set; }
        }

        private List<constraintsStruct> constraintsList;
        private List<dayStruct> Days;
        private int selectedDay;
        private PrintDocument printDay = new PrintDocument();
        Bitmap memoryImage;
        Student currentStudent;

        public ScheduleDayView(Student currentStudent)
        {
            InitializeComponent();
            // set for testing
            if (currentStudent != null)
                this.currentStudent = currentStudent;
            else
                this.currentStudent = Globals._session as Student;

            printDay.PrintPage += new PrintPageEventHandler(printDay_PrintPage);
            printDay.DefaultPageSettings.Landscape = true;
        }

        /// <summary>
        /// init form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScheduleDayView_Load(object sender, System.EventArgs e)
        {
            this.dayGrid.buildGrid();
            // get all info
            getInfo();
            // sjow data
            selectedDay = 1;
            ShowDay(1);
        }

        private void getInfo()
        {
            LoadContraints();
            LoadEvents();
        }

        private void LoadEvents()
        {
            // init list
            Days = new List<dayStruct>();
            // init 6 structs in list
            for (int day = 1; day <= 6; day++)
            {
                dayStruct d = new dayStruct();
                d.day = day;
                d.events = new List<EventButton>();
                Days.Add(d);
            }
            // if global without built curriculum
            if (this.currentStudent.Curriculum == null)
                // generate one
                this.currentStudent.Curriculum = new Curriculum(this.currentStudent.SemCount);

            if (currentStudent.ActiveEventsList == null)
                currentStudent.ActiveEventsList = new List<Event>();

            foreach (string evID in currentStudent.ActiveLects.Split(','))
            {
                if (evID == "") continue;
                Event ev = getEvent(evID);
                if (currentStudent.ActiveEventsList.Find(f_ev => ev.ID == f_ev.ID) == null)
                    currentStudent.ActiveEventsList.Add(getEvent(evID));
            }
            foreach (string evID in currentStudent.ActivePracLabs.Split(','))
            {
                if (evID == "") continue;
                Event ev = getEvent(evID);
                if (currentStudent.ActiveEventsList.Find(f_ev => ev.ID == f_ev.ID) == null)
                    currentStudent.ActiveEventsList.Add(getEvent(evID));
            }

            foreach(Event activeEvent in currentStudent.ActiveEventsList)
            {
                EventButton ev = new EventButton(activeEvent);
                Rectangle rec = this.dayGrid.GetCellDisplayRectangle(1, activeEvent.StartTime - Globals.StartHour, true);
                ev.Name = "ev_" + activeEvent.Day;
                ev.Text = activeEvent.ParentCourse.Name + ":" + activeEvent.EventStaffMemeber.Name + "\n" + activeEvent.Room + ":" + activeEvent.EventType;
                
                int padding = 5;
                rec.X += padding;
                rec.Y += padding;
                rec.Width -= 2* padding;
                rec.Height -= padding;

                ev.Location = rec.Location;
                ev.Size = rec.Size;
                ev.Height *= activeEvent.EndTime - activeEvent.StartTime;
                ev.Enabled = false;
                ev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                ev.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                ev.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
                ev.Enabled = true;
                Days[activeEvent.Day - 1].events.Add(ev);
            }
        }

        private Event getEvent(string evID)
        {
            foreach (Course crs in currentStudent.Curriculum.Courses)
            {
                foreach (Event ev in crs.LectEventsList)
                    if (ev.ID == int.Parse(evID))
                        return ev;

                foreach (Event ev in crs.PractEventsList)
                    if (ev.ID == int.Parse(evID))
                        return ev;

                foreach (Event ev in crs.LabsEventsList)
                    if (ev.ID == int.Parse(evID))
                        return ev;
            }

            return null;
        }

        private void LoadContraints()
        {
            // init list
            constraintsList = new List<constraintsStruct>();
            // init 6 structs in list
            for (int day = 1; day <= 6; day++) {
                constraintsStruct constraint = new constraintsStruct();
                constraint.day = day;
                constraint.hours = new List<MetroTile>();
                constraintsList.Add(constraint);
            }

            // get constraints from user
            if (currentStudent.Constraints != null)
            {
                string[] constraints = currentStudent.Constraints.Split(';');
                foreach (string constrain in constraints)
                {
                    if (constrain == "")
                        continue;
                    MatchCollection match = Regex.Matches(constrain, @"[0-9]+");
                    int day = int.Parse(match[0].ToString());
                    int hour = int.Parse(match[1].ToString());
                    Rectangle rec = this.dayGrid.GetCellDisplayRectangle(1, hour, true);

                    MetroTile constraintBtn = new MetroTile();
                    constraintBtn.Name = "const_" + hour;
                    constraintBtn.Location = rec.Location;
                    constraintBtn.Size = rec.Size;
                    constraintBtn.Enabled = false;
                    constraintBtn.Style = MetroFramework.MetroColorStyle.Yellow;

                    constraintsList[day-1].hours.Add(constraintBtn);
                }
            }
        }

        private void ShowDay(int day)
        {
            selectedDay = day;
            ShowConstraints(selectedDay);
            ShowEvents(selectedDay);
        }

        private void ShowEvents(int day)
        {
            foreach (EventButton btn in Days[day - 1].events)
            {
                this.inner_warrper.Controls.Add(btn);
                btn.Show();
                btn.BringToFront();
            }
        }

        private void ShowConstraints(int day)
        {
            foreach (MetroTile btn in constraintsList[day - 1].hours)
            {
                this.inner_warrper.Controls.Add(btn);
                btn.Show();
                btn.BringToFront();
            }
        }

        private void ClearGrid()
        {
            List<Control> toRem = new List<Control>();

            foreach (Control ctrl in this.inner_warrper.Controls)
                if (ctrl.Name.Contains("const_") || ctrl.Name.Contains("ev_"))
                    toRem.Add(ctrl);

            foreach (Control ctrl in toRem)
                this.inner_warrper.Controls.Remove(ctrl);
        }

        private void metroTile1_Click(object sender, System.EventArgs e)
        {
            ClearGrid();
            ShowDay(1);
        }

        private void metroTile2_Click(object sender, System.EventArgs e)
        {
            ClearGrid();
            ShowDay(2);
        }

        private void metroTile4_Click(object sender, System.EventArgs e)
        {
            ClearGrid();
            ShowDay(3);
        }

        private void metroTile3_Click(object sender, System.EventArgs e)
        {
            ClearGrid();
            ShowDay(4);
        }

        private void metroTile5_Click(object sender, System.EventArgs e)
        {
            ClearGrid();
            ShowDay(5);
        }

        private void metroTile6_Click(object sender, System.EventArgs e)
        {
            ClearGrid();
            ShowDay(6);
        }

        private void metroTile1_Click_1(object sender, System.EventArgs e)
        {
            CaptureScreen();
            printDay.Print();
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.inner_warrper.CreateGraphics();
            Size s = this.inner_warrper.Size;
            Point loc = (this.inner_warrper as Control).PointToScreen(Point.Empty);
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(loc.X, loc.Y, 0, 0, s);
        }
        private void printDay_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
