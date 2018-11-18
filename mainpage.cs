using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Emgu.CV;
using Emgu.CV.Structure;


namespace WindowsFormsApplication3
{
    public partial class mainpage : Form
    {
        Thread th;
        public mainpage()
        {

            //Mat m3 = new Mat();
            //Image userIcon = Image.FromFile(@"C:\Real_23092018\VS15-projects\frsschool1\icons\user.png");
            //pictureBox1.Image = userIcon;


            //label1.Text = "User";
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
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

        private void studentLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(studentLocation);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void studentLocation()
        {
            Application.Run(new PLL.studentLocation());
        }
    }
}
