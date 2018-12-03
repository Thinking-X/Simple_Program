using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.DAL
{
    class DBHelper
    {
        private static string Login = "data source=.;initial catalog=educ;Integrated Security=True";
        //server=.;database=educ;Trusted_Connection=true;
        public static SqlConnection Connect()
        {
            SqlConnection sqlConnection = new SqlConnection(Login);
            return sqlConnection;
        }
    }
}
