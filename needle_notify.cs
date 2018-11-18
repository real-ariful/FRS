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
    public partial class needle_notify : Form
    {
        public needle_notify()
        {
            InitializeComponent();
            view();
        }

        public void view()
        {
            //Shows all the database information
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=frs_garments;Convert Zero Datetime=True;SslMode = none;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            string query = "SELECT * FROM needle_notify";
            MySqlCommand cmdDataBase = new MySqlCommand(query, databaseConnection);
            cmdDataBase.CommandTimeout = 60;
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                notifyGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                notifyGrid.RowTemplate.Height = 120;
                notifyGrid.AllowUserToAddRows = false;

                sda.Fill(dbdataset);

                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                notifyGrid.DataSource = bSource;
                //sda.Update(dbdataset);
                //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                //imageColumn = (DataGridViewImageColumn)notifyGrid.Columns[18];
                //imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                sda.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
