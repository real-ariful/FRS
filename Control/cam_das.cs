using MySql.Data.MySqlClient;
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
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;

using Emgu;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Net.Http;
using WindowsFormsApplication3.PLL;

namespace WindowsFormsApplication3.Control
{
    public partial class cam_das : UserControl
    {
        Thread th;
        Capture capture;
        Capture capture2;
        Capture capture3;
        Capture capture4;

        Boolean flagCapture = false;
        Boolean flagCapture2 = false;
        Boolean flagCapture3 = false;
        Boolean flagCapture4 = false;

        Image returnImage;
        Mat myNewMat;

        private byte[] image;
        private object img;
        Image<Bgr, Byte> frame;
        Capture camera;
        Emgu.CV.Image<Bgr, byte> masterImage;
        public cam_das()
        {

            InitializeComponent();
        }
        private void Capture_ImageGrabbed2(object sender, EventArgs e)
        {//hangs if camera not available
            try
            {
                Mat m2 = new Mat();
                capture2.Retrieve(m2);

                if (!m2.IsEmpty)
                {
                    flagCapture = true;
                    Console.WriteLine(flagCapture);
                    CvInvoke.Resize(m2, m2, new Size(pictureBox2.Width, pictureBox2.Height), 0, 0, Emgu.CV.CvEnum.Inter.Linear);
                    //pictureBox3.Image = m2.ToImage<Bgr, byte>().Bitmap;
                    pictureBox2.Image = m2.ToImage<Bgr, byte>().Bitmap;
                    //pictureBox4.Image = m2.ToImage<Bgr, byte>().Bitmap;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void Capture_ImageGrabbed3(object sender, EventArgs e)
        {
            try
            {
                Mat m3 = new Mat();
                capture3.Retrieve(m3);

                if (!m3.IsEmpty)
                {
                    flagCapture3 = true;
                    Console.WriteLine(flagCapture3);
                    CvInvoke.Resize(m3, m3, new Size(pictureBox3.Width, pictureBox3.Height), 0, 0, Emgu.CV.CvEnum.Inter.Linear);
                    pictureBox3.Image = m3.ToImage<Bgr, byte>().Bitmap;
                    pictureBox2.Image = m3.ToImage<Bgr, byte>().Bitmap;
                    pictureBox4.Image = m3.ToImage<Bgr, byte>().Bitmap;
                }

            }
            catch (Exception)
            {

            }
        }


        private async void Capture_ImageGrabbed4(object sender, EventArgs e)
        {
            try
            {
                Mat m4 = new Mat();
                capture4.Retrieve(m4);
                if (!m4.IsEmpty)
                {
                    flagCapture4 = true;
                    Console.WriteLine(flagCapture4);
                    CvInvoke.Resize(m4, m4, new Size(pictureBox4.Width, pictureBox4.Height), 0, 0, Emgu.CV.CvEnum.Inter.Linear);
                    pictureBox4.Image = m4.ToImage<Bgr, byte>().Bitmap;
                    double fps = capture2.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);//
                    await Task.Delay(1000);//
                }
            }
            catch (Exception)
            {

            }
        }

        private void Capture_ImageGrabbed4new(object sender, EventArgs e)
        {
            try
            {
                Mat m4 = new Mat();
                capture4.Retrieve(m4);

                //Show image on picturebox4
                flagCapture4 = true;
                CvInvoke.Resize(m4, m4, new Size(pictureBox4.Width, pictureBox4.Height), 0, 0, Emgu.CV.CvEnum.Inter.Linear);
                pictureBox4.Image = m4.ToImage<Bgr, byte>().Bitmap;

                //Save Image in folder
                string imagePathe = "C:\\Real_23092018\\Desktop\\Real_DMA\\Flask_Blog\\flaskblog\\campics\\";
                imagePathe = imagePathe + "cam1.jpg";
                m4.Save(imagePathe);//Save image in folder    

                Image<Bgr, Byte> imgnew4 = m4.ToImage<Bgr, Byte>();

                try//first try begins
                {
                    var httpcam1 = (System.Net.HttpWebRequest)WebRequest.Create("http://127.0.0.1:5000/cam1");
                    httpcam1.ContentType = "multipart/form-data";
                    httpcam1.Method = "POST";

                    using (var streamWriter = new StreamWriter(httpcam1.GetRequestStream()))
                    {
                        streamWriter.Write(imagePathe);
                        streamWriter.Flush();
                        streamWriter.Close();
                    }

                    var httprescam1 = (HttpWebResponse)httpcam1.GetResponse();
                    using (var streamReader = new StreamReader(httprescam1.GetResponseStream()))
                    {
                        var resultcam1 = streamReader.ReadToEnd();
                        var detnew1 = JsonConvert.DeserializeObject<dynamic>(resultcam1);
                        if (detnew1["result"] == "success")
                        {
                            JArray items3 = (JArray)detnew1["data"];
                            //JArray rect = (JArray)detnew1["rect"];

                            int length3 = items3.Count;
                            string[] nameArray = new string[length3];
                            float[] scoreArray = new float[length3];
                            for (int j = 0; j < length3; j++)
                            {
                                var name = items3[j]["playload"]["filename"];
                                string name2 = name.ToString();
                                char[] delimiters = { '.' };
                                nameArray[j] = name2.Split(delimiters)[0];
                                scoreArray[j] = (float)items3[j]["score"];
                            }
                            //Function to find the location of maximum score
                            float maximum = scoreArray[0];
                            int location = 0;
                            for (int c = 1; c < length3; c++)
                            {
                                if (scoreArray[c] > maximum)
                                {
                                    maximum = scoreArray[c];
                                    location = c;
                                }
                            }

                            //Console.WriteLine(rect[0]);
                            //Console.WriteLine(rect[1]);
                            //Console.WriteLine(rect[2]);
                            //Console.WriteLine(rect[3]);

                            Rectangle rec = new Rectangle((int)detnew1["rect"][0], (int)detnew1["rect"][1], (int)detnew1["rect"][2], (int)detnew1["rect"][3]);

                            imgnew4.Draw(rec, new Bgr(Color.Red), 1);//accepts byte array
                                                                     //  CvInvoke.Resize(masterImage, masterImage, new Size(pictureBox1.Width, pictureBox1.Height), 0, 0, Emgu.CV.CvEnum.Inter.Linear);
                                                                     //Insert face search text on the image
                            CvInvoke.Resize(imgnew4, imgnew4, new Size(pictureBox1.Width, pictureBox1.Height), 0, 0, Emgu.CV.CvEnum.Inter.Linear);
                            //putText(img, text, org, fontFace, fontScale, Scalar color, int thickness)
                            CvInvoke.PutText(imgnew4, nameArray[location], new Point(40, 40), FontFace.HersheySimplex, 1.0, new Bgr(Color.Blue).MCvScalar);
                            pictureBox4.Image = imgnew4.ToBitmap();
                            Thread.Sleep(500);



                            //--string img_item1 = @"C:/Real_23092018/Desktop/Real_DMA/Flask_Blog/flaskblog/campics/crop1.jpg";
                            //--Image mnew1 = Image.FromFile(img_item1);

                            ////mnew1.retrieve(matnew1);
                            //Mat mnew = mnew1.ToImage<Bgr, Byte>();

                            //CvInvoke.Resize(mnew, mnew, new Size(pictureBox4.Width, pictureBox4.Height), 0, 0, Emgu.CV.CvEnum.Inter.Linear);
                            ////pictureBox4.Image = mnew1.ToImage<Bgr, byte>().Bitmap;
                            //Image<Bgr, Byte> imgeOrigenal = mnew1.ToImage<Bgr, Byte>();

                            //Image img = Image.FromFile(img_item1);
                            //Mat imgMat = new Mat();
                            //imgMat = GetMatFromSDImage(img);
                            //Bitmap GraphicsImage = (Bitmap)Image.FromFile(img_item1);
                            //GraphicsImage.ToMat();
                            //Mat mnew = new Mat();
                            //GraphicsImage.Retrieve(m4);
                            //CvInvoke.Resize(mnew, mnew, new Size(pictureBox4.Width, pictureBox4.Height), 0, 0, Emgu.CV.CvEnum.Inter.Linear);


                            //--pictureBox4.Image = new Bitmap(mnew1);//gets problem here
                        }
                    }
                }
                catch (Exception e2)
                {
                    //-----------------commented
                    //MessageBoxEx.Show("Message first try" + e2.Message, 1000);
                    //MessageBox.Show("Message first try"+e2.Message);
                }

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message second try" + ex.Message);
            }
        }

        async static void PostRequest(string url)
        {
            using (HttpClient client = new System.Net.Http.HttpClient())
            {
                IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("query1","jamal"),
                    new KeyValuePair<string, string>("query2","hussain")
                };
                HttpContent q = new FormUrlEncodedContent(queries);
                using (HttpResponseMessage response = await client.PostAsync(url, q))
                {
                    using (HttpContent content = response.Content)
                    {
                        string myconteny = await content.ReadAsStringAsync();

                        Console.WriteLine(myconteny);
                    }

                }
            }
        }

        private void Capture_ImageGrabbed1(object sender, EventArgs e)
        {

            //Datagridview initialization-" Cross-thread operation not valid: Control 'dataGridView1' accessed from a thread other than the thread it was created on.

            //dataGridView1.ColumnCount = 2;

            //dataGridView1.Rows.Clear();
            //dataGridView1.RowTemplate.Height = 100;
            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.Columns[0].Name = "Date Time & Person";
            // dataGridView1.Columns[0].Width = 100;
            //dataGridView1.Columns[1].Name = "Image";
            //dataGridView1.Columns[1].Width = 100;

            //-----------------------------------
            try//first try begins
            {
                string dtnow = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                Mat m = new Mat();
                capture.Retrieve(m);


                string imagePathe = "C:\\Users\\user\\Desktop\\filename.png";

                m.Save(imagePathe);//Save image in desktop          

                CvInvoke.Resize(m, m, new Size(pictureBox1.Width, pictureBox1.Height), 0, 0, Emgu.CV.CvEnum.Inter.Linear);
                pictureBox1.Image = m.ToImage<Bgr, byte>().Bitmap;

                //Bitmap cap = m.ToImage<Bgr, byte>().Bitmap;
                //Image< Bgr, byte> ImgInput  = new Image<Bgr, byte>("C:\\Users\\user\\Desktop\\filename.png");
                //Convert image to binary using fnc

                string imagePath = @"C:\\Users\\user\\Desktop\\filename.png";
                Console.WriteLine(imagePath);
                //Convert image to binary using fnc
                image = ImageToBinary(imagePath);
                //Creatign an array for file
                string[] file;
                file = new string[1] { imagePath };


                List<string> imgs = new List<string>();
                foreach (string pathe in file)
                {
                    imgs.Add(("imageDatas" + ", (" + pathe + "," + ImageToBinary(pathe) + ")"));
                }

                // ------------------------------------Sending data to Server------------------------------------------------------------------
                try//second try begins
                {

                    var httpWebRequest = (System.Net.HttpWebRequest)WebRequest.Create("http://127.0.0.1:5000/verify/face/detectAndQuality");
                    httpWebRequest.ContentType = "multipart/form-data";
                    httpWebRequest.Method = "POST";

                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        //string param = "{\"user\":\"test\" }";
                        string json = "{\"imageData\":" + image + "}";
                        streamWriter.Write(imgs);
                        streamWriter.Flush();
                        streamWriter.Close();
                        Console.WriteLine(imgs);
                    }

                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {

                        var result = streamReader.ReadToEnd();

                        var det = JsonConvert.DeserializeObject<dynamic>(result);
                        //    det_res =   {
                        //        "result":"success",
                        //                  "data":[{         "quality_score":93,
                        //                                    "rect":[110,128,314,332]        }
                        //Console.WriteLine(det);
                        if (det["result"] == "success")
                        {
                            JArray items2 = (JArray)det["data"];
                            int length2 = items2.Count;
                            for (int i = 0; i < length2; i++)
                            {
                                //foreach (Rectangle Rect in Rectangles)
                                // {
                                //     CapturedImage.Draw(Rect, new Bgr(Color.Red), 2);
                                // }
                                Console.WriteLine(i);//works

                                string quality_score = items2[i]["quality_score"].ToString();//works
                                string rect = items2[i]["rect"].ToString();
                                int rect_left = (int)items2[i]["rect"][0];
                                int rect_right = (int)items2[i]["rect"][1];
                                int rect_top = (int)items2[i]["rect"][2];
                                int rect_bottom = (int)items2[i]["rect"][3];
                                // Console.WriteLine(i);
                                Console.WriteLine(quality_score);//works
                                Console.WriteLine(rect);
                                //}



                                //nwe test

                                //string fileName = imagePath;
                                //int width = 640;
                                //int height = 480;

                                // Bitmap bitmap = new Bitmap(
                                //      width, height,
                                //      System.Drawing.Imaging.PixelFormat.Format24bppRgb); // or some other format
                                //using (Graphics graphics = Graphics.FromImage(bitmap))
                                //  {
                                //using (System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red))
                                //  {
                                //      graphics.FillRectangle(myBrush, new Rectangle(0, 0, 20, 200)); // whatever
                                // and so on...
                                //  } // works with red solid rectanle but gives black
                                //   bitmap.Save(fileName);
                                // }
                                // pictureBox1.Image = bitmap;
                                // Console.WriteLine("rectnage");// graphics will be disposed at this line
                                //...




                                //new test
                                //if imagePathe used we get black flashing of image ,String ima = "C:\\Users\\user\\Desktop\\arifulhaque.jpg";

                                FileInfo fileInfo = new FileInfo(imagePathe);
                                //Bitmap masterImage = (Bitmap)pictureBox1.Image;
                                Image<Bgr, Byte> imgnew = m.ToImage<Bgr, Byte>();
                                //Emgu.CV.Image<Bgr, byte> 
                                masterImage = imgnew;


                                //Image<Bgr, Byte> CapturedImage = new Emgu.CV.Image<Bgr, byte>(imagePathe);
                                // The byte[] to save the data in System.Drawing.Image
                                //ImageToByteArray(imagePathe);
                                //byte[] xxx = new byte[fileInfo.Length];
                                //Image<Bgr, Byte> CapturedImage = xxx.ToImage<Bgr, Byte>();

                                //Capture capture = new Emgu.CV.Capture(0);
                                //Bitmap tmp = capture.getBitmap();
                                //Image<Bgr, Byte> img = new Image<Bgr, Byte>(tmp);
                                //imageBox1.Image = img;

                                //    Image<Bgr, Byte> CapturedImage = capture.QueryFrame().ToImage<Bgr, Byte>();
                                //Bitmap tmp = CapturedImage.getBitmap();


                                Rectangle rec = new Rectangle(rect_left, rect_right, rect_top, rect_bottom);

                                masterImage.Draw(rec, new Bgr(Color.Red), 1);//accepts byte array
                                CvInvoke.Resize(masterImage, masterImage, new Size(pictureBox1.Width, pictureBox1.Height), 0, 0, Emgu.CV.CvEnum.Inter.Linear);
                                pictureBox1.Image = masterImage.ToBitmap();
                                //Image<Bgr, byte>.Draw();
                                //Console.WriteLine(rec.ToString());
                                //pictureBox1.Image = m.ToImage<Bgr, byte>().Bitmap;
                            }

                            //-----------------------Facial Attribute Extraction from a Single Image--------------------------------#

                            try//third try begins
                            {
                                var httpWebRequest2 = (System.Net.HttpWebRequest)WebRequest.Create("http://127.0.0.1:5000/verify/attribute/gets");
                                httpWebRequest2.ContentType = "multipart/form-data";
                                httpWebRequest2.Method = "POST";

                                using (var streamWriter2 = new StreamWriter(httpWebRequest2.GetRequestStream()))
                                {
                                    //string param = "{\"user\":\"test\" }";
                                    string imgs2 = "{\"imageData\":" + image + "}";
                                    streamWriter2.Write(imgs2);
                                    streamWriter2.Flush();
                                    streamWriter2.Close();
                                }

                                var httpResponse2 = (HttpWebResponse)httpWebRequest2.GetResponse();
                                using (var streamReader2 = new StreamReader(httpResponse2.GetResponseStream()))
                                {
                                    var result2 = streamReader2.ReadToEnd();
                                    var det2 = JsonConvert.DeserializeObject<dynamic>(result2);
                                    if (det2["result"] == "success")
                                    {
                                        //det_agets =  {                "result":"success", 
                                        //                                "data":{
                                        //                                    "age":27, "gender":0,
                                        //                                    "attractive":90, "eyeglass":0, 
                                        //                                    "sunglass":0, "smile":0, 
                                        //                                    "mask":0, "race":0,
                                        //                                    "eyeOpen":1, "mouthOpen":0, "beard":0
                                        //                                }}

                                        string age = det2["data"]["age"].ToString();
                                        string gender = det2["data"]["age"].ToString();
                                        string attractive = det2["data"]["age"].ToString();
                                        string smile = det2["data"]["age"].ToString();
                                        string mask = det2["data"]["age"].ToString();
                                        string race = det2["data"]["age"].ToString();
                                        string eyeOpen = det2["data"]["age"].ToString();
                                        string mouthOpen = det2["data"]["age"].ToString();
                                        string beard = det2["data"]["age"].ToString();

                                        Console.WriteLine("Attribute Age" + age);//works

                                        //----------------------------------------------------1:N Face Search --------------------------------------------

                                        try//fourth try begins
                                        {
                                            var httpWebRequest3 = (System.Net.HttpWebRequest)WebRequest.Create("http://127.0.0.1:5000/verify/face/search");
                                            httpWebRequest3.ContentType = "multipart/form-data";
                                            httpWebRequest3.Method = "POST";

                                            using (var streamWriter3 = new StreamWriter(httpWebRequest3.GetRequestStream()))
                                            {
                                                string param = "{\"dbName\":\"test\",\"topNum\":6,\"score\":0.5}";
                                                string imgs3 = "{\"imageData\":" + image + "}";
                                                streamWriter3.Write(imgs3);
                                                streamWriter3.Flush();
                                                streamWriter3.Close();
                                            }

                                            var httpResponse3 = (HttpWebResponse)httpWebRequest3.GetResponse();
                                            using (var streamReader3 = new StreamReader(httpResponse3.GetResponseStream()))
                                            {
                                                var result3 = streamReader3.ReadToEnd();
                                                var det3 = JsonConvert.DeserializeObject<dynamic>(result3);
                                                if (det3["result"] == "success")
                                                {

                                                    //                                            {
                                                    //                                                face_search =  {
                                                    //                                                    "result":"success", 
                                                    //                     "feature":"9de6a93ed542417b90b1a6185c2a45b5", 
                                                    //                     "rect":[39,72,137,170], "quality":"79.21", 
                                                    //                     "data":[{ 
                                                    //                                "imageId":"9de6a93ed542417b90b1a6185c2a45b5",
                                                    //                                "score":0.7,
                                                    //                                "dbId":"test",
                                                    //                                "pid":"9de6a93ed542417b90b1a6185c2a45b5",
                                                    //                                "playload":{ "filename":"abcde.jpg" }
                                                    //}, 
                                                    //                            {   "imageId":"cc5a25d52ec04fc6be6c43b51c48600f", 
                                                    //                                "score":0.82, 
                                                    //                                "dbId":"test", 
                                                    //                                "pid":"cc5a25d52ec04fc6be6c43b51c48600f", 
                                                    //                                "playload":{ "filename":"abcde.png" } },
                                                    //                             { "imageId":"da1f8fdd66b64baba796a3a33d775fa5", 
                                                    //                                "score":0.99,
                                                    //                                "dbId":"test",
                                                    //                                "pid":"da1f8fdd66b64baba796a3a33d775fa5", 
                                                    //                                "playload":{ "filename":"ariful.jpg" } }] }

                                                    JArray items3 = (JArray)det3["data"];
                                                    int length3 = items3.Count;
                                                    string[] nameArray = new string[length3];
                                                    float[] scoreArray = new float[length3];
                                                    for (int j = 0; j < length3; j++)
                                                    {
                                                        var name = items3[j]["playload"]["filename"];
                                                        string name2 = name.ToString();
                                                        char[] delimiters = { '.' };
                                                        nameArray[j] = name2.Split(delimiters)[0];
                                                        //Console.WriteLine(nameArray[0]);
                                                        scoreArray[j] = (float)items3[j]["score"];
                                                    }
                                                    //Function to find the location of maximum score
                                                    float maximum = scoreArray[0];
                                                    int location = 0;
                                                    for (int c = 1; c < length3; c++)
                                                    {
                                                        if (scoreArray[c] > maximum)
                                                        {
                                                            maximum = scoreArray[c];
                                                            location = c;
                                                        }
                                                    }
                                                    //Insert face search text on the image
                                                    //masterImage.Draw("Ariful");//accepts byte array
                                                    CvInvoke.Resize(masterImage, masterImage, new Size(pictureBox1.Width, pictureBox1.Height), 0, 0, Emgu.CV.CvEnum.Inter.Linear);
                                                    //putText(img, text, org, fontFace, fontScale, Scalar color, int thickness)
                                                    CvInvoke.PutText(masterImage, nameArray[location], new Point(40, 40), FontFace.HersheySimplex, 1.0, new Bgr(Color.Blue).MCvScalar);
                                                    pictureBox1.Image = masterImage.ToBitmap();


                                                    //----------------------------------------------------
                                                    //Croppign an image from the main image
                                                    myNewMat = new Mat(m, new Rectangle(120, 80, 150, 150));
                                                    string NewPath = "C:\\Users\\user\\Desktop\\cropImage.png";
                                                    myNewMat.Save(NewPath);

                                                    Bitmap neww = myNewMat.Bitmap;//works


                                                    //DataGridview1 workings
                                                    //Doesnot work for crop image------------------------------------
                                                    dataGridView1.Invoke(new Action(() => dataGridView1.Rows.Clear()));
                                                    int count = 1;
                                                    //dataGridView1.Columns.AddRange(new DataGridViewTextBoxColumn(), new DataGridViewImageColumn());
                                                    //dataGridView1.Columns[0].Name = "Date";
                                                    //dataGridView1.Columns[1].Name = "Picture";


                                                    DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[1];
                                                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                                                    //imageColumn.Width = 100;
                                                    dataGridView1.Invoke(new Action(() => dataGridView1.RowTemplate.Height = 100));//gives just system.string and image

                                                    // for (int i = 0; i < count; i++)
                                                    // {
                                                    string[] dateee = new string[] { DateTime.Now.ToString("HH:mm:ss tt") + ": " + nameArray[location].ToString() };
                                                    string dtname = DateTime.Now.ToString("HH:mm:ss tt") + ": " + nameArray[location].ToString();
                                                    img = Image.FromFile("C:\\Users\\user\\Desktop\\Capture2.png");

                                                    dataGridView1.Invoke(new Action(() => dataGridView1.Rows.Add(dtname, img)));
                                                    dataGridView1.Invoke(new Action(() => dataGridView1.ClearSelection()));

                                                    //}

                                                    //-------------------------Attendance Management-------------------------
                                                    string personid = items3[location]["pid"].ToString();
                                                    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=frs_school;SslMode = none;";
                                                    string c_query = "SELECT COUNT(pid) FROM frs_attendance WHERE pid ='" + personid + "'" + " AND CAST(datetime AS DATE) = '" + date + "'";

                                                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                                                    MySqlCommand commandDatabase = new MySqlCommand(c_query, databaseConnection);
                                                    commandDatabase.CommandTimeout = 60;
                                                    int newcount;
                                                    try
                                                    {
                                                        string fname; string sid; string cls; string peid;
                                                        databaseConnection.Open();
                                                        //MySqlDataReader myReader = commandDatabase.ExecuteReader();
                                                        newcount = Convert.ToInt32(commandDatabase.ExecuteScalar());

                                                        databaseConnection.Close();

                                                        if (newcount == 0)
                                                        {
                                                            //MessageBox.Show(newcount.ToString());//delete
                                                            string iquery = "SELECT full_name, student_id,class,personId FROM `frs_image` WHERE personId = '" + personid + "'";

                                                            MySqlConnection dbConnection = new MySqlConnection(connectionString);
                                                            MySqlCommand cmdDatabase = new MySqlCommand(iquery, databaseConnection);
                                                            cmdDatabase.CommandTimeout = 60;

                                                            try
                                                            {
                                                                databaseConnection.Open();
                                                                MySqlDataReader myReader2 = cmdDatabase.ExecuteReader();
                                                                while (myReader2.Read())
                                                                {
                                                                    fname = myReader2["full_name"].ToString();
                                                                    sid = myReader2["student_id"].ToString();
                                                                    cls = myReader2["class"].ToString();
                                                                    peid = myReader2["personId"].ToString();
                                                                    //}
                                                                    //databaseConnection.Close();
                                                                    //MessageBox.Show("Time:" + dtnow);
                                                                    //MessageBox.Show(fname);
                                                                    //MessageBox.Show(sid);
                                                                    //MessageBox.Show(cls);
                                                                    //MessageBox.Show(peid);
                                                                    //Insert info into frs_attendance Table

                                                                    string aquery = "INSERT INTO frs_attendance(`datetime`,`studentid`,`studentName`,`pid`,`class`) VALUES ('" + dtnow + "', '" + sid + "', '" + fname + "', '" + peid + "', '" + cls + "')";
                                                                    MySqlConnection dbCon3 = new MySqlConnection(connectionString);
                                                                    MySqlCommand cmdDb3 = new MySqlCommand(aquery, dbCon3);
                                                                    cmdDb3.CommandTimeout = 60;
                                                                    try
                                                                    {
                                                                        dbCon3.Open();
                                                                        MySqlDataReader myReader3 = cmdDb3.ExecuteReader();
                                                                        dbCon3.Close();
                                                                    }

                                                                    catch (Exception exc)
                                                                    {
                                                                        MessageBox.Show("aquery Exception message" + exc.Message);//Shows Exception message
                                                                    }
                                                                    //-----
                                                                }
                                                                databaseConnection.Close();
                                                            }
                                                            catch (Exception ex)
                                                            {
                                                                MessageBox.Show("iquery" + ex.Message);
                                                            }
                                                        }
                                                        else
                                                        {
                                                            //MessageBox.Show("More than 0 values returned");
                                                            Console.WriteLine("More than 0 values returned");
                                                        }
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        MessageBox.Show("c_query" + ex.Message);
                                                    }
                                                    //----------------------------------------------------------------------
                                                    //---------------------------------------------------------|||----------------------------------------


                                                    //DataGridview2 workings
                                                    //Doesnot work for crop image------------------------------------
                                                    // Asynchornosuly working --15102018


                                                    dataGridView2.Invoke(new Action(() => dataGridView2.Rows.Clear()));
                                                    int count2 = 1;
                                                    DataGridViewImageColumn imageColumn2 = (DataGridViewImageColumn)dataGridView2.Columns[1];
                                                    imageColumn2.ImageLayout = DataGridViewImageCellLayout.Stretch;
                                                    imageColumn2.Width = 100;
                                                    dataGridView2.Invoke(new Action(() => dataGridView2.RowTemplate.Height = 100));

                                                    // for (int i = 0; i < count; i++)
                                                    // {
                                                    string dtname2 = DateTime.Now.ToString("HH:mm:ss tt") + ": " + "Aktarruzaman";
                                                    Image carimg;
                                                    carimg = Image.FromFile(@"C:\xampp\htdocs\frs2018\db\vehicle\car3.jpg");

                                                    dataGridView2.Invoke(new Action(() => dataGridView2.Rows.Add(dtname, carimg)));
                                                    dataGridView2.Invoke(new Action(() => dataGridView2.ClearSelection()));

                                                    //}
                                                    //---------------------------------------------------------|||----------------------------------------

                                                    //dataGridView1.Invoke(new Action(() => dataGridView1.Rows.Clear()));

                                                    //string[] row = new string[] { DateTime.Now.ToString("HH:mm:ss tt") + ": " + nameArray[location] };
                                                    //dataGridView1.Invoke(new Action(() => dataGridView1.Rows.Add(row)));

                                                    ////Works but last column show invalid image

                                                    //DataGridViewImageColumn imgNEW = new DataGridViewImageColumn();
                                                    //imgNEW.Width = 100;
                                                    //Image imagen = Image.FromFile(@"C:\Users\user\Desktop\Capture2.jpg");
                                                    //// Converting the master image to a bitmap
                                                    //Bitmap helloimage = (Bitmap)imagen;
                                                    //Image<Gray, Byte> normalizedMasterImage = new Image<Gray, Byte>(helloimage);
                                                    //imgNEW.Image = helloimage;
                                                    //dataGridView1.Invoke(new Action(() => dataGridView1.Rows.Add(imgNEW)));//gives just string and system image
                                                    //imgNEW.Name = "img";
                                                    //imgNEW.HeaderText = "Image";
                                                    Thread.Sleep(100);
                                                    dataGridView1.Invoke(new Action(() => dataGridView1.Rows.Clear()));

                                                }

                                                //
                                                else if (det3["result"] == "error")
                                                {
                                                    Console.WriteLine("Face Verification error");
                                                }
                                            }//using var ends

                                        } //fourth try ends
                                        catch (Exception ex)//fourth catch begins
                                        {
                                            MessageBox.Show("Facial Feature Extraction Error Message: " + ex.Message);

                                        }
                                        //-----------------------------------------------------------------
                                    }//if ends
                                    else if (det2["result"] == "error")
                                    {
                                        Console.WriteLine("error");
                                    }
                                }//thitd var ends
                            }//thitd try ends
                            catch (Exception ex)
                            {
                                MessageBox.Show("Input string Error Message" + ex.Message);//Cannot perform runtime binding
                            }
                        }
                        else if (det["result"] == "error")
                        {
                            MessageBox.Show("HttpResponse Result Error");
                        }
                    }//using third var ends
                }//second try ends
                catch (Exception ex)
                {
                    MessageBox.Show("Second Try Error Message" + ex.Message);
                }
            }//first try ends
            catch (Exception ex)
            {
                MessageBox.Show("First Try Error Message" + ex.Message);
            }
        }


        //Function to call faceAttribute

        //    private string[] faceAtt(byte[] image)
        //    {
        //        try
        //        {
        //            var httpWebRequest = (System.Net.HttpWebRequest)WebRequest.Create("http://127.0.0.1:5000/verify/attribute/gets");
        //            httpWebRequest.ContentType = "multipart/form-data";
        //            httpWebRequest.Method = "POST";

        //            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        //            {
        //                //string param = "{\"user\":\"test\" }";
        //                string imgs = "{\"imageData\":" + image + "}";
        //                streamWriter.Write(imgs);
        //                streamWriter.Flush();
        //                streamWriter.Close();
        //            }
        //            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        //            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        //            {
        //                var result = streamReader.ReadToEnd();
        //                var det = JsonConvert.DeserializeObject<dynamic>(result);
        //                if (det["result"] == "success")
        //                {
        //                    //det_agets =  {                "result":"success", 
        //                    //                                "data":{
        //                    //                                    "age":27, "gender":0,
        //                    //                                    "attractive":90, "eyeglass":0, 
        //                    //                                    "sunglass":0, "smile":0, 
        //                    //                                    "mask":0, "race":0,
        //                    //                                    "eyeOpen":1, "mouthOpen":0, "beard":0
        //                    //                                }}

        //                    string age = det["data"]["age"].ToString();
        //                    string gender = det["data"]["age"].ToString();
        //                    string attractive = det["data"]["age"].ToString();
        //                    string smile = det["data"]["age"].ToString();
        //                    string mask = det["data"]["age"].ToString();
        //                    string race = det["data"]["age"].ToString();
        //                    string eyeOpen = det["data"]["age"].ToString();
        //                    string mouthOpen = det["data"]["age"].ToString();
        //                    string beard = det["data"]["age"].ToString();

        //                    Console.WriteLine(det["data"]["age"]);//works
        //                    Console.WriteLine(det["data"]["gender"]);//works
        //                    Console.WriteLine(det["data"]["attractive"]);//works
        //                    Console.WriteLine(det["data"]["smile"]);//works
        //                    Console.WriteLine(det["data"]["mask"]);//works
        //                    Console.WriteLine(det["data"]["race"]);//works
        //                    Console.WriteLine(det["data"]["eyeOpen"]);//works
        //                    Console.WriteLine(det["data"]["mouthOpen"]);//works
        //                    Console.WriteLine(det["data"]["beard"]);//works

        //                    string[] faceAttArr = new string[] { "success", age, gender, attractive, smile, mask, race, eyeOpen, mouthOpen, beard };
        //                    return faceAttArr;
        //                }
        //                else if (det["result"] == "error")
        //                {
        //                    string[] faceAttArrayError = new string[] { "error" };
        //                    return faceAttArrayError;
        //                }
        //            }
        //            string[] faceAttArray = new string[] { "error" };
        //            return faceAttArray;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Facial Feature Extraction Error Message: " + ex.Message);//Cannot perform runtime binding
        //            string[] faceAttArray = new string[] { "errorExtraction" };
        //            return faceAttArray;
        //        }

        //}



        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
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


                    //Console.WriteLine(quality_score);
                    Console.WriteLine(rect);



                    //dbinsert(name, imageId, personId, qualityScore, feature);
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


        private void Play_Click(object sender, EventArgs e)
        {
            {
                //dataGridView1 initialization
                dataGridView1.Columns.AddRange(new DataGridViewTextBoxColumn(), new DataGridViewImageColumn());
                //dataGridView1.ColumnCount = 2;
                dataGridView1.Rows.Clear();
                dataGridView1.RowTemplate.Height = 100;
                //dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns[0].Name = "Date-Time & Person";
                //dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].Name = "Image";
                //dataGridView1.Columns[1].Width = 100;
                dataGridView1.AllowUserToAddRows = false;

                //dataGridView2 initialization
                dataGridView2.Columns.AddRange(new DataGridViewTextBoxColumn(), new DataGridViewImageColumn());
                dataGridView2.Rows.Clear();
                dataGridView2.RowTemplate.Height = 100;
                dataGridView2.Columns[0].Name = "Date-Time & Person";
                dataGridView2.Columns[1].Name = "Car Image";
                dataGridView2.AllowUserToAddRows = false;


                //if (capture == null)
                //{
                //    capture = new Emgu.CV.Capture(1);
                //}
                //capture.ImageGrabbed += Capture_ImageGrabbed1;
                //capture.Start();


                if (capture2 == null)
                {
                    capture2 = new Emgu.CV.Capture(0);
                }
                capture2.ImageGrabbed += Capture_ImageGrabbed2;
                capture2.Start();


                //if (capture3 == null)
                //{
                //    capture3 = new Emgu.CV.Capture(0);
                //}
                //capture3.ImageGrabbed += Capture_ImageGrabbed3;
                //capture3.Start();

                //if (capture4 == null)
                //{
                //    capture4 = new Emgu.CV.Capture("http://192.168.0.117:8080/video");

                //}
                //capture4.ImageGrabbed += Capture_ImageGrabbed4;
                //capture4.Start();

                //if (capture4 == null)
                //{
                //    capture4 = new Emgu.CV.Capture(0);
                //}
                //capture4.ImageGrabbed += Capture_ImageGrabbed4new;
                //capture4.Start();

            }
        }
        //---------------------------------------------------------------



   






        private void MySQL_ToDatagridview4()
        {
            Bitmap def;

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=frs_school;";
            //string query = "INSERT INTO employee_charp(`emp_id`,`firstName`, `lastName`, `age`) VALUES (NULL, '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";

            MySqlConnection mcon = new MySqlConnection(connectionString);
            //MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            //commandDatabase.CommandTimeout = 60;

            dataGridView1.Columns.Clear();
            mcon.Close();
            mcon.Open();
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT student_id,first_name, student_image from frs_student";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mcon);
            DataTable table = new DataTable();
            MyDA.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            this.dataGridView1.DataSource = bSource;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Pic";
            dataGridView1.Columns.Insert(0, imageColumn);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                try
                {
                    String pic = table.Rows[i]["student_image"].ToString();
                    pic = @"C:\\xampp\\htdocs\\frs2018\\" + pic;
                    pic = @"C:\Users\user\Desktop\Capture2.PNG";
                    //Byte[] bitmapData = Convert.FromBase64String(FixBase64ForImage(pic));
                    // System.IO.MemoryStream streamBitmap = new System.IO.MemoryStream(bitmapData);
                    //Byte[] bitmapData = Convert.FromBase64String(FixBase64ForImage(pic));
                    //System.IO.MemoryStream streamBitmap = new System.IO.MemoryStream(bitmapData);
                    //debugOutput(pic);
                    //def = new Bitmap(@+pic);
                    //pic = @"C:\xampp\htdocs\frs2018\db\students\students\AZM Ariful Haque Real.jpg";
                    def = new Bitmap(pic);
                    //def = new Bitmap((Bitmap)Image.FromStream(pic));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.StackTrace);
                }
                //string pic2 = @"C:\xampp\htdocs\frs2018\db\students\AZM Ariful Haque Real.jpg";
                //def = new Bitmap(pic2);
                //showImageGrid.Rows[i].Cells[0].Value = def;
            }
            dataGridView1.Columns.Remove("student_image");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 110;
            }
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.Width = 110;
            }

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.AutoResizeColumns();
                dataGridView1.Columns[i].DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 8F, FontStyle.Bold);
            }
            mcon.Close();
        }

        private void ToDatagridview4(string NewPath, string datetime, string person)
        {
            Image img;
            //dataGridView1.ColumnCount = 1;
            dataGridView1.Rows.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].Name = "Date-Time & Person";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Name = "Image";
            dataGridView1.Columns[1].Width = 100;

            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[1];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            imageColumn.Width = 100;

            dataGridView1.RowTemplate.Height = 100;

            for (int i = 0; i < 1; i++)
            {
                string[] dtperson = new string[] { datetime + ": " + person };
                string picture = "C:\\Users\\user\\Desktop\\cropImage.jpg";
                img = Image.FromFile(@"C:\Users\user\Desktop\cropImage.jpg");
                string[] data = new string[1];
                dataGridView1.Rows.Add(dtperson, img);
                dataGridView1.ClearSelection();
            }


            // string[] row = new string[] { datetime +": "+ person };
            // dataGridView1.Invoke(new Action(() => dataGridView1.Rows.Add(row)));
            //dataGridView1.Rows.Add(row);
            //row = new string[] { "2", "Product 2" };
            //dataGridView1.Rows.Add(row);
            //row = new string[] { "3", "Product 3" };
            //dataGridView1.Rows.Add(row);
            //row = new string[] { "4", "Product 4" };
            //dataGridView1.Rows.Add(row);


            ////Works but last column show invalid image
            // DataGridViewImageColumn imgNEW = new DataGridViewImageColumn();
            // imgNEW.Width = 100;
            //  Image imagen = Image.FromFile(@"C:\Users\user\Desktop\Capture2.PNG");

            // Converting the master image to a bitmap
            //  Bitmap helloimage = (Bitmap)imagen;

            // Normalizing it to grayscale
            // Image<Gray, Byte> normalizedMasterImage = new Image<Gray, Byte>(helloimage);



            //Image newImage = Image.FromHbitmap(imagen);
            //Image newImage = imagen;
            //----------Works this way

            // imgNEW.Image = helloimage;// 
            //imgNEW.Image = myNewMat.ToImage<Bgr, Byte>().ToBitmap();//does not work with this
            //img.ValuesAreIcons = true;
            //dataGridView1.Columns.Add(imgNEW);
            // dataGridView1.Invoke(new Action(() => dataGridView1.Rows.Add(imgNEW)));
            //imgNEW.HeaderText = "IMAGE";
            // imgNEW.Name = "img";
            //Thread.Sleep(10);





            // Image imagen = Image.FromFile(@"C:\Users\user\Desktop\Capture2.PNG");
            //byte[] img = (byte[])(imagen);
            // MemoryStream ms = new MemoryStream(imagen);
            //DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            //  imageCol.HeaderText = "test1";
            //  dataGridView1.Columns.Add(imageCol);
            // imageCol.ImageLayout = DataGridViewImageCellLayout.Stretch; // will do the trick
            // dataGridView1.Rows.Add(imagen);




            //Image<Bgr, Byte> imByte = imagen;
            // CvInvoke.Resize(imByte, imByte, new Size(pictureBox1.Width, pictureBox1.Height), 0, 0, Emgu.CV.CvEnum.Inter.Linear);


        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                returnImage = Image.FromStream(ms, true);//Exception occurs here
            }
            catch { }
            return returnImage;
        }

        private void pause_Click(object sender, EventArgs e)
        {

            if (capture != null)
            {
                capture.Pause();

            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            stopallcaptures();
        }
        private void stopallcaptures()
        {
            //if (flagCapture == true)
            //{
            //    capture.Stop();
            //}
            //if (flagCapture2 == true)
            //{
            //    capture2.Stop();
            //}
            //if (flagCapture3 == true)
            //{
            //    capture3.Stop();
            //}
            //if (flagCapture4 == true)
            //{
            //    capture4.Stop();
            //}

            if (capture != null)
            {
                capture.Stop();
            }
            if (capture2 != null)
            {
                capture2.Stop();
            }
            if (capture3 != null)
            {
                capture3.Stop();
            }
            if (capture4 != null)
            {
                capture4.Stop();
            }
        }
    }
}
