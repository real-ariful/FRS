using Emgu.CV;
using Emgu.CV.Structure;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3.PLL
{
    public partial class studentLocation : Form
    {
        public studentLocation()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() => {
                while (true)
                {

                    string imagePath = @"C:\\xampp\\htdocs\\frs2018\\db\\floor\\floor14.jpg";
                    Image imag = Image.FromFile(imagePath);

                    System.IO.FileInfo file = new System.IO.FileInfo(imagePath);
                    Bitmap img = new Bitmap(imagePath);

                    pictureBox1.Invoke(new Action(() => pictureBox1.Image = img));
                    pictureBox1.Invoke(new Action(() => pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage));



                    Image<Bgr, Byte> CapturedImage = new Emgu.CV.Image<Bgr, byte>(imagePath);
                    Rectangle rec = new Rectangle(15, 650, 10, 10);
                    CapturedImage.Draw(rec, new Bgr(Color.Red), 2);//accepts byte array
                    CvInvoke.Resize(CapturedImage, CapturedImage, new Size(pictureBox1.Width, pictureBox1.Height), 0, 0, Emgu.CV.CvEnum.Inter.Linear);

                    pictureBox1.Invoke(new Action(() => pictureBox1.Image = CapturedImage.Bitmap));


                    //Rectangle rect=new Rectangle (150,650,6,6);
                    ////Rectangle rect2 = new Rectangle(100, 100, 5, 5);
                    //using (Graphics gfx = Graphics.FromImage(this.pictureBox1.Image))
                    //{
                    //    gfx.DrawEllipse(Pens.Blue, rect);
                    //    this.pictureBox1.Refresh();
                    //}

                    //SQL Connection
                    try
                    {
                        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=frs_school;SslMode = none;";
                        MySqlConnection mcon = new MySqlConnection(connectionString);
                        mcon.Open();
                        MySqlDataAdapter MyDA = new MySqlDataAdapter();

                        string sqlSelectAll = "SELECT bleuid,ble_location from frs_blelocation";
                        MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mcon);
                        DataTable table = new DataTable();
                        MyDA.Fill(table);
                        BindingSource bSource = new BindingSource();
                        bSource.DataSource = table;

                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            string b_location = table.Rows[i]["ble_location"].ToString();
                            Console.Write(table.Rows[i]["ble_location"]);
                            string[] splitString = b_location.Split('(', ',', ')');//separates into 0,1,2
                            Console.WriteLine("BLE X-Value: " + splitString[1]);//gives the x values
                            Console.WriteLine("BLE y-Value: " + splitString[2]);//gives the y values
                            int x = Convert.ToInt32(splitString[1]);
                            int y = Convert.ToInt32(splitString[2]);

                            Rectangle newrect = new Rectangle(x, y, 6, 6);
                            //Rectangle rect2 = new Rectangle(100, 100, 5, 5);
                            using (Graphics gfx = Graphics.FromImage(pictureBox1.Image))//shows error--> object is used somewhere else
                            {
                                gfx.DrawEllipse(Pens.Blue, newrect);
                            }
                        }
                        pictureBox1.Invoke(new Action(() => pictureBox1.Refresh()));
                        mcon.Close();
                        
                    }
                    catch (Exception )
                    {
                        //MessageBox.Show(ex.ToString());
                    }
                }
  
            });
            
        }

        private void bLELocationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
