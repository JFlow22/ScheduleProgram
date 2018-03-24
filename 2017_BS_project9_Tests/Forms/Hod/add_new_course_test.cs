using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;
using static System.Windows.Forms.Control;
using MetroFramework.Controls;
using System.Data;

namespace _2017_BS_project9
{
    /// <summary>
    /// Summary description for add_new_course_test
    /// </summary>
    [TestClass]
    public class add_new_course_test
    {

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
        string courseName = "testCourse";
        string lecturerID = "123";
        string practitionerID = "234";
        string LectureDuration = "3";
        string PracticeDuration = "2";
        string LabDuration = "2";
        int lecID = 123;
        int PracID = 234;
        int LecDuration = 3;
        int PracDuration = 2;
        int LabDur = 2;
        int must = 1;
        
        [TestMethod()]
        public void Test_add_new_course()
        {
            //Add course with lecture, practice and lab
            //Limit lecture, practice and lab duration
            SqlWorker.addCourse(courseName, lecturerID, practitionerID, LectureDuration, PracticeDuration, LabDuration, true);
            Assert.IsTrue(SqlWorker.GetDataSet("select * from Courses where CourseName='" + courseName +
                             "' and Lecturer=" + lecID + " and practitioner=" + PracID + " and MaxStudent=20 and "+
                             "LectureDuration=" + LecDuration + " and PracticeDuration=" + PracDuration + " and LabDuration=" + LabDur +
                             " and Must=" + must).Tables[0].Rows.Count == 1);
            SqlWorker.ExecuteQueries("Delete from Courses where CourseName='" + courseName +"'");

            //Add course with lecture and practice without lab
            //Limit lecture and practice duration
            SqlWorker.addCourse(courseName, lecturerID, practitionerID, LectureDuration, PracticeDuration, null, true);
            Assert.IsTrue(SqlWorker.GetDataSet("select * from Courses where CourseName='" + courseName +
                             "' and Lecturer=" + lecID + " and practitioner=" + PracID + " and MaxStudent=20 and " +
                             "LectureDuration=" + LecDuration + " and PracticeDuration=" + PracDuration + 
                             " and Must=" + must + " and LabDuration is null").Tables[0].Rows.Count == 1);
            SqlWorker.ExecuteQueries("Delete from Courses where CourseName='" + courseName + "'");

            //Add course with lecture and lab
            //Limit lecture and lab duration
            SqlWorker.addCourse(courseName, lecturerID, practitionerID, LectureDuration, null, LabDuration, true);
            Assert.IsTrue(SqlWorker.GetDataSet("select * from Courses where CourseName='" + courseName +
                             "' and Lecturer=" + lecID + " and practitioner=" + PracID + " and MaxStudent=20 and " +
                             "LectureDuration=" + LecDuration + " and LabDuration=" + LabDur +
                             " and Must=" + must + " and PracticeDuration is null").Tables[0].Rows.Count == 1);
            SqlWorker.ExecuteQueries("Delete from Courses where CourseName='" + courseName + "'");
        }

        [TestMethod()]
        public void Test_check_course_existence()
        {
            //Add new course
            SqlWorker.addCourse(courseName, lecturerID, practitionerID, LectureDuration, PracticeDuration, LabDuration, true);
            Assert.IsTrue(SqlWorker.GetDataSet("select * from Courses where CourseName='" + courseName +
                             "' and Lecturer=" + lecID + " and practitioner=" + PracID + " and MaxStudent=20 and " +
                             "LectureDuration=" + LecDuration + " and PracticeDuration=" + PracDuration + " and LabDuration=" + LabDur +
                             " and Must=" + must).Tables[0].Rows.Count == 1 && SqlWorker.checkCourseExistence(courseName));
            SqlWorker.ExecuteQueries("Delete from Courses where CourseName='" + courseName + "'");
        }
    }
}
