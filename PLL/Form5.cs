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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void insert_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png; *.gif)|*.jpg; .*png;*.gif;";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileInfo file = new System.IO.FileInfo(opf.FileName);
                Bitmap img = new Bitmap(opf.FileName);


                if (file.Length < 8192000)
                {
                    pictureBox1.Image = img;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if(file.Length > 8192000)
                {
                    MessageBox.Show("Image Size must be less than 8 MB");

                }
            }
        }
    }
}
