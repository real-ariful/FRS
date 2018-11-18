using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Threading;

using System.Diagnostics;


namespace WindowsFormsApplication3
{
    public partial class imgregpython : Form
    {
        Thread Th;
        public imgregpython()
        {
            InitializeComponent();
        }



        string filePath;
        private byte[] image;
        private Thread th;

        private void upload_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png; *.bmp)|*.jpg; .*png;*.bmp;";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileInfo file = new System.IO.FileInfo(opf.FileName);
                Bitmap img = new Bitmap(opf.FileName);


                if (file.Length < 8192000)
                {
                    pictureBox1.Image = img;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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
            string imagePath = @"C:\\xampp\\htdocs\\frs2018\\db\\image\\" + student_id.Text + "_" + full_name.Text + ".jpg";
            bool flagFileExist = false;
            flagFileExist = File.Exists(imagePath);
            if (flagFileExist == true)
            {
                MessageBox.Show("Student with same student id and name already Exists! Please register another student");
            }
            else
            {
                System.IO.File.Copy(filePath, imagePath);
                string path = "C:\\xampp\\htdocs\\frs2018\\db\\image\\" + student_id.Text + "_" + full_name.Text + ".jpg";
                //--------------Addition for python script(Works)but shows python sheel or cmd prompt-----------------------------------

                string result = argtest();
                Console.WriteLine(result);
                deserialiseJSON(result);
            }
        }

        public string argtest()

        {
            string currentDir = Environment.CurrentDirectory;
            Console.WriteLine("Current DIR-->", currentDir);//gives no path

            string result;
            string imagePath = "C:\\xampp\\htdocs\\frs2018\\db\\image\\" + student_id.Text + "_" + full_name.Text + ".jpg";
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Python\Python35\python.exe";
            start.Arguments = @"C:\Real_23092018\VS15-projects\frsschool1\python\imgreg.py" + " " + imagePath;
            start.UseShellExecute = false;
            //

            start.WindowStyle = ProcessWindowStyle.Normal;
            //
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    result = reader.ReadToEnd();
            Console.Write(result);
                    
                }
            }
               // Console.Read();
            return result;
        }
 
 

        private void reset_Click(object sender, EventArgs e)
        {
            full_name.Text = "";
            student_id.Text = "";
            phone.Text = "";
            classe.Text = "";
            address.Text = "";
            dob.Text = "";
        }

        public static byte[] ImageToBinary(string _path)
        {
            FileStream fS = new System.IO.FileStream(_path, FileMode.Open, FileAccess.Read);
            byte[] b = new byte[fS.Length];
            fS.Read(b, 0, (int)fS.Length);
            fS.Close();
            return b;
        }

        #region json funcrions

        private void deserialiseJSON(string strJSON)
        {
            try
            {
                var jPerson = JsonConvert.DeserializeObject<dynamic>(strJSON);
                // condition if image storage is successful
                if (jPerson["result"] == "success")
                {
                    // {
                    //                    "result":"success", 
                    //               "success":[{
                    //                 "name":"/admin/CApITest/pic/1.png",
                    //                "imageId":"ae9859f4929a496f9f3d4a7492d35c06",
                    //                "personId":"ae9859f4929a496f9f3d4a7492d35c06",
                    ////                "qualityScore":79.21,
                    //       "feature":"7qpXQiVeAAAAAQAAUmwDPQDvNz2q2dq8PA8hPeH53j3Ls7W9YqLrPY1hjL3HK dA7ANAjvToGoQ==" }],
                    //      "fail":[{
                    //     "name":"/admin/CApITest/pic/2.bmp",
                    //                   "errCode":2006,
                    //                   "imageId":"e124196cea9041538cd39084644c5fe5",
                    //                   "errReason":"SDK_ERROR:_NO_FACE_DETECTED" }],
                    //         "time_used":319 } 
                    //                }
                    //return jPerson;
                    string name = jPerson["success"][0]["name"];
                    string imageId = jPerson["success"][0]["imageId"];
                    string personId = jPerson["success"][0]["personId"];
                    string qualityScore = jPerson["success"][0]["qualityScore"];
                    string feature = jPerson["success"][0]["feature"];

                    Console.WriteLine(jPerson["success"][0]["name"]);
                    Console.WriteLine(jPerson["success"][0]["imageId"]);
                    Console.WriteLine(jPerson["success"][0]["personId"]);
                    Console.WriteLine(jPerson["success"][0]["qualityScore"]);
                    Console.WriteLine(jPerson["success"][0]["feature"]);

                    dbinsert(name, imageId, personId, qualityScore, feature);
                }
                else if (jPerson["result"] == "error")
                {
                    MessageBox.Show("Falied to store image:" + jPerson["fail"][0]["name"] + ", Error Code" + jPerson["fail"][0]["errCode"] +
                        "Reason:" + jPerson["fail"][0]["errReason"] + ". Please try with another image");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        //--------------------------------------Connection to database and Insertion-----------------------------------------------


        private void dbinsert(string name, string imageId, string personId, string qualityScore, string feature)
        {
            Console.WriteLine(name);
            Console.WriteLine(imageId);
            Console.WriteLine(personId);
            Console.WriteLine(qualityScore);
            Console.WriteLine(feature);

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=frs_school;SslMode = none;";

            //time = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
            // string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //time = "2018-09-09 18:11:33";

            //int phone = Convert.ToInt32(phone_number.Text);
            //int postalCode = Convert.ToInt32(postal_code.Text);
            //string query = "INSERT INTO frs_student(`first_name`,`last_name`, `father_name`, `mother_name`) VALUES ( '" + first_name.Text + "', '"+ last_name.Text + "', '" + last_name.Text + "', '" + father_name.Text + "')";
            string imagePath = @"C:\\xampp\\htdocs\\frs2018\\db\\image\\" + student_id.Text + "_" + full_name.Text + ".jpg";
            string query = "INSERT INTO frs_image(`full_name`,`student_id`,`phone`,`class`,`address`, `dob`,`image_path`,`imageId`,`personId`, `qualityScore`,`feature`) VALUES ('" + full_name.Text + "', '" + student_id.Text + "', '" + phone.Text + "', '" + classe.Text + "', '" + address.Text + "', '" + dob.Text + "', '" + imagePath + "', '" + imageId + "', '" + personId + "', '" + qualityScore + "', '" + feature + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Student succesfully registered");
                databaseConnection.Close();

                full_name.Text = "";
                student_id.Text = "";
                phone.Text = "";
                classe.Text = "";
                address.Text = "";
                dob.Text = "";
                filePath = "";
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
