using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication3.DAL
{

    public class ProfileDAL
    {
        DataTable dt = new DataTable();

        public int ReadProfile(string username, string password)
        {


                Connection conn = new Connection();
                if (ConnectionState.Closed == conn.frs_con.State)
                {
                    conn.frs_con.Open();
                }
               // TextBox username = Application.OpenForms["Login"].Controls["Username"] as TextBox;
               // TextBox password = Application.OpenForms["Login"].Controls["Password"] as TextBox;


                string log_query = "Select * from frs_login where username='" + username.ToString() + "' and password='" + password.ToString() + "'";
                MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(log_query, conn.frs_con);
                try
                {
                MySqlDataAdapter MyAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                MyAdapter.Fill(table);
                int count = table.Rows.Count;
                return count;                
                }
                catch (Exception)
                    {
                        throw;
                    }
            
        }
    }
}
