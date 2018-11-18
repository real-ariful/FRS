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
    public partial class non_broken : Form
    {
        Thread th;
        public non_broken()
        {
            {
                InitializeComponent();
                view();
            }
        }

        public void view()
        {

            //variables
            String id, picture;
            int count;
            Image img;

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=frs_garments;Convert Zero Datetime=True;SslMode = none;";
            MySqlConnection con = new MySqlConnection(connectionString);
            DataSet set = new DataSet();
            string query = "SELECT 	needleId, image FROM frs_needle";
            MySqlDataAdapter idData = new MySqlDataAdapter(query, con);
            try
            {
                con.Open();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            idData.Fill(set, "needleId");//confused about this line
            count = set.Tables[0].Rows.Count;
            studentlistGrid.AllowUserToAddRows = false;
            studentlistGrid.Columns.AddRange(new DataGridViewTextBoxColumn(), new DataGridViewImageColumn(), new DataGridViewTextBoxColumn(),
                new DataGridViewTextBoxColumn());
            //        DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            //        imageColumn = (DataGridViewImageColumn)studentlistGrid.Columns[18];
            //        imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            studentlistGrid.Columns[0].Name = "Needle Id";
            studentlistGrid.Columns[1].Name = "Picture";
            studentlistGrid.Columns[2].Name = "Machine Id";
            studentlistGrid.Columns[3].Name = "Machine Location";


            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)studentlistGrid.Columns[1];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //imageColumn.Width = 100;

            studentlistGrid.RowTemplate.Height = 100;

            for (int i = 0; i < count - 1; i++)
            {
                id = set.Tables[0].Rows[i][0].ToString();
                picture = set.Tables[0].Rows[i][1].ToString();
                img = Image.FromFile(set.Tables[0].Rows[i][1].ToString());

                string machineId = set.Tables[0].Rows[i][2].ToString();
                string machineLoc = set.Tables[0].Rows[i][2].ToString();


                //string[] data = new string[2];
                //for (int j = 0; j < 2; j++)
                //{
                //    data[j] = set.Tables[0].Rows[i][j].ToString();
                //}


                studentlistGrid.Rows.Add(id, img, machineId, machineLoc);

                studentlistGrid.ClearSelection();

            }
        }

    }
}