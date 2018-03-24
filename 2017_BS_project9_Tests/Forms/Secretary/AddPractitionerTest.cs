using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2017_BS_project9.Forms;

namespace _2017_BS_project9
{
    [TestClass]
    public class AddPractitionerTest
    {
        string name = "PractitionerTest";
        string PractitionerID = "123";
        string password = "1000";
        string fakeType = "Lecturer";
        string realType = "Practitioner";
        string startTime = "8:00";
        string endTime = "10:00";
        string day = "Sunday";

        [TestMethod()]
        public void TestAddPractitioner()
        {
            Adding_User_Form form = new Adding_User_Form();
            form.addUser(PractitionerID, password, name, realType, startTime, endTime, day);
            try
            {
                Assert.IsFalse(SqlWorker.GetDataSet("SELECT * from Users WHERE ID LIKE '" 
                    + PractitionerID + "' AND PWD LIKE '" + password + "' AND Name LIKE '" 
                    + name + "' AND Type LIKE '" + fakeType + "'").Tables[0].Rows.Count == 1);
            }
            catch
            {
                Assert.Fail();
            }
            SqlWorker.GetDataSet("DELETE FROM Users WHERE ID='" + PractitionerID + "'");
        }
    }
}
