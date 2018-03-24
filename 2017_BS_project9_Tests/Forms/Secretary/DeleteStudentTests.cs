using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2017_BS_project9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_BS_project9.Tests
{
    [TestClass()]
    public class DeleteStudentTests
    {
        [TestMethod()]
        public void DeleteStudentTest()
        {
            try
            {
                DeleteStudent form_null = new DeleteStudent(null);
                DeleteStudent form_list = new DeleteStudent(new List<Student>());
            } catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void set_schedule_ClickTest()
        {
            Student stud = new Student("1000100","Test"," ","Student");
            SqlWorker.AddStudent(stud);
            Assert.IsTrue(SqlWorker.DeleteStudent(stud));
        }
    }
}