using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApplication3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            load_table();
        }




        private void show_employee_table_Click(object sender, EventArgs e)
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employees;";
            string query = "SELECT emp_id,firstName, lastName, age FROM employee_charp";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand cmdDataBase = new MySqlCommand(query, databaseConnection);
            cmdDataBase.CommandTimeout = 60;
            //MySqlDataReader dataReader;

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }


        void load_table()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employees;";
            string query = "SELECT * FROM employee_charp";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand cmdDataBase = new MySqlCommand(query, databaseConnection);
            cmdDataBase.CommandTimeout = 60;
            //MySqlDataReader dataReader;

            try
            {
                MySqlDataAdapter sda2 = new MySqlDataAdapter();
                sda2.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda2.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView2.DataSource = bSource;
                sda2.Update(dbdataset);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void update_employee_table_Click(object sender, EventArgs e)
        {

 

        }

        private void update_Click(object sender, EventArgs e)
        {
            string firstName = textBox2.Text.ToString();
            string lastName = textBox3.Text.ToString();
            string agee = textBox4.Text.ToString();

            SaveUser();

            //string insert_data = "insert into employee_charp() values ()";

        }

        private void SaveUser()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employees;";
            string query = "INSERT INTO employee_charp(`emp_id`,`firstName`, `lastName`, `age`) VALUES (NULL, '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";

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
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void show_image_Click(object sender, EventArgs e)
        {
            MySQL_ToDatagridview4();
        }


  





    
        private void MySQL_ToDatagridview4()
        {
            Bitmap def;

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=frs_school;";
            //string query = "INSERT INTO employee_charp(`emp_id`,`firstName`, `lastName`, `age`) VALUES (NULL, '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";

            MySqlConnection mcon = new MySqlConnection(connectionString);
            //MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            //commandDatabase.CommandTimeout = 60;

            showImageGrid.Columns.Clear();
            mcon.Close();
            mcon.Open();
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT student_id,first_name, student_image from frs_student";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mcon);
            DataTable table = new DataTable();
            MyDA.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            this.showImageGrid.DataSource = bSource;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Pic";
            showImageGrid.Columns.Insert(0, imageColumn);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                try
                {
                    String pic = table.Rows[i]["student_image"].ToString();
                    pic = @"C:\\xampp\\htdocs\\frs2018\\" + pic;
                    //Byte[] bitmapData = Convert.FromBase64String(FixBase64ForImage(pic));
                    // System.IO.MemoryStream streamBitmap = new System.IO.MemoryStream(bitmapData);
                    //Byte[] bitmapData = Convert.FromBase64String(FixBase64ForImage(pic));
                    //System.IO.MemoryStream streamBitmap = new System.IO.MemoryStream(bitmapData);
                    debugOutput(pic);

                    //def = new Bitmap(@+pic);

                    //pic = @"C:\xampp\htdocs\frs2018\db\students\students\AZM Ariful Haque Real.jpg";
                    def = new Bitmap(pic);
                    //def = new Bitmap((Bitmap)Image.FromStream(pic));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.StackTrace);
                }
                //string pic2 = @"C:\xampp\htdocs\frs2018\db\students\AZM Ariful Haque Real.jpg";
                //def = new Bitmap(pic2);
                //showImageGrid.Rows[i].Cells[0].Value = def;
            }
            showImageGrid.Columns.Remove("student_image");
            foreach (DataGridViewRow row in showImageGrid.Rows)
            {
                row.Height = 110;
            }
            foreach (DataGridViewColumn col in showImageGrid.Columns)
            {
                col.Width = 110;
            }

            for (int i = 0; i < showImageGrid.ColumnCount; i++)
            {
                showImageGrid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                showImageGrid.AutoResizeColumns();
                showImageGrid.Columns[i].DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 8F, FontStyle.Bold);
            }
            mcon.Close();
        }


        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                textBox1.Text = textBox1.Text + strDebugText + Environment.NewLine;
                textBox1.SelectionStart = textBox1.TextLength;
                textBox1.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private void showImageGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

