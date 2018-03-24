using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace _2017_BS_project9
{
    class Conn
    {
        SqlConnection connection;
        SqlCommand command;

        public Conn()
        {
            connection = new SqlConnection();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["mainApp.Properties.Settings.connString"];
            connection.ConnectionString = settings.ConnectionString;
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
        } // constructor

        public User GetUsersData(int id, string pwd)
        {
            try
            {
                command.CommandText = "select * from USERS where ID=@ID and PWD=@PWD";
                command.Parameters.Add("ID", SqlDbType.VarChar).Value = id;
                command.Parameters.Add("PWD", SqlDbType.VarChar).Value = pwd;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                    }
                }
            }
            catch
            { }
            finally
            {
                connection.Close();
            }
            return null;
        }
    }
}
