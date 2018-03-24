using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;
using static System.Windows.Forms.Control;
using MetroFramework.Controls;
using System.Text.RegularExpressions;

namespace _2017_BS_project9.Tests
{
    [TestClass()]
    public class StudentSchedulerTests
    {
        private Student testInputStudent;
        private BindingFlags bf = BindingFlags.NonPublic | BindingFlags.Instance;


        public StudentSchedulerTests()
        {
            testInputStudent = new Student();
            testInputStudent.Name = "Test Student";
            testInputStudent.ID = "1";
            testInputStudent.Pwd = "1";
            testInputStudent.ActiveLects = "";
            testInputStudent.ActivePracLabs = "";
            testInputStudent.PassedCourses = "";
            testInputStudent.Constraints = "Day: 1 Hour: 20;Day: 1 Hour: 19;Day: 1 Hour: 21";
            testInputStudent.SemCount = 1;
            testInputStudent.Type = "Student";
            testInputStudent.Curriculum = new Curriculum(testInputStudent.SemCount);
        }


        /// <summary>
        /// Test Ctor
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
            "No Test user argument & (Student)Globals._session is NULL")]
        public void StudentSchedulerTest()
        {
            // Test obj (form)
            StudentScheduler StudentSchedulerForm = new StudentScheduler(testInputStudent);

            // test that input variable assinged
            Student StudentResult = (Student)(typeof(StudentScheduler).GetField("currentStudent", this.bf).GetValue(StudentSchedulerForm));

            // TEST currentStudent != null
            Assert.AreEqual(testInputStudent, StudentResult);


            // test that if input is null, ctor sets global as current
            Globals._session = testInputStudent;
            StudentSchedulerForm = new StudentScheduler(null);
            Student GlobalStudentResult = (Student)(typeof(StudentScheduler).GetField("currentStudent", this.bf).GetValue(StudentSchedulerForm));

            // TEST currentStudent == null
            Assert.AreEqual(Globals._session, GlobalStudentResult);

            // TEST currentStudent == null &&  Globals._session = null
            Globals._session = null;
            StudentSchedulerForm = new StudentScheduler(null);

        }

        [TestMethod()]
        public void showConstraintsTest()
        {
            // Test obj (form)
            Globals._session = testInputStudent;
            StudentScheduler StudentSchedulerForm = new StudentScheduler(testInputStudent);
            Control warpper = (Control)(typeof(StudentScheduler).GetField("warpper", this.bf).GetValue(StudentSchedulerForm));
            StudentSchedulerForm.showConstraints();
            StudentSchedulerForm.Show();

            // create button for testing
            foreach (string constrain in testInputStudent.Constraints.Split(';'))
            {
                if (constrain == "")
                    continue;
                MatchCollection match = Regex.Matches(constrain, @"[0-9]+");
                int col = int.Parse(match[0].ToString());
                int row = int.Parse(match[1].ToString());
                MetroTile c = new MetroTile();
                c.Name = "const_" + col + "_" + row;

                // test const btns after showConstraints() function run
                Control[] const_arr = warpper.Controls.Find(c.Name, false);
                Assert.IsTrue(const_arr.Length == 1);
            }

            StudentSchedulerForm.Close();
        }

        [TestMethod()]
        public void BringBtnsToFrontTest()
        {
            // prep
            Globals._session = testInputStudent;
            StudentScheduler StudentSchedulerForm = new StudentScheduler(null);


            // Test this.warpper.Controls should not contain 'const_' named btns
            Control warpper = (Control)(typeof(StudentScheduler).GetField("warpper", this.bf).GetValue(StudentSchedulerForm));

            foreach (Control a in warpper.Controls) {
                foreach (Control b in warpper.Controls)
                {
                    if (a.Name.Contains("ev_"))
                    {
                        Assert.IsTrue(warpper.Controls.GetChildIndex(a) > warpper.Controls.GetChildIndex(b));
                    }
                }
            }
        }
    }
}