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
    /// Summary description for set_pre_course_test
    /// </summary>
    [TestClass]
    public class set_pre_course_test
    {
        string course1 = "testCourse1";
        string course2 = "testCourse2";
        string lecturerID = "123";
        string practitionerID = "234";
        string LectureDuration = "3";
        string PracticeDuration = "2";
        string LabDuration = "2";

      
        [TestMethod()]
        public void Test_add_pre_course()
        {
            //Add pre course
            //0 - already exists
            //1 - opposite exists
            //2 - operation successfull

            //Add brand new courses
            SqlWorker.addCourse(course1, lecturerID, practitionerID, LectureDuration, PracticeDuration, LabDuration, true);
            SqlWorker.addCourse(course2, lecturerID, practitionerID, LectureDuration, PracticeDuration, LabDuration, true);
            //Set course1 as pre course of course2
            Assert.IsTrue(SqlWorker.addPreCourse(course1, course2) == 2);

            //Try again
            Assert.IsTrue(SqlWorker.addPreCourse(course1, course2) == 0);

            //Try to set the opposite
            Assert.IsTrue(SqlWorker.addPreCourse(course2, course1) == 1);

            SqlWorker.ExecuteQueries("Delete from Courses where CourseName='" + course1 +"' or CourseName='"+ course2 +"'");
            SqlWorker.ExecuteQueries("Delete from PreCourses where PreCourse='" + course1 + "' and course='" + course2 + "'");

        }
    }
}
