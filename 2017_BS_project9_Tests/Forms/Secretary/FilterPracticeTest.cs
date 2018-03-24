using System;
using _2017_BS_project9.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace _2017_BS_project9
{
    [TestClass]
    public class FilterPracticeTest
    {
        string startTime = "TestingTime";
        string endTime = "TestingTime";
        string Class = "TestingTime";
        string practitioner = "TestingPractitioner";
        string type = "Test";
        string CourseName = "CourseTest";
        string day = "0";
        string amoOfStud = "0";

        [TestMethod()]
        public void TestFilterPractice()
        {
            Searching_Filtering_Practices_Form form = new Searching_Filtering_Practices_Form();
            
            SqlWorker.GetDataSet("INSERT INTO TeachingExercises(StartTime,EndTime,Class,Practitioner,type,CourseName,Day,AmountOfStudents) VALUES('" + startTime + "','" + endTime + "','" + Class + "','" + practitioner + "','" + type + "','" + CourseName + "','" + day + "','" + amoOfStud + "')");
            DataSet data = SqlWorker.GetDataSet("SELECT ID FROM TeachingExercises WHERE StartTime LIKE '" + startTime + "' AND EndTime LIKE '"
                + endTime + "' AND Class LIKE '" + Class + "' AND Practitioner LIKE '" + practitioner + "' AND type LIKE '" + type + "' AND CourseName LIKE '" + CourseName + "' AND Day LIKE '"
                + day + "' AND AmountOfStudents LIKE '" + amoOfStud + "'");
            try
            {
                Assert.IsTrue(form.searchPractice(startTime, endTime, Class, practitioner, type, data.Tables[0].Rows[0][0].ToString()).Tables[0].Rows.Count == 1);
            }
            catch
            {
                Assert.Fail();
            }
            
            SqlWorker.GetDataSet("DELETE FROM TeachingExercises WHERE ID LIKE '" + data.Tables[0].Rows[0][0].ToString() + "'");
        }
    }
}
