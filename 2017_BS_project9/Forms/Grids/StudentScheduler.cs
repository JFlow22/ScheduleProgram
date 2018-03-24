using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MetroFramework.Controls;

namespace _2017_BS_project9
{
    public partial class StudentScheduler : MetroForm
    {
        private readonly int _padding = 5;


        private Student currentStudent;


        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="currentStudent"></param>
        public StudentScheduler(Student currentStudent)
        {
            InitializeComponent();
            // setup the grid
            this.schdeulerWeeklyGrid.buildGrid();

            // if not in test mode (not input student)
            if (currentStudent == null)
            {
                if ((Student)Globals._session != null)
                    // take global stuednt
                    this.currentStudent = (Student)Globals._session;
                else
                    throw new ArgumentException("No Test user argument & (Student)Globals._session is NULL", "currentStudent");
            }
            else
                // test mode, use input
                this.currentStudent = currentStudent;
        }

        /// <summary>
        /// When grid is shown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentScheduler_Shown(object sender, EventArgs e)
        {
            // to keep z-index's, showConstraints() first 
            showConstraints();
            // build active list
            rebuildActiveList();
            // gird is up, create buttons
            setEventsButtons(currentStudent.ActiveEventsList);
            // now, Show all active events that we added
            foreach (Event ev in currentStudent.ActiveEventsList)
            {
                drawEvent(ev, true);
                // add there course to the active_list
                if (!SearchCourseInComboBoxs(ev.ParentCourse))
                    this.active_courses_list.Items.Add(ev.ParentCourse);
            }
            // now we can build all the other courses
            BuildCurriculum();
        }

        private void drawEvent(Event ev, bool active)
        {
            List<Event> single_ev = new List<Event>();
            single_ev.Add(ev);
            setEventsButtons(single_ev);
            // if it's an actived event, ignore collision check.
            if (active) {
                ev.btn.Style = MetroFramework.MetroColorStyle.Green;
            } else
            {
                foreach (Control ctrl in this.warpper.Controls)
                {
                    if (ctrl.GetType().Name.Equals("EventButton"))
                    {
                        if (checkCollision(ev, (ctrl as EventButton).PraentEvent))
                        {
                            // 2 colide, draw the new one in read
                            ev.btn.Style = MetroFramework.MetroColorStyle.Red;
                            // disable save btn
                            DisableSaveBtn();

                            break;
                        }
                        else
                            ev.btn.Style = MetroFramework.MetroColorStyle.Blue;

                        // now show the btn
                        ev.btn.Show();
                        ev.btn.BringToFront();
                    }
                }
            }

            this.warpper.Controls.Add(ev.btn);
            ev.btn.Show();
            ev.btn.BringToFront();
        }

        /// <summary>
        /// check if 2 events collide
        /// </summary>
        /// <param name="ev1"></param>
        /// <param name="ev2"></param>
        /// <returns></returns>
        private bool checkCollision(Event ev1, Event ev2)
        {
            bool collision = false;
            if (ev1.Day == ev2.Day && !(ev1.EndTime <= ev2.StartTime || ev2.EndTime <= ev1.StartTime))
                collision = true;
            return collision;
        }

        /// <summary>
        /// recreate ActiveEventsList 
        /// </summary>
        private void rebuildActiveList()
        {
            currentStudent.ActiveEventsList = new List<Event>();

            // get each active event and add it to active event list after init
            foreach (string evID in currentStudent.ActiveLects.Split(','))
            {
                if (evID == "") continue;
                Event ev = getEvent(evID);
                if (currentStudent.ActiveEventsList.Find(f_ev => ev.ID == f_ev.ID) == null)
                    currentStudent.ActiveEventsList.Add(ev);
            }
            foreach (string evID in currentStudent.ActivePracLabs.Split(','))
            {
                if (evID == "") continue;
                Event ev = getEvent(evID);
                if (currentStudent.ActiveEventsList.Find(f_ev => ev.ID == f_ev.ID) == null)
                    currentStudent.ActiveEventsList.Add(ev);
            }
        }

        /// <summary>
        /// get event from curriculum by ID
        /// </summary>
        /// <param name="evID"></param>
        /// <returns></returns>
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

            // if we got here, this crs is not in the curriculum, create it
            return SqlWorker.GetEvent(evID);
        }

        /// <summary>
        /// 
        /// </summary>
        private void BuildCurriculum()
        {
            // if curriculum is empty or not init, stop
            if (currentStudent.Curriculum == null || currentStudent.Curriculum.Courses.Count == 0)
                return;

            // handle course adition
            foreach (Course crs in currentStudent.Curriculum.Courses)
            {
                bool preReq = true;
                // for each course
                // check if there are pre courses
                // IF GLOBAL USER IS A SECRETARY, SHE CAN DO WHAT SHE WANTS
                if (crs.PreReq != "")
                // if there are
                {
                    // check for each if the student passed them
                    foreach (string preCrsName in crs.PreReq.Split(','))
                    {
                        if (preCrsName == "")
                            continue;
                        // if they dont,
                        if (!currentStudent.PassedCourses.Contains(preCrsName))
                        {
                            // try to find it in curriculum
                            Course preCrs = currentStudent.Curriculum.Courses.Find(f_crs => f_crs.Name == preCrsName);
                            if (preCrs == null)
                            {
                                // not in curriculum
                                // init them and add them to the must do list
                                preCrs = SqlWorker.GetCoures(preCrsName);
                                // fill lectures
                                preCrs.LectEventsList = SqlWorker.GetLects(preCrs);
                                // fill Practice and Lab of the curse
                                preCrs.PractEventsList = SqlWorker.GetPracts(preCrs);
                                preCrs.LabsEventsList = SqlWorker.GetLabs(preCrs);
                            }
                            // do NOT add the original crs to the list
                            preReq = false;
                            // add it to the must do list if it's not there already
                            if (!SearchCourseInComboBoxs(preCrs))
                            {
                                if (preCrs.Must) this.must_do_courses_list.Items.Add(preCrs);
                                else this.can_do_courses_list.Items.Add(preCrs);
                            }
                        }
                    }
                }
                // if there are no pre courses or the student passed them all
                if ( Globals._session.Type == "Secretary" || (preReq  && !currentStudent.PassedCourses.Contains(crs.Name)))
                {
                    // add the crs based on must field
                    if (!SearchCourseInComboBoxs(crs))
                    {
                        if (crs.Must)
                            this.must_do_courses_list.Items.Add(crs);
                        else
                            this.can_do_courses_list.Items.Add(crs);
                    }
                }
            }
        }

        /// <summary>
        /// Check if a given course is already in one of the lists
        /// </summary>
        /// <param name="preCrs"></param>
        /// <returns></returns>
        private bool SearchCourseInComboBoxs(Course crs)
        {
            if (this.active_courses_list.Items.Contains(crs)) return true;
            if (this.must_do_courses_list.Items.Contains(crs)) return true;
            if (this.can_do_courses_list.Items.Contains(crs)) return true;

            if (this.active_courses_list.FindString(crs.Name) != -1) return true;
            if (this.must_do_courses_list.FindString(crs.Name) != -1) return true;
            if (this.can_do_courses_list.FindString(crs.Name) != -1) return true;

            return false;
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
                rec.X += _padding;
                rec.Y += _padding;
                rec.Width -= 2 * _padding;
                rec.Height -= 2 * _padding;

                // create btn
                ev.btn = new EventButton(ev);
                ev.btn.Name = "ev_" + ev.ID + "_" + ev.ParentCourse.Name + "_" + ev.EventType;
                ev.btn.TabIndex = ev.ID;
                ev.btn.Text = ev.btn_txt();
                ev.btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                ev.btn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
                // set location
                ev.btn.Location = new System.Drawing.Point(rec.X, rec.Y);
                // set size
                ev.btn.Size = rec.Size;
                // bind to a click INTERNAT funtion
                ev.btn.Click += Event_click;
                // def btn is hidden
                ev.btn.Hide();
            }
        }

        /// <summary>
        /// Event clicked handling
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Event_click(object sender, EventArgs e)
        {
            Form form = new StaffInfoView((sender as EventButton).PraentEvent);
            form.Show();
        }

        /// <summary>
        /// Show Student own contrains
        /// public for testing
        /// </summary>
        public void showConstraints()
        {
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
                    Rectangle rec = new Rectangle();
                    MetroTile c = new MetroTile();
                    c.Name = "const_" + col + "_" + row;
                    // if in test mode, this can not be tested. 
                    // assume success on location of the controler
                    try
                    {
                        rec = this.schdeulerWeeklyGrid.GetCellDisplayRectangle(col, row, true);
                        c.Location = rec.Location;
                    }
                    catch
                    {
                        // in test, it's enought to test existnce
                        c.Location = new Point(0, 0);
                    }

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
        /// On Active course click
        /// Delete the course
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void active_courses_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            // grab selected
            Course ToRemove = (Course)this.active_courses_list.SelectedItem;
            List<Control> EventsToRemove = new List<Control>();
            // If null selected, do nothign
            if (ToRemove == null)
                return;

            // Configure the message box to be displayed
            string messageBoxText = "Do you want to remove the course from the list?";
            string caption = "Confirme course removal";

            // show yes no q
            if (MessageBox.Show(messageBoxText, caption, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                // remove the course from active list
                // need to remove, but only to re-add back
                if (ToRemove.Must)
                    this.must_do_courses_list.Items.Add(ToRemove);
                else
                    this.can_do_courses_list.Items.Add(ToRemove);
                // find all btns on grid
                foreach (Control ctrl in this.warpper.Controls)
                {
                    if (ctrl.GetType().Name != "EventButton")
                        continue;
                    // if thats THE course btn
                    if ((ctrl as EventButton).Name.Contains(ToRemove.Name))
                    {
                        // remove the btn
                        EventsToRemove.Add(ctrl);
                        currentStudent.ActiveEventsList.Remove((ctrl as EventButton).PraentEvent);
                    }
                }


                // Remove as last step, cuz it's envoks selectedIndex change with null
                // we do not want to intturopt the original invokation
                this.active_courses_list.Items.Remove(ToRemove);

                foreach(Control ctrl in EventsToRemove)
                    this.warpper.Controls.Remove(ctrl);
                EnableSaveBtn();


            }

        }

        /// <summary>
        /// When user clicks must do course box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void must_do_courses_list_Click(object sender, EventArgs e)
        {
            // first, clear the grid
            ClearGrid();
            // second, clear events selection boxs
            ClearEventsSelection();
            // deselect can do box
            this.can_do_courses_list.ClearSelected();
            // grab selected
            Course CourseToShow = (Course)this.must_do_courses_list.SelectedItem;
            // nothing selected?
            if (CourseToShow == null)
            {
                DisableSaveBtn();
                return;
            }
            // fill da boxs!
            FillEventsBox(CourseToShow);

            // update savebtn status
            SaveBtnCallBack(CourseToShow);
        }
        /// <summary>
        /// When user clicks Can do course box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void can_do_courses_list_Click(object sender, EventArgs e)
        {
            // first, clear the grid
            ClearGrid();
            // second, clear events selection boxs
            ClearEventsSelection();
            // deselect can do box
            this.must_do_courses_list.ClearSelected();
            // grab selected
            Course CourseToShow = (Course)this.can_do_courses_list.SelectedItem;
            // nothing selected?
            if (CourseToShow == null)
            {
                DisableSaveBtn();
                return;
            }
            // fill da boxs!
            FillEventsBox(CourseToShow);
            // update savebtn status
            SaveBtnCallBack(CourseToShow);
        }

        /// <summary>
        /// Fill each Combo Box with the right events
        /// </summary>
        /// <param name="selectedCourse"></param>
        private void FillEventsBox(Course selectedCourse)
        {
            // for lectures
            foreach (Event ev in selectedCourse.LectEventsList)
            {
                // if event is not full (Max cap reached)
                if (!ev.Full)
                    this.lectures_list.Items.Add(ev);
            }
            // for practices
            foreach (Event ev in selectedCourse.PractEventsList)
            {
                if (!ev.Full)
                    this.practice_list.Items.Add(ev);
            }
            // for labs
            foreach (Event ev in selectedCourse.LabsEventsList)
            {
                if (!ev.Full)
                    this.labs_list.Items.Add(ev);
            }
        }


        /// <summary>
        /// remove all courses events from combox boxs
        /// </summary>
        private void ClearEventsSelection()
        {
            this.labs_list.Items.Clear();
            this.lectures_list.Items.Clear();
            this.practice_list.Items.Clear();
        }

        /// <summary>
        /// clear all NON active event on the grid
        /// </summary>
        private void ClearGrid()
        {
            List<Control> Remove = new List<Control>();
            /** clear grid every change in selection */
            foreach (Control btn in this.warpper.Controls)
                // it's an event btn and it's NOT in active list?
                if (btn.Name.Contains("ev_") && currentStudent.ActiveEventsList.Find(ev => ev.btn == btn) == null)
                    Remove.Add(btn);

            foreach (Control ctrl in Remove)
                this.warpper.Controls.Remove(ctrl);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lectures_list_Click(object sender, EventArgs e)
        {
            // grab selected
            Event EventToShow = (Event)this.lectures_list.SelectedItem;
            // nothing selected?
            if (EventToShow == null)
                return;

            // clear course lectures
            ClearSpecificNamedEvents(EventToShow.EventType);

            // save btn callback
            SaveBtnCallBack(EventToShow.ParentCourse);
            // now, show it's btn
            drawEvent(EventToShow,false);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void practice_list_Click(object sender, EventArgs e)
        {
            // grab selected
            Event EventToShow = (Event)this.practice_list.SelectedItem;
            // nothing selected?
            if (EventToShow == null)
                return;

            // clear course lectures
            ClearSpecificNamedEvents(EventToShow.EventType);

            // save btn callback
            SaveBtnCallBack(EventToShow.ParentCourse);
            // now, show it's btn
            drawEvent(EventToShow, false);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labs_list_Click(object sender, EventArgs e)
        {
            // grab selected
            Event EventToShow = (Event)this.labs_list.SelectedItem;
            // nothing selected?
            if (EventToShow == null)
                return;

            // clear course lectures
            ClearSpecificNamedEvents(EventToShow.EventType);

            // save btn callback
            SaveBtnCallBack(EventToShow.ParentCourse);
            // now, show it's btn
            drawEvent(EventToShow, false);
        }

        /// <summary>
        /// Check every time user selects an event from the combobox
        /// if all events types of the coruse are selected, enable the btn
        /// </summary>
        private void SaveBtnCallBack(Course crs)
        {
            int EventsTypesCount = 0;
            int SelectedBoxsCount = 0;
            // get events types count
            if (crs.LectEventsList.Count > 0) EventsTypesCount++;
            if (crs.PractEventsList.Count > 0) EventsTypesCount++;
            if (crs.LabsEventsList.Count > 0) EventsTypesCount++;

            // now, check how many box's are with a selected item
            if (this.lectures_list.SelectedItem != null) SelectedBoxsCount++;
            if (this.practice_list.SelectedItem != null) SelectedBoxsCount++;
            if (this.labs_list.SelectedItem != null) SelectedBoxsCount++;

            if (EventsTypesCount == SelectedBoxsCount)
            {
                EnableSaveBtn();
            } else
            {
                DisableSaveBtn();
            }

        }

        private void DisableSaveBtn()
        {
            this.save_event_grp.Enabled = false;
            this.save_event_grp.Style = MetroFramework.MetroColorStyle.White;
        }

        private void EnableSaveBtn()
        {
            this.save_event_grp.Enabled = true;
            this.save_event_grp.Style = MetroFramework.MetroColorStyle.Green;
        }

        private void ClearSpecificNamedEvents(string name)
        {
            List<Control> RemoveList = new List<Control>();
            /** clear grid every change in selection */
            foreach (Control ctrl in this.warpper.Controls) {
                // if and only if that an event btn AND BTN's EVENT NOT IN ACTIVE LIST
                if (ctrl.GetType().Name.Equals("EventButton") && currentStudent.ActiveEventsList.Find(ev => ev.btn == ctrl) == null)
                {
                    if ((ctrl as EventButton).Name.Contains(name))
                        RemoveList.Add(ctrl);
                }
            }
            foreach(Control ctrl in RemoveList)
                this.warpper.Controls.Remove(ctrl);
        }

        private void save_event_grp_Click(object sender, EventArgs e)
        {
            // grab all fields
            Event SelectedLect = (Event)this.lectures_list.SelectedItem;
            Event SelectedPract = (Event)this.practice_list.SelectedItem;
            Event SelectedLab = (Event)this.labs_list.SelectedItem;

            // add the events to Student active events list
            if (SelectedLect != null)
            {
                currentStudent.ActiveEventsList.Add(SelectedLect);
                SelectedLect.btn.Style = MetroFramework.MetroColorStyle.Green;
            }
            //else throw new Exception("A course without a Lecture?!");
            if (SelectedPract != null)
            {
                currentStudent.ActiveEventsList.Add(SelectedPract);
                SelectedPract.btn.Style = MetroFramework.MetroColorStyle.Green;
            }
            if (SelectedLab != null)
            {
                currentStudent.ActiveEventsList.Add(SelectedLab);
                SelectedLab.btn.Style = MetroFramework.MetroColorStyle.Green;
            }

            // update Student fields
            currentStudent.ActiveLects = "";
            currentStudent.ActivePracLabs = "";
            foreach (Event ev in currentStudent.ActiveEventsList)
            {
                switch (ev.EventType)
                {
                    case "Lecture":
                        currentStudent.ActiveLects += ev.ID + ",";
                        break;
                    case "Practice":
                    case "Lab":
                        currentStudent.ActivePracLabs += ev.ID + ",";
                        break;
                }
            }

            // update DB
            if (SqlWorker.SaveUser(currentStudent))
                MessageBox.Show("Course saved!");

            // add ONLY the course to the ACTIVE box.
            if (SelectedLect != null && SelectedLect.ParentCourse != null)
            {
                this.active_courses_list.Items.Add(SelectedLect.ParentCourse);

                // remove the ocurse from it's original box
                if (SelectedLect.ParentCourse.Must) this.must_do_courses_list.Items.Remove(SelectedLect.ParentCourse);
                else this.can_do_courses_list.Items.Remove(SelectedLect.ParentCourse);
            }
            // clear all selections when done
            this.must_do_courses_list.ClearSelected();
            this.can_do_courses_list.ClearSelected();
            ClearEventsSelection();
            DisableSaveBtn();
        }
    }
}
