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
    public partial class garment_mainpage : Form
    {
        Thread th;
        public garment_mainpage()
        {
            InitializeComponent();
        }

        private void nonBrokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(nonBroken);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void nonBroken()
        {
            Application.Run(new non_broken());
        }

        private void databaseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(needleNotify);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void needleNotify()
        {
            Application.Run(new needle_notify());
        }
    }
}
