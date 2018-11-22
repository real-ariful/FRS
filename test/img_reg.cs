using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unirest_net.http;

namespace WindowsFormsApplication3.test
{
    public partial class img_reg : Form
    {
        private string filePath;
        public img_reg()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (student_name.Text != null)
            {
                try
                {
                    string s_name = student_name.Text;

                    //Train Album
                    byte[] image = ImageToBinary(@"C:\Users\user\Desktop\crop.png");
                    // These code snippets use an open-source library. http://unirest.io/net
                    // These code snippets use an open-source library. http://unirest.io/net
                    HttpResponse<string> response = Unirest.post("https://lambda-face-recognition.p.mashape.com/album_train")
                    .header("X-Mashape-Key", "43mMyTAnRnmshjV8yYJtfcKGeXH9p1Qz0GMjsnFp2mnbrDrpdb")
                    .field("album", "school_security")
                    .field("albumkey", "e912e986606952880210d58450f745cf00befd54d20bf6e6914ddd0fd8b24ff0")
                    .field("entryid", s_name)
                    .field("files", File.ReadAllBytes(filePath))
                    //.field("urls", "http://www.lambdal.com/tiger.jpg")
                    .asJson<string>();
                    MessageBox.Show(response.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        public static byte[] ImageToBinary(string _path)
        {
            FileStream fS = new FileStream(_path, FileMode.Open, FileAccess.Read);
            byte[] b = new byte[fS.Length];
            fS.Read(b, 0, (int)fS.Length);
            fS.Close();
            return b;
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void upload_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png; *.bmp)|*.jpg; .*png;*.bmp;";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileInfo file = new System.IO.FileInfo(opf.FileName);
                Bitmap img = new Bitmap(opf.FileName);


                if (file.Length < 8192000)
                {
                    pictureBox1.Image = img;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    filePath = opf.FileName;
                }
                else if (file.Length > 8192000)
                {
                    MessageBox.Show("Image Size must be less than 8 MB");

                }
            }
        }

        private void database_Click(object sender, EventArgs e)
        {
            // These code snippets use an open-source library. http://unirest.io/net
            HttpResponse<string> response2 = Unirest.get("https://lambda-face-recognition.p.mashape.com/album?album=school_security&albumkey=e912e986606952880210d58450f745cf00befd54d20bf6e6914ddd0fd8b24ff0")
            .header("X-Mashape-Key", "43mMyTAnRnmshjV8yYJtfcKGeXH9p1Qz0GMjsnFp2mnbrDrpdb")
            .header("Accept", "application/json")
            .asJson<string>();

            textBox1.Text = response2.Body;
            string body = response2.Body;
             dynamic json = JsonConvert.DeserializeObject(body);
            //Covert string to json object
            //JObject json = JObject.Parse(response2.ToString());
            //textBox1.Text = (string)json["entries"];
            //var res_db = JsonConvert.DeserializeObject<dynamic>(response2.ToString());
            //object resss = response2.ToString();
            ///var res_db = JsonConvert.DeserializeObject<dynamic>(resss.ToString());
            //Console.WriteLine(res_db["entries"]);
            // textBox1.Text =(String)json["entries"];//cannot convert array to string
            //int lengthA = json["entries"].Length;
            string followers = (string)json["entries"].ToString();
            textBox1.Text = "Total Length of images:"+followers;

        }

        //private string ExtractJsonResponse(string response)
        //{
        //    string json;
        //    using (var outStream = new MemoryStream())
        //    using (var zipStream = new GZipStream(response.GetResponseStream(),
        //        CompressionMode.Decompress))
        //    {
        //        zipStream.CopyTo(outStream);
        //        outStream.Seek(0, SeekOrigin.Begin);
        //        using (var reader = new StreamReader(outStream, Encoding.UTF8))
        //        {
        //            json = reader.ReadToEnd();
        //        }
        //    }
        //    return json;
        //}

        #region json funcrions

        private void deserialiseJSONdetect(string strJSON)
        {
            try
            {


                var det = JsonConvert.DeserializeObject<dynamic>(strJSON);
                // condition if image storage is successful
                if (det["result"] == "success")
                {
                    string quality_score = det["data"][0]["quality_score"];
                    string rect = det["success"][0]["rect"];
                    Console.WriteLine(rect);
                }
                else if (det["result"] == "error")
                {
                    MessageBox.Show("Error");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion
    }
}
