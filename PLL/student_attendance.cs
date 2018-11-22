using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class student_attendance : Form
    {
        public student_attendance()
        {
            InitializeComponent();
            view();
        }

        //-----------------------------testing code view
        //This code works and shows images
        //-------------------testing codes

        public void view()
        {


            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=frs_school;Convert Zero Datetime=True;SslMode = none;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            string query = "SELECT * FROM frs_attendance";
            MySqlCommand cmdDataBase = new MySqlCommand(query, databaseConnection);
            cmdDataBase.CommandTimeout = 60;
            //MySqlDataReader dataReader;

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                studentAttGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                studentAttGrid.RowTemplate.Height = 120;
                studentAttGrid.AllowUserToAddRows = false;

                sda.Fill(dbdataset);

                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                studentAttGrid.DataSource = bSource;
                //sda.Update(dbdataset);

                //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                //imageColumn = (DataGridViewImageColumn)studentAttGrid.Columns[18];
                // imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

                sda.Dispose();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //----------------------------------


        ////variables
        //String id, picture;
        //int count;
        //Image img;
        //Bitmap blankImg;

        //string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=frs_school;Convert Zero Datetime=True;SslMode = none;";
        //MySqlConnection con = new MySqlConnection(connectionString);
        //DataSet set = new DataSet();
        //string query = "SELECT student_id, student_image, first_name, last_name, email_address, phone_number, address,father_name, mother_name, city, country FROM frs_student";
        //MySqlDataAdapter idData = new MySqlDataAdapter(query, con);
        //try
        //{
        //    con.Open();
        //}
        //catch (Exception excep)
        //{
        //    MessageBox.Show(excep.Message);
        //}
        //idData.Fill(set, "student_id");//confused about this line
        //count = set.Tables[0].Rows.Count;
        //studentAttGrid.Columns.AddRange(new DataGridViewTextBoxColumn(), new DataGridViewTextBoxColumn(), new DataGridViewTextBoxColumn(), new DataGridViewTextBoxColumn(),
        //    new DataGridViewTextBoxColumn());

        //studentAttGrid.Columns[0].Name = "Attendance ID";
        //studentAttGrid.Columns[1].Name = "Datetime";
        //studentAttGrid.Columns[2].Name = "Student ID";
        //studentAttGrid.Columns[3].Name = "Student Name";
        //studentAttGrid.Columns[4].Name = "Class";

        ////DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)studentlistGrid.Columns[1];
        ////imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        ////imageColumn.Width = 100;


        //studentAttGrid.RowTemplate.Height = 100;
        //string[] data = new string[5];
        //for (int i = 0; i < count - 1; i++)
        //{
        //    //id = set.Tables[0].Rows[i][0].ToString();
        //    //picture = set.Tables[0].Rows[i][1].ToString();
        //    //img = Image.FromFile("C:\\xampp\\htdocs\\frs2018\\" + picture.ToString());
        //    //string[] data = new string[11];
        //    for (int j = 0; j < 5; j++)
        //    {
        //        data[j] = set.Tables[0].Rows[i][j].ToString();
        //    }


        //    studentAttGrid.Rows.Add(data[0], data[1], data[2], data[3], data[4]);

        //    studentAttGrid.ClearSelection();

        //}
        //}




        //------------------finishing----------------------------------



        //Shows all the database information

    }
}
