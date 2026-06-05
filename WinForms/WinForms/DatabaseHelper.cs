using MySql.Data.MySqlClient;

namespace HRApplicantSystem
{
    public class DatabaseHelper
    {
        private string connectionString =
            "server=localhost;database=HRApplicantSystemDB;uid=root;pwd=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}