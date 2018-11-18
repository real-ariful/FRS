using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        #region UI Event Handlers
        private void button1_Click(object sender, EventArgs e)
  
        {
            string textBox2Contents = textBox2.Text.ToString();

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:5000/verify/face/search");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"user\":\"test\"," +
                              "\"password\":\"bla\"}";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                //Added
                debugOutput(result);
            }

            debugOutput(textBox2Contents);
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

    }
        #endregion
    }

