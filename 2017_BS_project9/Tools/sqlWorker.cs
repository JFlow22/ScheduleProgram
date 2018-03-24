using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;

namespace _2017_BS_project9
{
    public static class SqlWorker
    {
        public static DataTable GetUsersList()
        {
            SqlConnection sConn = new SqlConnection(Globals.connString);
            DataSet Data = new DataSet();
            SqlDataAdapter da;
            SqlCommandBuilder cmdBuilder;


            List<User> users_list = new List<User>();

            //Set the connection string of the SqlConnection object to connect
            //to the SQL Server database in which you created the sample
            //table.

            try { sConn.Open(); }
            catch (Exception ex) { throw ex; }

            //Initialize the SqlDataAdapter object by specifying a Select command 
            //that retrieves data from the sample table.
            da = new SqlDataAdapter("SELECT * FROM USERS ORDER BY ID", sConn);
            //Initialize the SqlCommandBuilder object to automatically generate and initialize
            //the UpdateCommand, InsertCommand, and DeleteCommand properties of the SqlDataAdapter.
            cmdBuilder = new SqlCommandBuilder(da);

            //Populate the DataSet by running the Fill method of the SqlDataAdapter.
            da.Fill(Data, "USERS");
            //Close the database connection.
            sConn.Close();

            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = Data.Tables["USERS"].Columns["id"];
            Data.Tables["USERS"].PrimaryKey = keyColumns;

            return Data.Tables["USERS"];
        }

        public static int getRoomEq(string room)
        {
            using (SqlConnection sConn = new SqlConnection(Globals.connString))
            {
                try
                {
                    sConn.Open();
                    try
                    {
                        string query = "SELECT NumOfComputers FROM Class Where Room like '" + room + "'";
                        SqlCommand sqlCmd = new SqlCommand(query, sConn);
                        SqlDataReader sReader = sqlCmd.ExecuteReader();
                        if (sReader.Read())
                            return (int)sReader["NumOfComputers"];
                        else
                        {

                            sReader.Close();
                            throw new Exception("Room not found!");
                        }
                    }
                    catch (Exception ex) { throw ex; }
                }
                catch (Exception ex) { throw ex; }
            }
        }

        public static User FB_Exists(string facebook_id)
        {
            User result = null;
            using (SqlConnection sConn = new SqlConnection(Globals.connString))
            {
                try
                {
                    sConn.Open();

                    string query = "SELECT * FROM Users WHERE facebook_id like '" + facebook_id + "'";
                    SqlCommand sqlCmd = new SqlCommand(query, sConn);
                    SqlDataReader sReader = sqlCmd.ExecuteReader();

                    if (sReader.Read())
                        result = GetUser(sReader["id"].ToString());
                }
                catch (Exception ex) { throw ex; }
            }
            return result;
        }

        public static bool DeleteStudent(Student selected)
        {
            using (SqlConnection sConn = new SqlConnection(Globals.connString))
            {
                try
                {
                    sConn.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM Users Where ID="+ selected.ID, sConn))
                    {
                        command.ExecuteNonQuery();
                    }
                    sConn.Close();
                    return true;
                }
                catch (Exception ex) { throw ex; }
            }
        }

        public static Event GetLect(string evID)
        {
            Event ev = new Event();
            ev.ID = int.Parse(evID);
            using (SqlConnection sConn = new SqlConnection(Globals.connString))
            {
                string query = "SELECT * FROM Lecture WHERE ID=" + ev.ID;
                SqlCommand sqlCmd = new SqlCommand(query, sConn);

                try
                {
                    sConn.Open();
                    try
                    {
                        SqlDataReader sReader = sqlCmd.ExecuteReader();
                        if (sReader.Read())
                        {
                            ev.EventType = "Lecture";
                            ev.EventStaffMemeber = (StaffMemeber)GetUser(sReader["Lecturer"].ToString());
                            ev.ParentCourse = GetCoures(sReader["CourseName"].ToString());
                            ev.StartTime = int.Parse((sReader["StartTime"].ToString().Split(':'))[0]);
                            ev.EndTime = int.Parse((sReader["EndTime"].ToString().Split(':'))[0]);
                            ev.Day = int.Parse(sReader["Day"].ToString());
                            ev.Room = sReader["Class"].ToString();
                            
                        }
                        sReader.Close();
                    }
                    catch (Exception ex) { throw ex; }
                }
                catch (Exception ex) { throw ex; }
            }
            return ev;
        }

        public static List<Student> GetAllStudents()
        {
            List<Student> Students_List = new List<Student>();

            using (SqlConnection sConn = new SqlConnection(Globals.connString))
            {
                string query = "SELECT * FROM Users WHERE Type like 'Student'";
                SqlCommand sqlCmd = new SqlCommand(query, sConn);

                try
                {
                    sConn.Open();
                    try
                    {
                        SqlDataReader sReader = sqlCmd.ExecuteReader();
                        while (sReader.Read())
                        {
                            Student stud = GetUser(sReader["id"].ToString()) as Student;
                            foreach (string lect in stud.ActiveLects.Split(','))
                            {
                                if (lect == "")
                                    continue;
                                stud.ActiveEventsList.Add(GetEvent(lect));
                            }

                            foreach (string lect in stud.ActivePracLabs.Split(','))
                            {
                                if (lect == "")
                                    continue;
                                stud.ActiveEventsList.Add(GetEvent(lect));
                            }

                            Students_List.Add(stud);

                        }
                        sReader.Close();
                    }
                    catch (Exception ex) { throw ex; }
                }
                catch (Exception ex) { throw ex; }
            }

            return Students_List;
        }

        public static Event GetPracLabs(string evID)
        {
            Event ev = new Event();
            ev.ID = int.Parse(evID);
            using (SqlConnection sConn = new SqlConnection(Globals.connString))
            {
                string query = "SELECT * FROM TeachingExercises WHERE ID=" + ev.ID;
                SqlCommand sqlCmd = new SqlCommand(query, sConn);

                try
                {
                    sConn.Open();
                    try
                    {
                        SqlDataReader sReader = sqlCmd.ExecuteReader();
                        if (sReader.Read())
                        {
                            ev.EventType = sReader["type"].ToString();
                            ev.EventStaffMemeber = (StaffMemeber)GetUser(sReader["Practitioner"].ToString());
                            ev.ParentCourse = GetCoures(sReader["CourseName"].ToString());
                            ev.StartTime = int.Parse((sReader["StartTime"].ToString().Split(':'))[0]);
                            ev.EndTime = int.Parse((sReader["EndTime"].ToString().Split(':'))[0]);
                            ev.Day = int.Parse(sReader["Day"].ToString());
                            ev.Room = sReader["Class"].ToString();

                        }
                        sReader.Close();
                    }
                    catch (Exception ex) { throw ex; }
                }
                catch (Exception ex) { throw ex; }
            }
            return ev;
        }

        public static List<Event> GetLabs(Course crs)
        {
            List<Event> practs = new List<Event>();

            using (SqlConnection sConn = new SqlConnection(Globals.connString))
            {
                string query = "SELECT * FROM TeachingExercises " +
                    " WHERE CourseName LIKE '" + crs.Name + "'" +
                    " and type like 'Lab'";
                SqlCommand sqlCmd = new SqlCommand(query, sConn);

                try
                {
                    sConn.Open();
                    try
                    {
                        SqlDataReader sReader = sqlCmd.ExecuteReader();
                        while (sReader.Read())
                        {
                            Event ev = new Event();
                            ev.EventType = "Lab";
                            //ev.EventStaffMemeber = crs.Lecturer;

                            ev.ParentCourse = crs;
                            ev.ID = (int)sReader["ID"];
                            if (GetUser(sReader["Practitioner"].ToString()) != null)
                            {
                                StaffMemeber sf = new StaffMemeber(GetUser(sReader["Practitioner"].ToString()));
                                ev.EventStaffMemeber = sf;
                            }
                            ev.StartTime = int.Parse((sReader["StartTime"].ToString().Split(':'))[0]);
                            ev.EndTime = int.Parse((sReader["EndTime"].ToString().Split(':'))[0]);
                            ev.Day = int.Parse(sReader["Day"].ToString());
                            ev.Room = sReader["Class"].ToString();

                            practs.Add(ev);
                        }
                        sReader.Close();
                    }
                    catch (Exception ex) { throw ex; }
                }
                catch (Exception ex) { throw ex; }
            }
            return practs;
        }

        public static List<Event> GetPracts(Course crs)
        {
            List<Event> practs = new List<Event>();

            using (SqlConnection sConn = new SqlConnection(Globals.connString))
            {
                string query = "SELECT * FROM TeachingExercises " +
                    " WHERE CourseName LIKE '" + crs.Name + "'" +
                    " and type like 'Practice'";
                SqlCommand sqlCmd = new SqlCommand(query, sConn);

                try
                {
                    sConn.Open();
                    try
                    {
                        SqlDataReader sReader = sqlCmd.ExecuteReader();
                        while (sReader.Read())
                        {
                            Event ev = new Event();
                            ev.EventType = "Practice";
                            //ev.EventStaffMemeber = sReader["name"];

                            ev.ParentCourse = crs;
                            ev.ID = (int)sReader["ID"];
                            if(GetUser(sReader["Practitioner"].ToString())!=null)
                            {
                                StaffMemeber sf = new StaffMemeber(GetUser(sReader["Practitioner"].ToString()));
                                ev.EventStaffMemeber = sf;
                            }
                            ev.StartTime = int.Parse((sReader["StartTime"].ToString().Split(':'))[0]);
                            ev.EndTime = int.Parse((sReader["EndTime"].ToString().Split(':'))[0]);
                            ev.Day = int.Parse(sReader["Day"].ToString());
                            ev.Room = sReader["Class"].ToString();

                            practs.Add(ev);
                        }
                        sReader.Close();
                    }
                    catch (Exception ex) { throw ex; }
                }
                catch (Exception ex) { throw ex; }
            }
            return practs;
        }

        /// <summary>
        /// After saving a curriculum, clear all students active courses.
        /// IRL, There are no curriculum changes in mid year.
        /// </summary>
        public static void ClearCurr()
        {
            List<Student> list = GetAllStudents();
            foreach (Student stud in list)
            {
                stud.ActiveLects = "";
                stud.ActivePracLabs = "";
                SaveUser(stud);
            }
        }

        public static List<StaffMemeber> GetAllLecturers()
        {
            List<StaffMemeber> list = new List<StaffMemeber>();
            using (SqlConnection sConn = new SqlConnection(Globals.connString))
            {
                string query = "SELECT * FROM Users";
                SqlCommand sqlCmd = new SqlCommand(query, sConn);
                try
                {
                    sConn.Open();
                    SqlDataReader sReader = sqlCmd.ExecuteReader();
                    while (sReader.Read())
                    {
                        StaffMemeber temp = new StaffMemeber();
                        if (sReader["Type"].ToString() == "Lecturer")
                        {
                            temp.Name = sReader["Name"].ToString();
                            temp.ID = sReader["ID"].ToString();
                            list.Add(temp);
                        }
                    }
                }
                catch (Exception ex) { throw ex; }
            }
            return list;
        }

        public static List<Course> GetStudentCourses(StaffMemeber staff)
        {
            List<Course> list = new List<Course>();
            using (SqlConnection sConn = new SqlConnection(Globals.connString))
            {
                string query = "SELECT * FROM Courses";
                SqlCommand sqlCmd = new SqlCommand(query, sConn);
                try
                {
                    sConn.Open();
                    SqlDataReader sReader = sqlCmd.ExecuteReader();
                    while (sReader.Read())
                    {
                        if (sReader["Lecturer"].ToString() ==  staff.ID)
                        {
                            Course temp = new Course();
                            temp.ID = (int)sReader["CourseID"];
                            temp.Name = sReader["CourseName"].ToString();
                            temp.Lecturer = new StaffMemeber();
                            temp.Lecturer.Name = staff.Name;
                            temp.Must = (Boolean)sReader["Must"];
                            if ((int)sReader["NumOfPractices"] > 0)
                                temp.haveprac = true;
                            else temp.haveprac = false;
                            if ((int)sReader["NumOfLabs"] > 0)
                                temp.havelab = true;
                            else temp.havelab = false;
                            list.Add(temp);
                        }
                    }
                }
                catch (Exception ex) { throw ex; }
            }
            return list;
        }

        public static bool LimitAmountOfStu(int lim, string CourseName)
        {
            string query;
            if (lim < 20)
            {
                return false;
            }
            else
            {
                query = "update Courses set MaxStudent=" + lim + " WHERE CourseName LIKE '" + CourseName + "'";
                try
                {
                    SqlWorker.ExecuteQueries(query);
                }
                catch (Exception ex) { throw ex; }
                return true;
            }
        }

        public static int setClassRequest(string id,string CourseName,int proj_s ,int lab_s)
        {
           DataSet d = SqlWorker.GetDataSet("SELECT TeacherId FROM ClassRequest WHERE TeacherId = '" + id + "' AND CourseName LIKE '" + CourseName + "'");

            string query;
            try
            {
                if (d.Tables[0].Rows.Count == 0)
                {
                    query = "INSERT INTO ClassRequest(TeacherId,CourseName,Projector,Lab) VALUES('" + id + "','" + CourseName + "','" + proj_s + "','" + lab_s + "')";
                    SqlWorker.ExecuteQueries(query);
                    return 1;
                }
                else
                {
                    query = "UPDATE ClassRequest SET Projector = '" + proj_s + "' ,Lab = '" + lab_s + "' WHERE TeacherId = '" + id + "' AND CourseName LIKE '" + CourseName + "'";
                    SqlWorker.ExecuteQueries(query);
                    return 2;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SetCurriculum(Curriculum curr)
        {
            SqlConnection sConn = new SqlConnection(Globals.connString);
            DataSet Data = new DataSet();
            SqlDataAdapter da;
            SqlCommandBuilder cmdBuilder;

            //Set the connection string of the SqlConnection object to connect
            //to the SQL Server database in which you created the sample
            //table.

            try { sConn.Open(); }
            catch (Exception ex) { throw ex; }

            //Initialize the SqlDataAdapter object by specifying a Select command 
            //that retrieves data from the sample table.
            da = new SqlDataAdapter("SELECT * FROM Curriculum WHERE semester_id=" + curr.Semester, sConn);

            //Initialize the SqlCommandBuilder object to automatically generate and initialize
            //the UpdateCommand, InsertCommand, and DeleteCommand properties of the SqlDataAdapter.
            cmdBuilder = new SqlCommandBuilder(da);

            //Populate the DataSet by running the Fill method of the SqlDataAdapter.
            da.Fill(Data, "DATA");
            Data.Tables["DATA"].Rows[0]["Courses"] = "";
            foreach (Course crs in curr.Courses)
            {
                Data.Tables["DATA"].Rows[0]["Courses"] += crs.Name + ",";
            }

            da.Update(Data, "DATA");
            //Close the database connection.
            sConn.Close();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        public static bool AddStudent(Student student)
        {
            SqlConnection sConn = new SqlConnection(Globals.connString);
            DataSet Data = new DataSet();
            SqlDataAdapter da;
            SqlCommandBuilder cmdBuilder;

            //Set the connection string of the SqlConnection object to connect
            //to the SQL Server database in which you created the sample
            //table.

            try { sConn.Open(); }
            catch (Exception ex) { throw ex; }

            //Initialize the SqlDataAdapter object by specifying a Select command 
            //that retrieves data from the sample table.
            da = new SqlDataAdapter("SELECT * FROM USERS", sConn);

            //Initialize the SqlCommandBuilder object to automatically generate and initialize
            //the UpdateCommand, InsertCommand, and DeleteCommand properties of the SqlDataAdapter.
            cmdBuilder = new SqlCommandBuilder(da);

            //Populate the DataSet by running the Fill method of the SqlDataAdapter.
            da.Fill(Data, "USERS");

            // New row
            DataRow studentNewRow = Data.Tables["USERS"].NewRow();
            //Modify the value of the CustName field.
            studentNewRow["name"] = student.Name;
            studentNewRow["pwd"] = student.Pwd;
            studentNewRow["id"] = student.ID;
            studentNewRow["type"] = "Student";
            studentNewRow["sem_count"] = student.SemCount;
            studentNewRow["constraints"] = student.Constraints;
            // add student
            Data.Tables["USERS"].Rows.Add(studentNewRow);

            //Post the data modification to the database.
            da.Update(Data, "USERS");
            //Close the database connection.
            sConn.Close();

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        public static bool SaveUser(User user)
        {
            SqlConnection sConn = new SqlConnection(Globals.connString);
            DataSet Data = new DataSet();
            SqlDataAdapter da;
            SqlCommandBuilder cmdBuilder;

            //Set the connection string of the SqlConnection object to connect
            //to the SQL Server database in which you created the sample
            //table.

            try { sConn.Open(); }
            catch (Exception ex) { throw ex; }

            //Initialize the SqlDataAdapter object by specifying a Select command 
            //that retrieves data from the sample table.
            da = new SqlDataAdapter("SELECT * FROM USERS WHERE ID=" + user.ID, sConn);

            //Initialize the SqlCommandBuilder object to automatically generate and initialize
            //the UpdateCommand, InsertCommand, and DeleteCommand properties of the SqlDataAdapter.
            cmdBuilder = new SqlCommandBuilder(da);

            //Populate the DataSet by running the Fill method of the SqlDataAdapter.
            da.Fill(Data, "USERS");

            //Modify the value of the CustName field.
            Data.Tables["USERS"].Rows[0]["name"] = user.Name;
            Data.Tables["USERS"].Rows[0]["type"] = user.Type;
            Data.Tables["USERS"].Rows[0]["pwd"] = user.Pwd;
            Data.Tables["USERS"].Rows[0]["id"] = user.ID;
            Data.Tables["USERS"].Rows[0]["facebook_id"] = user.FB_ID;


            if (user.Type == "Student")
            {
                //Modify the value of the CustName field.
                Data.Tables["USERS"].Rows[0]["sem_count"] = ((Student)user).SemCount;
                Data.Tables["USERS"].Rows[0]["constraints"] = ((Student)user).Constraints;
                Data.Tables["USERS"].Rows[0]["activeLects"] = ((Student)user).ActiveLects;
                Data.Tables["USERS"].Rows[0]["activePracLabs"] = ((Student)user).ActivePracLabs;
                Data.Tables["USERS"].Rows[0]["PassedCourses"] = ((Student)user).PassedCourses;
            }

            //Post the data modification to the database.
            da.Update(Data, "USERS");

            //Close the database connection.
            sConn.Close();

            return true;
            
        }

        public static string GetCurriculumString(int semester)
        {
            string coursesString;
            using (SqlConnection sConn = new SqlConnection(Globals.connString))
            {
                string query = "SELECT courses FROM Curriculum WHERE semester_id=@semester_id";
                SqlCommand sqlCmd = new SqlCommand(query, sConn);
                sqlCmd.Parameters.AddWithValue("@semester_id", semester);

                try {
                    sConn.Open();
                    try
                    {
                        SqlDataReader sReader = sqlCmd.ExecuteReader();
                        if (sReader.Read())
                        {
                            coursesString = sReader["courses"].ToString();
                            coursesString = coursesString.Trim();
                            sConn.Close();
                            sReader.Close();
                            return coursesString;
                        }
                        else
                            throw new Exception("Curriculum for semester " + semester + " did not found");
                        
                    }
                    catch (Exception ex) { throw ex; }
                }
                catch (Exception ex) { throw ex; }
            }
        }

        public static Course GetCoures(string couresName)
        {
            if (couresName == "")
                return null;
            Course crs = null;
            using (SqlConnection sConn = new SqlConnection(Globals.connString))
            {
                // WWWTTTTFFFFF?!?!!?!?!?!?!? WHY ANOTHER TABLE!?!?!?!?!?!?!?!?!?!?
                string query = "SELECT * FROM Courses WHERE CourseName='" + couresName + "'";
                SqlCommand sqlCmd = new SqlCommand(query, sConn);

                try
                {
                    sConn.Open();
                    try
                    {
                        SqlDataReader sReader = sqlCmd.ExecuteReader();
                        if (sReader.Read())
                        {
                            crs = new Course();
                            crs.Name = sReader["CourseName"].ToString();
                            crs.MaxCap = (int)sReader["MaxStudent"];
                            crs.ID = (int)sReader["CourseID"];
                            crs.PreReq = GetPreCourse(couresName);
                            crs.Lecturer = (StaffMemeber)GetUser(sReader["Lecturer"].ToString());
                            crs.Practitioner = (StaffMemeber)GetUser(sReader["Practitioner"].ToString());

                            // TODO crs type
                            crs.Must = true ? sReader["Must"].ToString().Equals("True") : false;
                            // get min events count
                            if (sReader["NumOfLectures"] != null && (int)sReader["NumOfLectures"] > 0)
                                crs.EventsCount++;
                            if (sReader["NumOfPractices"] != null && (int)sReader["NumOfPractices"] > 0)
                                crs.EventsCount++;
                            if (sReader["NumOfLabs"] != null && (int)sReader["NumOfLabs"] > 0)
                                crs.EventsCount++;

                        }
                        sReader.Close();
                    }
                    catch (Exception ex) { throw ex; }
                }
                catch (Exception ex) { throw ex; }
            }
            return crs;
        }

        private static string GetPreCourse(string couresName)
        {
            string preReq = "";
            using (SqlConnection sConn = new SqlConnection(Globals.connString))
            {
                string query = "Select PreCourse from PreCourses Where Course='" + couresName + "'";
                SqlCommand sqlCmd = new SqlCommand(query, sConn);

                try
                {
                    sConn.Open();
                    try
                    {
                        SqlDataReader sReader = sqlCmd.ExecuteReader();
                        while (sReader.Read())
                            preReq += sReader["PreCourse"].ToString() + ",";
                        sReader.Close();
                    }
                    catch (Exception ex) { throw ex; }
                }
                catch (Exception ex) { throw ex; }
            }
            return preReq;
        }

        public static List<Course> GetAllCourses()
        {
            List<Course> coursesList = new List<Course>();

            using (SqlConnection sConn = new SqlConnection(Globals.connString))
            {
                string query = "select * from Courses";
                SqlCommand sqlCmd = new SqlCommand(query, sConn);

                try
                {
                    sConn.Open();
                    SqlDataReader sReader = sqlCmd.ExecuteReader();
                    while (sReader.Read())
                    {
                        Course crs = new Course();
                        crs.ID = (int)sReader["CourseID"];
                        crs.Name = sReader["CourseName"].ToString();
                        crs.Must = true ? sReader["Must"].ToString().Equals("True") : false;
                        crs.Lecturer = (StaffMemeber)GetUser(sReader["Lecturer"].ToString());
                        crs.Practitioner = (StaffMemeber)GetUser(sReader["Practitioner"].ToString());
                        coursesList.Add(crs);
                    }

                    sConn.Close();

                }
                catch (Exception ex) { throw ex; }

                // get events fro each course
                foreach(Course crs in coursesList)
                {
                    crs.LectEventsList = GetLects(crs);
                    crs.PractEventsList = GetPracts(crs);
                    crs.LabsEventsList = GetLabs(crs);
                }
            }

            return coursesList;
        }

        public static List<Event> GetLects(Course crs)
        {
            List<Event> lects = new List<Event>();

            using (SqlConnection sConn = new SqlConnection(Globals.connString))
            {
                string query = "SELECT * FROM Lecture WHERE CourseName LIKE '" + crs.Name + "'";
                SqlCommand sqlCmd = new SqlCommand(query, sConn);

                try
                {
                    sConn.Open();
                    try
                    {
                        SqlDataReader sReader = sqlCmd.ExecuteReader();
                        while (sReader.Read())
                        {
                            Event ev = new Event();
                            ev.EventType = "Lecture";
                            ev.CurrentCap = (int)sReader["AmountOfStudents"];
                            ev.EventStaffMemeber = crs.Lecturer;
                            ev.ParentCourse = crs;
                            ev.ID = (int)sReader["ID"];
                            ev.StartTime = int.Parse((sReader["StartTime"].ToString().Split(':'))[0]);
                            ev.EndTime = int.Parse(((sReader["EndTime"].ToString()).Split(':'))[0]);
                            ev.Day = int.Parse(sReader["Day"].ToString());
                            ev.Room = sReader["Class"].ToString();

                            // before getting info, check if needed
                            if (Globals._session != null)
                                // we have a logged in student
                                if (Globals._session.GetType().Name.Equals("Student"))
                                {
                                    //we have a student, check capacity in event vs cap in course
                                    if ((int)sReader["AmountOfStudents"] >= crs.MaxCap)
                                        // can't show.
                                        ev.Full = true;
                                    else
                                        ev.Full = false;
                                }

                            lects.Add(ev);
                        }
                        sReader.Close();
                    }
                    catch (Exception ex) { throw ex; }
                }
                catch (Exception ex) { throw ex; }
            }
            return lects;
        }

        public static Event GetLects(string id)
        {
            using (SqlConnection sConn = new SqlConnection(Globals.connString))
            {
                string query = "SELECT * FROM Lecture WHERE ID=" + id;
                SqlCommand sqlCmd = new SqlCommand(query, sConn);

                try
                {
                    sConn.Open();
                    try
                    {
                        SqlDataReader sReader = sqlCmd.ExecuteReader();
                        if (sReader.Read())
                        {
                            Event ev = new Event();
                            ev.EventType = "Lecture";
                            ev.ID = (int)sReader["ID"];
                            ev.StartTime = int.Parse((sReader["StartTime"].ToString().Split(':'))[0]);
                            ev.EndTime = int.Parse(((sReader["EndTime"].ToString()).Split(':'))[0]);
                            ev.Day = int.Parse(sReader["Day"].ToString());

                            ev.Room = sReader["Class"].ToString();
                            ev.ParentCourse = GetCoures(sReader["courseName"].ToString());
                            ev.EventStaffMemeber = ev.ParentCourse.Lecturer;

                            return ev;
                        }
                        sReader.Close();
                    }
                    catch (Exception ex) { throw ex; }
                }
                catch (Exception ex) { throw ex; }
            }
            return null;
        }

        public static Event GetEvent(string evID)
        {
            Event ev = GetLects(evID);
            if (ev != null) return ev;
            else ev = GetPracLabs(evID);
            if (ev != null) return ev;

            return null;
        }

        public static User GetUser(string id)
        {
            User result = null;
            using (SqlConnection sConn = new SqlConnection(Globals.connString))
            {
                try
                {
                    sConn.Open();

                    string query = "SELECT * FROM Users WHERE ID=" + id;
                    SqlCommand sqlCmd = new SqlCommand(query, sConn);
                    SqlDataReader sReader = sqlCmd.ExecuteReader();

                    if (sReader.Read())
                    {
                        switch (sReader["TYPE"].ToString())
                        {
                            case "Student":
                                result = new Student();
                                (result as Student).SemCount = (int)sReader["sem_count"];
                                (result as Student).Constraints = sReader["constraints"].ToString();
                                // get active courses and events
                                (result as Student).ActiveLects = sReader["activeLects"].ToString();
                                (result as Student).ActivePracLabs = sReader["activePracLabs"].ToString();
                                (result as Student).PassedCourses = sReader["passedCourses"].ToString();
                                // generate one
                                (result as Student).Curriculum = new Curriculum((result as Student).SemCount);
                                if ((result as Student).Curriculum == null)
                                    throw new Exception("Curriculum not found in DB! (Curriculum is null)");
                                break;
                            case "Secretary":
                                result = new Secretary();
                                break;
                            case "Lecturer":
                                result = new Lecturer();
                                (result as StaffMemeber).respHours = sReader["AccHours"].ToString();
                                break;
                            case "HeadOfDep":
                                result = new Head_Of_Dep();
                                break;
                            case "Practitioner":
                                result = new Practitioner();
                                (result as StaffMemeber).respHours = sReader["AccHours"].ToString();
                                break;
                            case "HouseKeeper":
                                result = new House_keeper();
                                break;
                            default:
                                throw new Exception("Type: " + sReader["TYPE"].ToString() + "Is undefind!");
                        }

                        result.Name = sReader["name"].ToString();
                        result.Pwd = sReader["pwd"].ToString();
                        result.ID = sReader["id"].ToString();
                        result.Type = sReader["type"].ToString();
                    }
                    else return null;
                }
                catch (Exception ex) { throw ex; }
            }
            return result;
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static int getWorkHours(int id, bool option, int day)
        {
            SqlConnection sConn = new SqlConnection(Globals.connString);
            sConn.Open();
            if (option == false)
            {
                DataSet ds;
                if (day > 6 || day < 1)
                    ds = GetDataSet("Select * From Lecture Where Lecturer='" + id + "'");
                else
                    ds = GetDataSet("Select * From Lecture Where Lecturer='" + id + "' AND Day='" + day + "'");
                if (ds.Tables[0].Rows.Count == 0)
                {
                    sConn.Close();
                    return 0;
                }
                else
                {
                    int sum = 0;
                    string duration, course;
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        course = ds.Tables[0].Rows[i]["CourseName"].ToString();
                        duration = GetDataSet("Select * From Courses Where CourseName='" + course + "'").Tables[0].Rows[0]["LectureDuration"].ToString();
                        sum += Convert.ToInt32(duration);
                    }
                    sConn.Close();
                    return sum;
                }
            }
            else
            {
                DataSet ds;
                if (day > 6 || day < 1)
                    ds = GetDataSet("Select * From TeachingExercises Where Practitioner='" + id + "'");
                else
                    ds = GetDataSet("Select * From TeachingExercises Where Practitioner='" + id + "' AND Day='" + day + "'");
                if (ds.Tables[0].Rows.Count == 0)
                {
                    sConn.Close();
                    return 0;
                }
                else
                {
                    int sum = 0;
                    string duration, type, course;
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        type = ds.Tables[0].Rows[i]["Type"].ToString();
                        course = ds.Tables[0].Rows[i]["CourseName"].ToString();
                        if (type == "Lab")
                            type = "LabDuration";
                        else
                            type = "PracticeDuration";
                        duration = GetDataSet("Select * From Courses Where CourseName='" + course + "'").Tables[0].Rows[0][type].ToString();
                        sum += Convert.ToInt32(duration);
                    }
                    sConn.Close();
                    return sum;
                }
            }

        }

        public static DataSet GetDataSet(string query)
        {
            SqlConnection sConn = new SqlConnection(Globals.connString);
            sConn.Open();
            SqlCommand cmd = new SqlCommand(query, sConn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataSet set = new DataSet();
            dr.Fill(set);
            sConn.Close();
            return set;
        }

        //Get name by id
        public static string getNameById(string id)
        {
            DataSet ds = GetDataSet("SELECT * From Users WHERE ID='" + id + "'");
            if (ds.Tables[0].Rows.Count == 0)
                return null;
            return ds.Tables[0].Rows[0]["Name"].ToString();
        }

        //Check if course exists by course name
        public static bool checkCourseExistence(string name)
        {
            DataSet ds = GetDataSet("SELECT * From Courses WHERE CourseName='" + name + "'");
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            return true;
        }

        public static bool addCourse(string name, string lecturerID, string practitionerID, string lectureDuration, string practiceDuration,
                               string labDuration, bool must)
        {
            string sqlString = "INSERT into Courses (CourseName,Lecturer,Practitioner,MaxStudent,LectureDuration,PracticeDuration,LabDuration,Must) Values ('"
                + name + "','" + lecturerID + "','" + practitionerID + "',20,";
            //Convert the durations to int
            int lectureDur = Int32.Parse(lectureDuration.Substring(0, 1));
            sqlString += lectureDur.ToString() + ",";
            if (practiceDuration != null)
            {
                int practiceDur = Int32.Parse(practiceDuration.Substring(0, 1));
                sqlString += practiceDur.ToString() + ",";
            }
            else
                sqlString += "NULL,";
            if (labDuration != null)
            {
                int labDur = Int32.Parse(labDuration.Substring(0, 1));
                sqlString += labDur.ToString() + ",";
            }
            else
                sqlString += "NULL,";
            if (must == true)
                sqlString += "1)";
            else
                sqlString += "0)";

            SqlConnection sConn = new SqlConnection(Globals.connString);
            sConn.Open();
            SqlCommand cmd = new SqlCommand(sqlString, sConn);
            cmd.ExecuteNonQuery();
            sConn.Close();
            return true;
        }



        //Add pre course
        //0 - already exists
        //1 - opposite exists
        //2 - operation successfull
        public static int addPreCourse(string preCourse, string course)
        {
            //Check if the pre course is already a pre course of the course
            DataSet ds = SqlWorker.GetDataSet("SELECT * from PreCourses where PreCourse='" + preCourse + "' and course='" + course + "'");
            if (ds.Tables[0].Rows.Count != 0)
                return 0;
            ds = SqlWorker.GetDataSet("SELECT * from PreCourses where PreCourse='" + course + "' and course='" + preCourse + "'");
            if (ds.Tables[0].Rows.Count != 0)
                return 1;
            SqlConnection sConn = new SqlConnection(Globals.connString);
            sConn.Open();
            SqlCommand cmd = new SqlCommand("Insert into PreCourses Values('" + preCourse + "','" + course + "')", sConn);
            cmd.ExecuteNonQuery();
            sConn.Close();
            return 2;
        }


        public static int getAmountOfLecturers()
        {
            DataSet ds = SqlWorker.GetDataSet("Select * FROM Users WHERE type='Lecturer'");
            return ds.Tables[0].Rows.Count;
        }

        public static int getAmountOfPractitioners()
        {
            DataSet ds = SqlWorker.GetDataSet("Select * FROM Users WHERE type='Practitioner'");
            return ds.Tables[0].Rows.Count;
        }

        //Execture query
        public static void ExecuteQueries(string query)
        {
            SqlConnection sConn = new SqlConnection(Globals.connString);
            sConn.Open();
            SqlCommand cmd = new SqlCommand(query, sConn);
            cmd.ExecuteNonQuery();
            sConn.Close();
        }
    }
}
