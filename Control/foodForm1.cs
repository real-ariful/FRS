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
using WindowsFormsApplication3.PLL;

namespace WindowsFormsApplication3.PLL
{
    public partial class foodForm1 : Form
    {
        private Thread th;

        //private FirstCustomControl firstCustomControl1 = new FirstCustomControl();
        //private MySecondControl mySecondCustmControl1 = new MySecondControl();
        public foodForm1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            //firstCustomControl2.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomControl2.BringToFront();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            mySecondCustmControl1.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            //camera_dashboard MyNewForm = new camera_dashboard();
            //MyNewForm.ShowDialog();
            cam_das1.BringToFront();//does not work needs to be shown on top at begining

            //cam_das1.BringToFront();
        }


        //private void cam()
        //{
        //    Application.Run(new camera_dashboard());
        //}
    }
}
