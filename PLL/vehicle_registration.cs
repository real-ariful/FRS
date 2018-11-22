using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class vehicle_registration : Form
    {
        Thread th;

        public vehicle_registration()
        {
            InitializeComponent();
        }

        string filePath;

        private void select_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.jpg;*.png; *.gif)|*.jpg; .*png;*.gif;";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileInfo file = new System.IO.FileInfo(opf.FileName);
                Bitmap img = new Bitmap(opf.FileName);


                if (file.Length < 8192000)
                {
                    pictureBox1.Image = img;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    // image file path
                    // txtpath.Text = opf.FileName;
                    filePath = opf.FileName;
                }
                else if (file.Length > 8192000)
                {
                    MessageBox.Show("Image Size must be less than 8 MB");

                }
            }
        }


        private void submit_Click(object sender, EventArgs e)

        {
            string imagePath = @"C:\\xampp\\htdocs\\frs2018\\db\\vehicle\\" + student_name.Text  + ".jpg";

            System.IO.File.Copy(filePath, imagePath);

            //            SaveUser();            
            //      }

            //Database Connection 
            //    private void SaveUser()
            //  {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=frs_school;";

            //time = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            //string query = "INSERT INTO frs_vehicle(`student_name`,`student_id`, `vehicle_brand`, `vehicle_model`) VALUES ( '" + student_name.Text + "', '"+ student_id.Text + "', '" + vehicle_brand.Text + "', '" + vehicle_model.Text + "')";

            string query = "INSERT INTO frs_vehicle(`student_name`,`student_id`,`vehicle_brand`,`vehicle_model`,`vehicle_image`, `vehicle_plate`,`vehicle_color`,`vehicle_owner`,`time`) VALUES ('" + student_name.Text + "', '" + student_id.Text + "', '" + vehicle_brand.Text + "', '" + vehicle_model.Text + "', '" + imagePath + "', '"+ vehicle_no.Text + "', '" + vehicle_color.Text + "', '" + vehicle_owner.Text + "', '" + time + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Student succesfully registered");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //  }


        }

        private void reset_Click(object sender, EventArgs e)
        {
            student_name.Text = "";
            student_id.Text = "";
            vehicle_brand.Text = "";
            vehicle_model.Text = "";
            vehicle_no.Text = "";
           //vehicle_color = "";
            vehicle_owner.Text = "";

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
    }
}


