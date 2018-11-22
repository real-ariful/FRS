using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication3.BLL;
using WindowsFormsApplication3.PLL;

namespace WindowsFormsApplication3
{
    public partial class Login : Form
    {
        public string user = string.Empty;
        public string pass = string.Empty;
        private string conn;
        private MySqlConnection connect;
        Boolean ubool = false;
        Boolean pbool = false;
        Thread th;
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            Password.PasswordChar = '*';
            Password.MaxLength = 10;
        }


        private void db_connection()
        {
            try
            {
                conn = "Server=localhost;Database=frs_school;Uid=root;Pwd=;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.StackTrace);
            }
        }

        private bool validate_login(string user, string pass)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from frs_login where username=@user and password=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();


            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }

        private void signin_Click(object sender, EventArgs e)
        {

            user = Username.Text;
            pass = Password.Text;
            if (user == "Username" && pass == "Password")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Enter Login Credentials", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                th = new Thread(foodForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            //MetroFramework.MetroMessageBox.Show(this, "Information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
            
            else if (user == "" && pass == "")
            {//MetroFramework.MetroMessageBox.Show(this, "Empty Fields Detected ! Please fill up all the fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Empty Fields Detected ! Please fill up all the fields");
                this.Close();
                th = new Thread(mainpage);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }

            else if (user == "garment" && pass == "")
            {
                this.Close();
                th = new Thread(garment_mainpage);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }

            else if (user == "haar" && pass == "")
            {
                this.Close();
                th = new Thread(facedet_reg);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else if (user == "haar2" && pass == "")
            {
                this.Close();
                th = new Thread(haar22);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }

            else if (user == "open" && pass == "")
            {
                this.Close();
                th = new Thread(open);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }

            else
            {

                ProfileBLL objbll = new ProfileBLL();
                int count = (int)objbll.GetProfile(user, pass);
                Console.WriteLine("COUNT IS---------->" + count.ToString());
                if (count == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show("Error ");
                }
                Console.WriteLine(count);
                if (count > 0)
                {
                    this.Close();
                    th = new Thread(mainpage);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    Console.WriteLine("Correct Login Cresentials");
                }
            }
        }

                //    //----------------------------------old connections working-------------
                //try
               // {

                    //    //create a MySQL connection with a Connection string 
                    //    MySqlConnection connection = new MySqlConnection("server=localhost;database=frs_school;uid=root;password=;SslMode = none;");
                    //    //open the connection 
                    //    connection.Open();
                    //    string StrQuery1 = "Select * from frs_login where username='" + Username.Text + "' and password='" + Password.Text + "'";
                    //    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(StrQuery1, connection);
                    //    MySql.Data.MySqlClient.MySqlDataAdapter MyAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(myCommand);
                    //    //DataSet ds = new DataSet();
                    //    //MyAdapter.Fill(ds);

                    //    DataTable table = new DataTable();
                    //    MyAdapter.Fill(table);
                    //    //            mcon.Close();

                    //    //            //Console.WriteLine(table.Rows[0][0].ToString());
                    //    //            //if(table.Rows[0][0].ToString() == "1")
                    //    if (table.Rows.Count > 0)
                    //    {
                    //        this.Close();
                    //        th = new Thread(mainpage);
                    //        th.SetApartmentState(ApartmentState.STA);
                    //        th.Start();
                    //        Console.WriteLine("Correct Login Cresentials");
                    //    }
                    //    else
                    //    {
                    //        //Login fail 
                    //        MessageBox.Show("Incorrect Login Credentials");
                    //    }
                    //}
                    //catch (Exception ex)
                    //{

                    //    MessageBox.Show(ex.Message);
                    //}
                    ////----------------------------------||||-------------

//                }
  //      }



        private void submit(object sender, EventArgs e)
        {
            string user = Username.Text;
            string pass = Password.Text;
            if (user == "" || pass == "")
            {
                this.Close();
                th = new Thread(mainpage);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            bool r = validate_login(user, pass);
            if (r)
                MessageBox.Show("Correct Login Credentials");
            else
                MessageBox.Show("Incorrect Login Credentials");




            //string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=frs_school;";
            //MySqlConnection mcon = new MySqlConnection(connectionString);
            //mcon.Open();
            //MySqlDataAdapter MyDA = new MySqlDataAdapter();

            ////string sqlSelectAll = "SELECT * FROM tbl_user, tbl_admin WHERE tbl_user.user_name='"+ Username.Text+"' AND tbl_user.password='"+Password.Text+"'AND tbl_user.user_id=tbl_admin.user_id";
            //string sqlSelectAll = "SELECT * FROM frs_login WHERE user_name='" + Username.Text.Trim() + "' AND password='" + Password.Text.Trim() + "'";
            //MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mcon);
            //DataTable table = new DataTable();
            //MyDA.Fill(table);
            //mcon.Close();

            ////Console.WriteLine(table.Rows[0][0].ToString());
            ////if(table.Rows[0][0].ToString() == "1")

            //if (table.Rows.Count == 1)
            //{

            //    this.Close();
            //    th = new Thread(mainpage);
            //    th.SetApartmentState(ApartmentState.STA);
            //    th.Start();

            //}


            //if (Username.Text == "" && Password.Text == "")
            //        {
            //            this.Close();
            //            th = new Thread(mainpage);
            //            th.SetApartmentState(ApartmentState.STA);
            //            th.Start();
            //        }
            //        try
            //        {

            //            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=frs_school;";
            //            MySqlConnection mcon = new MySqlConnection(connectionString);
            //            mcon.Open();
            //            MySqlDataAdapter MyDA = new MySqlDataAdapter();

            //            //string sqlSelectAll = "SELECT * FROM tbl_user, tbl_admin WHERE tbl_user.user_name='"+ Username.Text+"' AND tbl_user.password='"+Password.Text+"'AND tbl_user.user_id=tbl_admin.user_id";
            //            string sqlSelectAll = "SELECT * FROM frs_login WHERE user_name='" + Username.Text.Trim() + "' AND password='" + Password.Text.Trim() + "'";
            //            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mcon);
            //            DataTable table = new DataTable();
            //            MyDA.Fill(table);
            //            mcon.Close();

            //            //Console.WriteLine(table.Rows[0][0].ToString());
            //            //if(table.Rows[0][0].ToString() == "1")

            //            if (table.Rows.Count ==1)
            //            {

            //                this.Close();
            //                th = new Thread(mainpage);
            //                th.SetApartmentState(ApartmentState.STA);
            //                th.Start();

            //            }


            //        }

            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.StackTrace);
            //        }
        }

        private void garment_mainpage()
        {
            Application.Run(new garment_mainpage());
        }
        private void mainpage()
        {
            Application.Run(new mainpage());
        }

        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        private void newuserregister_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(register);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void register()
        {
            Application.Run(new register());
        }

        //remove
        private void facedet_reg()
        {
            Application.Run(new test.facedet_reg());
        }
        private void haar22()
        {
            Application.Run(new test.haar2());
        }
        private void open()
        {
            Application.Run(new test.open());
        }
        private void foodForm()
        {
            Application.Run(new foodForm1());
        }


        private void Username_Click(object sender, EventArgs e)
        {
            if (ubool == false)
            {
                Username.Clear();
                ubool = true;
            }
            
            pictureBox1.BackgroundImage = Properties.Resources.user;
            pictureBox1.BackColor = Color.FromArgb(100, 149, 237);
            panel2.BackColor = Color.FromArgb(100, 149, 237);
            //Username.ForeColor = Color.FromArgb(100, 149, 237);

            pictureBox2.BackgroundImage = Properties.Resources.ios7_locked;
            pictureBox2.BackColor = Color.WhiteSmoke;
            panel3.ForeColor = Color.WhiteSmoke;
            //Password.ForeColor = Color.WhiteSmoke;
        }

        private void Password_Click(object sender, EventArgs e)
        {
            if (pbool == false)
            {
                Password.Clear();
                pbool = true;
            }
            pictureBox2.BackgroundImage = Properties.Resources.ios7_locked;
            pictureBox2.BackColor = Color.FromArgb(100, 149, 237);
            panel3.BackColor = Color.FromArgb(100, 149, 237);
            //Password.ForeColor = Color.FromArgb(100, 149, 237);

            pictureBox1.BackgroundImage = Properties.Resources.user;
            pictureBox1.BackColor = Color.WhiteSmoke;
            panel2.ForeColor = Color.WhiteSmoke;
            //Username.ForeColor = Color.WhiteSmoke;

        }

        private void cross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            
        }

        private void max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void min_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }

        }
    }
}
