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
    public partial class student_list : Form
    {
        Thread th;
        public student_list()
        {
            InitializeComponent();
            view();
        }

        //-----------------------------testing code view
        //This code works and shows images
        //-------------------testing codes

        public void view()
        {

            //variables
            String id, picture;
            int count;
            Image img;
            Bitmap blankImg;

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=frs_school;Convert Zero Datetime=True;SslMode = none;";
            MySqlConnection con = new MySqlConnection(connectionString);
            DataSet set = new DataSet();
            string query = "SELECT student_id, student_image, first_name, last_name, email_address, phone_number, address,father_name, mother_name, city, country FROM frs_student";
            MySqlDataAdapter idData = new MySqlDataAdapter(query, con);
            try
            {
                con.Open();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            idData.Fill(set, "student_id");//confused about this line
            count = set.Tables[0].Rows.Count;
            studentlistGrid.Columns.AddRange(new DataGridViewTextBoxColumn(), new DataGridViewImageColumn(), new DataGridViewTextBoxColumn(), new DataGridViewTextBoxColumn(),
                new DataGridViewTextBoxColumn(), new DataGridViewTextBoxColumn(), new DataGridViewTextBoxColumn(), new DataGridViewTextBoxColumn(), new DataGridViewTextBoxColumn(),
                new DataGridViewTextBoxColumn(), new DataGridViewTextBoxColumn());
            studentlistGrid.AllowUserToAddRows = false;
            //        DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            //        imageColumn = (DataGridViewImageColumn)studentlistGrid.Columns[18];
            //        imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            studentlistGrid.Columns[0].Name = "student_id";
            studentlistGrid.Columns[1].Name = "Picture";
            studentlistGrid.Columns[2].Name = "First Name";
            studentlistGrid.Columns[3].Name = "Last Name";
            studentlistGrid.Columns[4].Name = "Email Address";
            studentlistGrid.Columns[5].Name = "Phone Number";
            studentlistGrid.Columns[6].Name = "Address";
            studentlistGrid.Columns[7].Name = "Father's Name";
            studentlistGrid.Columns[8].Name = "Mother's Name";
            studentlistGrid.Columns[9].Name = "City";
            studentlistGrid.Columns[10].Name = "Country";

            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)studentlistGrid.Columns[1];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            imageColumn.Width = 100;


            studentlistGrid.RowTemplate.Height = 100;

            for (int i = 0; i < count-1; i++)
            {
                id = set.Tables[0].Rows[i][0].ToString();
                picture = set.Tables[0].Rows[i][1].ToString();
                img = Image.FromFile("C:\\xampp\\htdocs\\frs2018\\"+picture.ToString());
                string[] data = new string[11];
                for (int j = 0; j < 11; j++)
                {
                    data[j] = set.Tables[0].Rows[i][j].ToString();
                }


                studentlistGrid.Rows.Add(id, img, data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9], data[10]);

                studentlistGrid.ClearSelection();

            }
        }
        //------------------finishing----------------------------------



        //Shows all the database information
        //    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=frs_school;Convert Zero Datetime=True;SslMode = none;";
        //    MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        //    string query = "SELECT * FROM frs_student";
        //    MySqlCommand cmdDataBase = new MySqlCommand(query, databaseConnection);
        //    cmdDataBase.CommandTimeout = 60;
        //    //MySqlDataReader dataReader;

        //    try
        //    {
        //        MySqlDataAdapter sda = new MySqlDataAdapter();
        //        sda.SelectCommand = cmdDataBase;
        //        DataTable dbdataset = new DataTable();
        //        studentlistGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //        studentlistGrid.RowTemplate.Height = 120;
        //        studentlistGrid.AllowUserToAddRows = false;

        //        sda.Fill(dbdataset);

        //        BindingSource bSource = new BindingSource();

        //        bSource.DataSource = dbdataset;
        //        studentlistGrid.DataSource = bSource;
        //        //sda.Update(dbdataset);

        //        DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
        //        imageColumn = (DataGridViewImageColumn)studentlistGrid.Columns[18];
        //        imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

        //        sda.Dispose();

        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}
        //----------------------------------

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

        private void studentAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(studentAttendance);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void studentAttendance()
        {
            Application.Run(new student_attendance());
        }

        private void studentListToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
