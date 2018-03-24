using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MetroFramework.Controls;
using System.Drawing.Printing;

namespace _2017_BS_project9
{
    public partial class ScheduleWeekView : MetroForm
    {
        private static int padding = 5;
        private Student currentStudent;
        private PrintDocument printWeek = new PrintDocument();
        Bitmap memoryImage;

        /// <summary>
        /// generate student shcedule grid
        /// </summary>
        public ScheduleWeekView(Student currentStudent)
        {
            InitializeComponent();
            this.schdeulerWeeklyGrid.buildGrid();


            // if not in test mode (not input student)
            if (currentStudent == null)
            {
                // take global stuednt
                this.currentStudent = (Student)Globals._session;
                // if global without built curriculum
                if (this.currentStudent.Curriculum == null)
                    // generate one
                    this.currentStudent.Curriculum = new Curriculum(this.currentStudent.SemCount);       
            } else
                // test mode, use input
                this.currentStudent = currentStudent;

            printWeek.PrintPage += new PrintPageEventHandler(printDay_PrintPage);
            printWeek.DefaultPageSettings.Landscape = true;

        }

        public void showConstraints(){
            if (currentStudent.Constraints != null)
            {
                string[] constraints = currentStudent.Constraints.Split(';');
                foreach (string constrain in constraints)
                {
                    if (constrain == "")
                        continue;
                    MatchCollection match = Regex.Matches(constrain, @"[0-9]+");
                    int col = int.Parse(match[0].ToString());
                    int row = int.Parse(match[1].ToString());
                    Rectangle rec = this.schdeulerWeeklyGrid.GetCellDisplayRectangle(col, row,true);

                    MetroTile c = new MetroTile();
                    c.Name = "const_" + col + "_" + row;
                    c.Location = rec.Location;
                    c.Size = rec.Size;
                    c.Enabled = false;
                    c.Style = MetroFramework.MetroColorStyle.Orange;

                    this.warpper.Controls.Add(c);
                    c.BringToFront();
                    c.Show();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void Build()
        {            
            // build active list
            buildActiveList();
            setEventsButtons(currentStudent.ActiveEventsList);
        }

        /// <summary>
        /// Set buttons for events
        /// </summary>
        /// <param name="EventsList"></param>
        private void setEventsButtons(List<Event> EventsList)
        {
            if (EventsList == null)
                return;
            // now for each event we need to set btn location, size and etc
            // first add all active Events
            foreach (Event ev in EventsList)
            {
                // calc column
                int evCol = ev.Day;
                // calc starting row
                int evStartRow = ev.StartTime - Globals.StartHour;
                // calc end row
                int evEndRow = ev.EndTime - Globals.StartHour;
                // now get rectangel  representring btn X and Y starting pos
                Rectangle rec = this.schdeulerWeeklyGrid.GetCellDisplayRectangle(evCol, evStartRow, true);
                // calc btn range
                rec.Height *= evEndRow - evStartRow;
                /**/

                // applay padding (we like bea-utiful GUI
                rec.X += padding;
                rec.Y += padding;
                rec.Width -= 2 * padding;
                rec.Height -= 2 * padding;

                // create btn
                EventButton btn = new EventButton(ev);
                btn.Name = "ev_" + ev.ID;
                btn.Text = ev.btn_txt();
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
                // set location
                btn.Location = rec.Location;
                // set size
                btn.Size = rec.Size;
                /// add it to the list
                btn.Style = MetroFramework.MetroColorStyle.Green;
                // add to controlers
                this.warpper.Controls.Add(btn);
                btn.Show();
                btn.BringToFront();
            }
        }
       

        private void StudentScheduler_Load(object sender, EventArgs e)
        {
            showConstraints();
            Build();
        }

        internal void buildActiveList()
        {
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

        private void CaptureScreen()
        {
            Graphics myGraphics = this.schdeulerWeeklyGrid.CreateGraphics();
            Size s = this.schdeulerWeeklyGrid.Size;
            Point loc = (this.schdeulerWeeklyGrid as Control).PointToScreen(Point.Empty);
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(loc.X, loc.Y, 0, 0, s);
        }
        private void printDay_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printWeek.Print();
        }
    }
}
