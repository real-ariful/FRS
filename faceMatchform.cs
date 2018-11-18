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
    public partial class faceMatchform : Form
    {
        public faceMatchform()
        {
            InitializeComponent();

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=frs_school;Convert Zero Datetime=True;";
            string query = "SELECT * FROM frs_captureresult";

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
                faceMatchGrid.DataSource = bSource;
                sda.Update(dbdataset);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
