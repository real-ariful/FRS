using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApplication3.DAL;
using System.Windows.Forms;

namespace WindowsFormsApplication3.BLL
{
    public class ProfileBLL
    {
        public int GetProfile(string username, string password)
        {
            try
            {
                ProfileDAL objdal = new ProfileDAL();
                return objdal.ReadProfile(username, password);
            }
            catch (Exception )
            {
                return -1;
                //MessageBox.Show(ex.Message());
            }
        }
    }
}
