using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2017_BS_project9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _2017_BS_project9.Tests
{
    [TestClass()]
    public class SqlWorkerTests
    {
        [TestMethod()]
        public void GetUsersListTest()
        {
            DataTable testGetUsersList = null;
            // get data to test
            try
            {
                testGetUsersList = SqlWorker.GetUsersList();
            } catch
            {
                Assert.Fail();
            }
            

            // per data to test against
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

            DataColumnCollection columns = Data.Tables["USERS"].Columns;

            // testing
            for (int row = 0; row < Data.Tables["USERS"].Rows.Count; row++)
            {
                DataRow data = Data.Tables["USERS"].Rows[row];
                DataRow test = testGetUsersList.Rows[row];
                foreach (DataColumn col in columns)
                    Assert.AreEqual(data[col.ToString()], test[col.ToString()]);
            }
        }

        [TestMethod()]
        public void getRoomEqTest()
        {
           int rooms = SqlWorker.getRoomEq("F110");


            using (SqlConnection sConn = new SqlConnection(Globals.connString))
            {
                try
                {
                    sConn.Open();
                    try
                    {
                        string query = "SELECT NumOfComputers FROM Class Where Room like '" + "F110" + "'";
                        SqlCommand sqlCmd = new SqlCommand(query, sConn);
                        SqlDataReader sReader = sqlCmd.ExecuteReader();
                        if (sReader.Read())
                            Assert.AreEqual((int)sReader["NumOfComputers"], rooms);
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
        

        [TestMethod()]
        public void FB_ExistsTest()
        {
            // untestable, user may vary
            Assert.Inconclusive();
        }

        [TestMethod()]
        public void DeleteStudentTest()
        {
            Student newStud = new Student("123123","Test Student","1","Student");
            SqlWorker.AddStudent(newStud);
            SqlWorker.DeleteStudent(newStud);

            Assert.IsNull(SqlWorker.GetUser(newStud.ID));
        }

        [TestMethod()]
        public void GetLectTest()
        {
            DataSet dt = SqlWorker.GetDataSet("SELECT * FROM Lecture");
            DataRow dr = null;
            if (dt.Tables[0].Rows.Count > 0)
                dr = dt.Tables[0].Rows[0];

            Event ev = SqlWorker.GetLect(dr["id"].ToString());

            Assert.IsTrue(ev.ID == int.Parse(dr["id"].ToString()));
            Assert.IsTrue(ev.Day == int.Parse(dr["Day"].ToString()));
            Assert.IsTrue(ev.EndTime == int.Parse(dr["EndTime"].ToString().Split(':')[0]));
            Assert.IsTrue(ev.StartTime == int.Parse(dr["StartTime"].ToString().Split(':')[0]));
        }

        [TestMethod()]
        public void GetAllStudentsTest()
        {
            List<Student> TestList = SqlWorker.GetAllStudents();

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
                            Student stud = SqlWorker.GetUser(sReader["id"].ToString()) as Student;
                            foreach (string lect in stud.ActiveLects.Split(','))
                            {
                                if (lect == "")
                                    continue;
                                stud.ActiveEventsList.Add(SqlWorker.GetEvent(lect));
                            }

                            foreach (string lect in stud.ActivePracLabs.Split(','))
                            {
                                if (lect == "")
                                    continue;
                                stud.ActiveEventsList.Add(SqlWorker.GetEvent(lect));
                            }

                            Students_List.Add(stud);

                        }
                        sReader.Close();
                    }
                    catch (Exception ex) { throw ex; }
                }
                catch (Exception ex) { throw ex; }
            }

            foreach (Student stud in Students_List)
            {
                Assert.IsTrue(TestList.Find(f_stud => stud.Name == f_stud.Name) != null);
                Assert.IsTrue(TestList.Find(f_stud => stud.ID == f_stud.ID) != null);
                Assert.IsTrue(TestList.Find(f_stud => stud.PassedCourses == f_stud.PassedCourses) != null);
                Assert.IsTrue(TestList.Find(f_stud => stud.Type == f_stud.Type) != null);
            }

        }

        [TestMethod()]
        public void GetPracLabsTest()
        {
            DataSet dt = SqlWorker.GetDataSet("SELECT * FROM TeachingExercises");
            DataRow dr = null;
            if (dt.Tables[0].Rows.Count > 0)
                dr = dt.Tables[0].Rows[0];

            Event ev = SqlWorker.GetPracLabs(dr["id"].ToString());

            Assert.IsTrue(ev.ID == int.Parse(dr["id"].ToString()));
            Assert.IsTrue(ev.Day == int.Parse(dr["Day"].ToString()));
            Assert.IsTrue(ev.EndTime == int.Parse(dr["EndTime"].ToString().Split(':')[0]));
            Assert.IsTrue(ev.StartTime == int.Parse(dr["StartTime"].ToString().Split(':')[0]));
            Assert.IsTrue(ev.EventType == dr["Type"].ToString());
        }
    }
}