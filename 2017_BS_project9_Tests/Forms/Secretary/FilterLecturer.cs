using System;
using _2017_BS_project9.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace _2017_BS_project9
{
    [TestClass]
    public class FilterLecturerTest
    {
        string startTime = "TestingTime";
        string endTime = "TestingTime";
        string Class = "TestingTime";
        string lecturer = "TestingLecturer";
        string CourseName = "CourseTest";
        string day = "0";
        string amoOfStud = "0";

        [TestMethod()]
        public void TestFilterLecturer()
        {
            Searching_Filtering_Lectures_Form form = new Searching_Filtering_Lectures_Form();

            SqlWorker.GetDataSet("INSERT INTO Lecture(StartTime,EndTime,Class,Lecturer,CourseName,Day,AmountOfStudents) VALUES('" + startTime + "','" + endTime + "','" + Class + "','" + lecturer + "','" + CourseName + "','" + day + "','" + amoOfStud + "')");
            DataSet data = SqlWorker.GetDataSet("SELECT ID FROM Lecture WHERE StartTime LIKE '" + startTime + "' AND EndTime LIKE '"
                + endTime + "' AND Class LIKE '" + Class + "' AND Lecturer LIKE '" + lecturer + "' AND CourseName LIKE '" + CourseName + "' AND Day LIKE '"
                + day + "' AND AmountOfStudents LIKE '" + amoOfStud + "'");
            try
            {
                Assert.IsTrue(form.searchLecture(startTime, endTime, Class, lecturer, data.Tables[0].Rows[0][0].ToString()).Tables[0].Rows.Count == 1);
            }
            catch
            {
                Assert.Fail();
            }

            SqlWorker.GetDataSet("DELETE FROM Lecture WHERE ID LIKE '" + data.Tables[0].Rows[0][0].ToString() + "'");
        }
    }
}