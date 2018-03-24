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
    public class LoginTests
    {
        private BindingFlags bf = BindingFlags.NonPublic | BindingFlags.Instance;
        Login LoginForm;

        [TestMethod()]
        public void LoginTest()
        {

            try
            {
                this.LoginForm = new Login();
                Assert.IsNotNull(this.LoginForm);
            }
            catch
            {
                Assert.Fail();
            }
        }
        
        [TestMethod()]
        public void IsDigitsTest()
        {
            this.LoginForm = new Login();
            Assert.IsFalse(this.LoginForm.IsDigits("a"));
            Assert.IsFalse(this.LoginForm.IsDigits("1a"));

            for (int d = 0; d < 10; d++)
                Assert.IsTrue(LoginForm.IsDigits(d.ToString()));
        }

        [TestMethod()]
        public void authTest()
        {
            this.LoginForm = new Login();
            Control id_textbox = (Control)(typeof(Login).GetField("id_textbox", this.bf).GetValue(LoginForm));
            Control pwd_textbox = (Control)(typeof(Login).GetField("pwd_textbox", this.bf).GetValue(LoginForm));


            /// Test Good input
            try
            {
                id_textbox.Text = "1";
                pwd_textbox.Text = "1";
                // make sure there is a user in DB with ID 1 and PWD 1
                User usr = SqlWorker.GetUser(id_textbox.Text);
                if (usr == null)
                {
                    usr = new User("1", "Test User", "1", "1");
                    string colums = "(ID,PWD,NAME,TYPE)";
                    string values = "(" + usr.ID + "," + usr.Pwd + "," + usr.Name + "," + usr.Type;
                    SqlWorker.ExecuteQueries("Insert into Users " + colums + " Values " + values);

                }
                Assert.IsTrue(LoginForm.auth());
                // clear after that
                if (usr.Name.Equals("Test User"))
                    SqlWorker.ExecuteQueries("Delete from Users where Name like 'Test User'");

            }
            catch (Exception e)
            {
                switch (e.Message)
                {
                    case "Make sure that your id contains only digits":
                    case "There is no internet connection.\nPlease try again later.":
                    case "User not found or Password is incorrect":
                        Assert.Fail();
                        break;
                }
            }

            // Test Bad input
            try
            {
                id_textbox.Text = "0";
                pwd_textbox.Text = "1";
                // make sure there is a user in DB with ID 1 and PWD 1
                User usr = SqlWorker.GetUser(id_textbox.Text);
                if (usr != null)
                    SqlWorker.ExecuteQueries("Delete from Users where ID=0");

                Assert.IsFalse(LoginForm.auth());

            }
            catch (Exception e)
            {
                switch (e.Message)
                {
                    case "Make sure that your id contains only digits":
                    case "There is no internet connection.\nPlease try again later.":
                    case "User not found or Password is incorrect":
                        Assert.IsTrue(true);
                        break;
                }
            }

        }

        [TestMethod()]
        public void starterTest()
        {
            LoginForm = new Login();
            if (Globals._session == null)
                Globals._session = new User("1","Test","1", null);

            Globals._session.Type = "Student";
            Assert.IsTrue(LoginForm.starter(true));
            Globals._session.Type = "Secretary";
            Assert.IsTrue(LoginForm.starter(true));
            Globals._session.Type = "HeadOfDep";
            Assert.IsTrue(LoginForm.starter(true));
            Globals._session.Type = "Lecturer";
            Assert.IsTrue(LoginForm.starter(true));
            Globals._session.Type = "Practitioner";
            Assert.IsTrue(LoginForm.starter(true));
            Globals._session.Type = "HouseKeeper";
            Assert.IsTrue(LoginForm.starter(true));
            Globals._session.Type = "HouseKeeper";
            

            try
            {
                Globals._session.Type = "asdawdawd";
                Assert.IsTrue(LoginForm.starter(true));
            } catch (Exception e)
            {
                Assert.IsTrue(e.Message.Equals("User Type not defind"));
            }

            LoginForm.Dispose();
        }

        [TestMethod()]
        public void facebook_login_btn_ClickTest()
        {
            // untestable, need user input
            Assert.Inconclusive();
        }
    }
}