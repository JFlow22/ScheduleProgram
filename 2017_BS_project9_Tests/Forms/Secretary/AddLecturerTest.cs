
using _2017_BS_project9.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2017_BS_project9
{
    /// <summary>
    /// Summary description for AddLecturerTest
    /// </summary>
    [TestClass]
    public class AddLecturerTest
    {
        string name = "LecturerTest";
        string LecturerID = "123";
        string password = "1000";
        string type = "Lecturer";
        string startTime = "8:00";
        string endTime = "10:00";
        string day = "Sunday";

        [TestMethod()]
        public void TestAddLecturer()
        {
            Adding_User_Form form = new Adding_User_Form();
            form.addUser(LecturerID, password, name, type, startTime, endTime, day);
            try
            {
                Assert.IsTrue(SqlWorker.GetDataSet("SELECT * from Users WHERE ID LIKE '" + LecturerID + "' AND PWD LIKE '" + password + "' AND Name LIKE '" + name + "' AND Type LIKE '" + type + "'").Tables[0].Rows.Count == 1);
            }
            catch
            {
                Assert.Fail();
            }
            SqlWorker.GetDataSet("DELETE FROM Users WHERE ID='" + LecturerID + "'");
        }
    }
}
