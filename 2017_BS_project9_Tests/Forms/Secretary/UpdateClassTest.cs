using System;
using _2017_BS_project9.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2017_BS_project9;
using System.Data;

namespace _2017_BS_project9_Tests.Forms.Secretary
{
    [TestClass]
    public class UpdateClassTest
    {
        private int[] hours = { 0, 0, 0, 0, 0, 0, 0, 0,8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
        private int[] CurrentHours = new int[22];
        string Class = "F0";
        string Class2 = "F1";
        string Course = "Test";
        string lecturerID = "58";
        string day = "1";
        string Shours = "8,0,0,11,12,13,14,15,16,17,18,19,20,21";
        string capacity = "0";
        string islab = "1";
        string hasProjector = "1";
        string numComp = "0";
        string startTime = "9";
        string endTime = "10";
        string Les = "Lecture";
        [TestMethod()]
        public void TestMethodUpdate()
        {
            DataSet dataset1, dataset2, dataset3,dataset4;
            SqlWorker.GetDataSet("INSERT INTO Lecture(StartTime,EndTime,Class,Lecturer,CourseName,Day,AmountOfStudents) VALUES('" + startTime + ":00','" + endTime + ":00','" + Class + "','" + lecturerID + "','" + Course + "','" + day + "','0')");
            SqlWorker.GetDataSet("INSERT INTO Class(Room,Capacity,IsLab,HasProjector,Hours,NumOfComputers,Days) VALUES('" + Class + "','" + capacity + "','" + islab + "','" + hasProjector + "','" + Shours + "','" + numComp + "','" + day + "')");
            SqlWorker.GetDataSet("INSERT INTO Class(Room,Capacity,IsLab,HasProjector,Hours,NumOfComputers,Days) VALUES('" + Class2 + "','" + capacity + "','" + islab + "','" + hasProjector + "','" + Shours + "','" + numComp + "','" + day + "')");
            Secretary_Change_Class_Form form = new Secretary_Change_Class_Form();
            
            dataset4 = SqlWorker.GetDataSet("SELECT Hours From Class WHERE Room LIKE'" + Class + "'AND Days LIKE'" + day + "'");
            dataset2 = SqlWorker.GetDataSet("SELECT ID FROM Lecture WHERE StartTime LIKE '" + (startTime + ":00") + "' AND EndTime LIKE '"
            + (endTime +":00") + "' AND Class LIKE '" + Class + "' AND Lecturer LIKE '" + lecturerID + "' AND CourseName LIKE '" + Course + "' AND Day LIKE '"
            + day + "' AND AmountOfStudents LIKE '0'");
            string i=dataset2.Tables[0].Rows[0][0].ToString();
            dataset3 = SqlWorker.GetDataSet("SELECT Class From Lecture WHERE ID LIKE'" + dataset2.Tables[0].Rows[0][0].ToString() + "'");
            form.UpdateClass(dataset2.Tables[0].Rows[0]["ID"].ToString(), hours, CurrentHours, Class2, Les,Class);
            dataset1 = SqlWorker.GetDataSet("SELECT Hours From Class WHERE Room LIKE'" + Class + "'AND Days LIKE'" + day + "'");
            dataset3 = SqlWorker.GetDataSet("SELECT Class From Lecture WHERE ID LIKE'" + dataset2.Tables[0].Rows[0][0].ToString() + "'");
            Assert.IsTrue((dataset1.Tables[0].Rows[0]["Hours"].ToString()!= dataset4.Tables[0].Rows[0]["Hours"].ToString() && dataset3.Tables[0].Rows[0]["Class"].ToString() == Class) || dataset3.Tables[0].Rows[0]["Class"].ToString()!=Class);

            SqlWorker.GetDataSet("DELETE FROM Lecture WHERE ID lIKE'" + dataset2.Tables[0].Rows[0]["ID"].ToString() + "'");
            SqlWorker.GetDataSet("DELETE FROM Class WHERE Room LIKE'" + Class + "'");
            SqlWorker.GetDataSet("DELETE FROM Class WHERE Room LIKE'" + Class2 + "'");
        }
    }
}
