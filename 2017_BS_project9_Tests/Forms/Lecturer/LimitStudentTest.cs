using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;
using static System.Windows.Forms.Control;
using MetroFramework.Controls;
using System.Data;
using _2017_BS_project9;

namespace _2017_BS_project9_Tests.Forms.Lecturer
{

    [TestClass()]
    class LimitStudentTest
    {
        //new limit
        int lim = 44;

        //Temp course parameters
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
        public void testUpdateLimit()
        {
            //insert valid limit and check if the limit updated.
            SqlWorker.addCourse(courseName, lecturerID, practitionerID, LectureDuration, PracticeDuration, LabDuration, true);
            SqlWorker.LimitAmountOfStu(lim, courseName);

            Assert.IsTrue(SqlWorker.GetDataSet("select * from Courses where CourseName='" + courseName +
                            "' and Lecturer=" + lecID + " and practitioner=" + PracID + " and MaxStudent="+ lim +" and " +
                            "LectureDuration=" + LecDuration + " and PracticeDuration=" + PracDuration + " and LabDuration=" + LabDur +
                            " and Must=" + must).Tables[0].Rows.Count == 1);

            //insert new invalid limit and check if the limit wont change.
            lim = 15;
            SqlWorker.LimitAmountOfStu(lim, courseName);

            Assert.IsTrue(SqlWorker.GetDataSet("select * from Courses where CourseName='" + courseName +
                            "' and Lecturer=" + lecID + " and practitioner=" + PracID + " and MaxStudent=" + lim + " and " +
                            "LectureDuration=" + LecDuration + " and PracticeDuration=" + PracDuration + " and LabDuration=" + LabDur +
                            " and Must=" + must).Tables[0].Rows.Count == 0);

            //delete the temp course.
            SqlWorker.ExecuteQueries("Delete from Courses where CourseName='" + courseName + "'");
        }
    }
}
