using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication3.DAL
{
    public class Connection
    {
        public MySqlConnection frs_con = new MySqlConnection("server=localhost;database=frs_school;uid=root;password=;SslMode = none;");

    }
}
