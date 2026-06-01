using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT
{
    public static class DBConnection
    {
        private static string connStr =
            "server=localhost;database=HRApplicantSystemDB;uid=root;pwd=kobe02062007;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }
    }
}
