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
    public class req_class_type_test
    {
        //project parameters
        int p = 1;
        int l = -1; // constant -1 for lecturer - cant choose lab.

        //temp course parameters
        string courseName = "testCourse";
        string lecturerID = "123";
        string practitionerID = "234";
        string LectureDuration = "3";
        string PracticeDuration = "2";
        string LabDuration = "2";
        int lecID = 123;

        [TestMethod()]
        public void class_req_test()
        {
            //insert one request for class in temp course.
            SqlWorker.addCourse(courseName, lecturerID, practitionerID, LectureDuration, PracticeDuration, LabDuration, true);
            SqlWorker.setClassRequest(lecID.ToString(), courseName, p,l);

            Assert.IsTrue(SqlWorker.GetDataSet("select * from ClassRequest where TeacherID LIKE '"+lecID+
                "' AND CourseName LIKE '"+courseName+"' AND Projector = '"+p+"' AND Lab = '-1'").Tables[0].Rows.Count == 1);

            //try to update the request
            p = 0;
            SqlWorker.addCourse(courseName, lecturerID, practitionerID, LectureDuration, PracticeDuration, LabDuration, true);
            SqlWorker.setClassRequest(lecID.ToString(), courseName, p, l);

            Assert.IsTrue(SqlWorker.GetDataSet("select * from ClassRequest where TeacherID LIKE '" + lecID +
                "' AND CourseName LIKE '" + courseName + "' AND Projector = '" + p + "' AND Lab = '-1'").Tables[0].Rows.Count == 1);

            //delete the temp course.
            SqlWorker.ExecuteQueries("Delete from Courses where CourseName='" + courseName + "'");

            //delete the request
            SqlWorker.ExecuteQueries("Delete from ClassRequest where CourseName='" + courseName + "'");
        }
    }
}
