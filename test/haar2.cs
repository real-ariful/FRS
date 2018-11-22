using Emgu.CV;
using Emgu.CV.Structure;
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

using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

using Emgu.CV.Face;

namespace WindowsFormsApplication3.test
{
    public partial class haar2 : Form
    {
        //Declare Variables
        CascadeClassifier faceDetected;
        Image<Bgr, Byte> Frame;
        Capture camera;
        Image<Gray, byte> result;
        Image<Gray, byte> TrainedFace = null;
        Image<Gray, byte> grayface = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> Users = new List<string>();
        int Count, NumLabels, t;
        string name, names = null;
        private EigenFaceRecognizer recognizer;

        public haar2()
        {
            InitializeComponent();
            string facePath = Path.GetFullPath(@"../../data/lbpcascade_frontalface.xml");
            faceDetected = new CascadeClassifier(facePath);
            try
            {
                string Labelsinf = File.ReadAllText(Application.StartupPath + "/Faces/Faces.txt");
                string[] Labels = Labelsinf.Split(',');
                //tHE FIRST LABEL before, will be the number of faces saved.

                NumLabels = Convert.ToInt16(Labels);
                Count = NumLabels;
                string FacesLoad;

                for (int i = 1; i < NumLabels + 1; i++)
                {
                    FacesLoad = "face" + i + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/Faces/Faces.txt"));
                    labels.Add(Labels[i]);

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Nothing is in the Database");

            }
        }

        private void multipart_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            camera = new Capture();
            camera.QueryFrame();
            Application.Idle += new EventHandler(FrameProcedure);

        }

        private void FrameProcedure(object sender, EventArgs e)
        {
            Users.Add("");
            //Frame = camera.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.Inter.Cubic);
            CvInvoke.Resize(camera.QueryFrame(), Frame, new Size(320, 240), 0, 0, Emgu.CV.CvEnum.Inter.Cubic);
            //Frame.Draw(f.rect, new Bgr(Color.Green),3);

            grayface = Frame.Convert<Gray, Byte>();
            //new lines added
            var imgGray = Frame.Convert<Gray, byte>().Clone();
            //MCvAvgComp[][] facesDetectedNow = grayface.DetectMultiScale(faceDetected, 1.1, 4);
            Rectangle[] faces = faceDetected.DetectMultiScale(imgGray, 1.1, 4);
            foreach (var face in faces)
            {
                result = Frame.Copy(face).Convert<Gray, Byte>().Resize(100, 100, Emgu.CV.CvEnum.Inter.Cubic);
                Frame.Draw(face, new Bgr(255, 0, 0), 2);
                if (trainingImages.ToArray().Length != 0)
                {
                    //MCvTermCriteria termCriterias = new MCvTermCriteria(Count, 0.001);
                    //EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 1500, ref termCriterias);

                    //name = recognizer.Recognize(result).ToString();
                    //Frame.Draw(name, ref Font, new Point(face.X - 2, face.Y - 2), new Bgr(Color.Red));
                }
                Users[t - 1] = name;
                Users.Add("");
            }
            pictureBox1.Image = Frame.Bitmap;
            name = "";
            Users.Clear();

        }

        internal class MCvFont
        {
            private object cV_FONT_HERSHEY_TRIPLEX;
            private double v1;
            private double v2;

            public MCvFont(object cV_FONT_HERSHEY_TRIPLEX, double v1, double v2)
            {
                this.cV_FONT_HERSHEY_TRIPLEX = cV_FONT_HERSHEY_TRIPLEX;
                this.v1 = v1;
                this.v2 = v2;
            }
        }
    }
}