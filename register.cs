using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class register : Form
    {
        Thread th;

        public object ConfigurationManager { get; private set; }

        public register()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"C:\Real_23092018\VS15-projects\frsschool1\icons\personicon.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            password.PasswordChar = '*';
            password.MaxLength = 10;
        }





        private void show_employees_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform3()
        {
            Application.Run(new Form4());
        }

        private void insertdatawithimage_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform5);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform5()
        {
            Application.Run(new Form5());
        }

        private void basic_post_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform6);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform6()
        {
            Application.Run(new Form6());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform7);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform7()
        {
            Application.Run(new Form7());
        }

        private void student_registration_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform8);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void opennewform8()
        {
            Application.Run(new student_reg_form());
        }

        private void vehicle_registration_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform9);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void opennewform9()
        {
            Application.Run(new vehicle_registration());
        }
        private void studentlistform()
        {
            Application.Run(new student_list());
        }

        private void vehicle_list_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(vehiclelistform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void vehiclelistform()
        {
            Application.Run(new vehicle_list());
        }

        private void faceMatch_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(faceMatchfor);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void faceMatchfor()
        {
            Application.Run(new faceMatchform());
        }


        private void image_registration_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(image2_registration);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void image2_registration()
        {
            Application.Run(new imageRegistration());
        }

        private void cameraDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(camera_dashboard);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void camera_dashboard()
        {
            Application.Run(new camera_dashboard());
        }

        //--start from here

        private void stuRegMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform8);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void vehicleRegistrationMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(vehicleRegistration);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void vehicleRegistration()
        {
            Application.Run(new vehicle_registration());
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(studentlistform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void imageRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(image2_registration);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void cameraDashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(camera_dashboard);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void vehicleListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(vehiclelistform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cameraListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(cameraList);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void cameraList()
        {
            Application.Run(new camera_list());
        }

        private void databaseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(databaseList);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void databaseList()
        {
            Application.Run(new database_list());
        }

        private void faceMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(faceMatch);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void faceMatch()
        {
            Application.Run(new faceMatchform());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(imgregPython);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void imgregPython()
        {
            Application.Run(new imgregpython());
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || email_address.Text == "" || fullname.Text == "" || address.Text == "" || phone_number.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
            }
            //Check username in tbl_user for duplicate user
            string conn1 = "datasource=127.0.0.1;port=3306;username=root;password=;database=frs_school;SslMode= none;";
            string query1 = "select COUNT(user_name) from tbl_user where user_name='" + username.Text + "'";

            MySqlConnection dbCon1 = new MySqlConnection(conn1);
            MySqlCommand commandDatabase1 = new MySqlCommand(query1, dbCon1);
            commandDatabase1.CommandTimeout = 60;

            int count1;
            try
            {
                dbCon1.Open();
                count1 = Convert.ToInt32(commandDatabase1.ExecuteScalar());
                //dbCon1.Close();

                if (count1 > 0)
                {
                    MessageBox.Show("Username already exits");
                }

                else
                {

                    //Inserting data into tbl_user
                    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=frs_school;SslMode= none;";
                    string dttime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    int phone = Convert.ToInt32(phone_number.Text);
                    string query = "INSERT INTO tbl_user(`user_name`,`email_address`,`full_name`,`user_address`,`phone_number`, `password`, `time`)" +
                                   "VALUES ('" + username.Text + "', '" + email_address.Text + "', '" + fullname.Text + "', '" + address.Text + "', '" + phone_number.Text + "', '" + password.Text + "', '" + dttime + "')";

                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;

                    try
                    {
                        databaseConnection.Open();
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        MessageBox.Show("User succesfully registered");
                        databaseConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                dbCon1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("query1: " + ex.Message);
            }





        }

        //return i > 0;



        private void reset_Click(object sender, EventArgs e)
        {
            username.Text = "";
            email_address.Text = "";
            fullname.Text = "";
            address.Text = "";
            phone_number.Text = "";
            password.Text = "";
        }
    }
}
