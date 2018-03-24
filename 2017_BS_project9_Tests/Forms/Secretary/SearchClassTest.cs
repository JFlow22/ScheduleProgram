using System;
using _2017_BS_project9.Forms;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2017_BS_project9
{
    [TestClass]
    public class SearchClassTest
    {
        string room = "RoomTest";
        string capacity = "0";
        string islab = "1";
        string hasProjector = "1";
        string hours = "";
        string numComp = "0";
        string days = "0";

        [TestMethod()]
        public void Test_Search_Class()
        {
            Search_Class_By_Type_Form form = new Search_Class_By_Type_Form();
            int count = 0;
            try
            {
                count = form.searchClass(true, true).Tables[0].Rows.Count;
            }
            catch {}

            SqlWorker.GetDataSet("INSERT INTO Class(Room,Capacity,IsLab,HasProjector,Hours,NumOfComputers,Days) VALUES('" + room + "','" + capacity + "','" + islab + "','" + hasProjector + "','" + hours + "','" + numComp + "','" + days + "')");
            try
            {
                Assert.IsTrue(form.searchClass(true, true).Tables[0].Rows.Count == count + 1);
            }
            catch
            {
                Assert.Fail();
            }
            SqlWorker.GetDataSet("DELETE FROM Class WHERE Room LIKE '" + room + "'");
        }
    }
}
