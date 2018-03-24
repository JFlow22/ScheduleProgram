using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2017_BS_project9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace _2017_BS_project9.Tests
{
    [TestClass()]
    public class AddStudentTests
    {
        private BindingFlags bf = BindingFlags.NonPublic | BindingFlags.Instance;

        [TestMethod()]
        public void AddStudentTest()
        {
            try
            {
                AddStudent form = new AddStudent();
                Assert.IsNotNull(form);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void saveTest()
        {
            AddStudent form = new AddStudent();
            Student student = new Student();
            Control name_input = (Control)(typeof(AddStudent).GetField("name_input", this.bf).GetValue(form));
            Control id_input = (Control)(typeof(AddStudent).GetField("id_input", this.bf).GetValue(form));
            Control pwd_input = (Control)(typeof(AddStudent).GetField("pwd_input", this.bf).GetValue(form));
            Control sem_sbox = (Control)(typeof(AddStudent).GetField("sem_sbox", this.bf).GetValue(form));


            // we will only test the method behavior, not the form behavior
            name_input.Text = "Test User";
            id_input.Text = "1212121";
            pwd_input.Text = "1";
            sem_sbox.Text = "1";

            if (SqlWorker.GetUser(id_input.Text) != null)
                SqlWorker.ExecuteQueries("Delete from Users where ID=" + id_input.Text);


            Assert.IsTrue(form.SaveUser());
            if (SqlWorker.GetUser(id_input.Text) != null)
                SqlWorker.ExecuteQueries("Delete from Users where ID=" + id_input.Text);
            else
            {
                Assert.Fail();
            }
        }
    }
}