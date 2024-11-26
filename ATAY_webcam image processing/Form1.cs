using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using ImageProcess2;

namespace ATAY_webcam_image_processing
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed;
        VideoCapture webcam;
        Boolean _isDoubleImage = false;
        int CameraOperation;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!_isDoubleImage)
            {
                loaded = new Bitmap(openFileDialog1.FileName);
                PicBox_Input.Image = loaded;
                processed = new Bitmap(loaded.Width, loaded.Height);
            }
            else
            {
                processed = new Bitmap(openFileDialog1.FileName);
                PicBox_Output.Image = processed;
                _isDoubleImage = false;
            }
        }

        //Pixel Copy
        private void pixelCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pixel;

            for (int row = 0; row < loaded.Width; row++)
            {
                for (int col = 0; col < loaded.Height; col++)
                {
                    pixel = loaded.GetPixel(row, col);
                    processed.SetPixel(row, col, pixel);
                }
            }

            PicBox_Output.Image = processed;
        }

        //Greyscale
        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageProcessingLib.GreyScale(ref loaded, ref processed);
            PicBox_Output.Image = processed;
        }

        //Color Inversion
        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageProcessingLib.InvertColor(ref loaded, ref processed);
            PicBox_Output.Image = processed;
        }

        //Sepia
        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageProcessingLib.Sepia(ref loaded, ref processed);
            PicBox_Output.Image = processed;
        }

        //histogram
        private void histogramToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ImageProcessingLib.Histogram(ref loaded, ref processed);
            PicBox_Output.Image = processed;
            processed = new Bitmap(loaded.Width, loaded.Height);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            processed.Save(saveFileDialog1.FileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webcam = new VideoCapture();
        }

        private void stream(object sender, EventArgs e)
        {
            var img = webcam.QueryFrame().ToImage<Bgr, byte>();
            Bitmap bmp = img.ToBitmap();
            PicBox_Input.Image = bmp;
        }

        private void activateCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Idle += stream;
        }

        private void deactivateCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Idle -= stream;
            timer1.Enabled = false;
            PicBox_Input.Image = null;
        }

        //Camera Greyscale
        private void greyscaleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            CameraOperation = 0;
        }
        //Camera Pixel Copy
        private void greyscaleToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            PicBox_Output.Image = PicBox_Input.Image;
        }

        //Camera Invert
        private void inversionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            CameraOperation = 1;
        }

        //Camera Sepia
        private void sepiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            CameraOperation = 2;
        }

        //Camera Histogram
        private void histogramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            CameraOperation = 3;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var img = webcam.QueryFrame().ToImage<Bgr, byte>();
            Bitmap bmp = img.ToBitmap();
            processed = new Bitmap(bmp.Width, bmp.Height);

            switch (CameraOperation)
            {
                case 0:
                    ImageProcessingLib.GreyScale(ref bmp, ref processed);
                    break;
                case 1:
                    ImageProcessingLib.InvertColor(ref bmp, ref processed);
                    break;
                case 2:
                    ImageProcessingLib.Sepia(ref bmp, ref processed);
                    break;
                case 3:
                    ImageProcessingLib.Histogram(ref bmp, ref processed);
                    break;
            }

            PicBox_Output.Image = processed;
        }

        private void Btn_LoadImage_Click(object sender, EventArgs e)
        {
            _isDoubleImage = true;
            openFileDialog1.ShowDialog();
        }

        private void btn_Subtract_Click(object sender, EventArgs e)
        {
            ImageProcessingLib.Subtraction(ref loaded, ref processed);
            PicBox_Output.Image = processed;
        }

        private void gaucianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicBox_Output.Image = ImageProcessingLib.GaussianBlur(loaded, 4);
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicBox_Output.Image = ImageProcessingLib.Sharpen(loaded, 11);
        }

        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicBox_Output.Image = ImageProcessingLib.MeanRemoval(loaded, 9);
        }

        private void LaplascianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = ImageProcessingLib.Emboss(loaded, 1);
        }

        private void horzVertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicBox_Output.Image = ImageProcessingLib.Emboss(loaded, 2);
        }

        private void allDirectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicBox_Output.Image = ImageProcessingLib.Emboss(loaded, 3);
        }

        private void lossyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicBox_Output.Image = ImageProcessingLib.Emboss(loaded, 4);
        }

        private void horizontalOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicBox_Output.Image = ImageProcessingLib.Emboss(loaded, 5);
        }

        private void verticalOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicBox_Output.Image = ImageProcessingLib.Emboss(loaded, 6);
        }

        private void countCoinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float[] Circle_r = new float[100];
            int[] CoinCount = new int[5];
            MessageBox.Show("Drawing Circle");
            Bitmap detectedCircle = DetectionLibrary.ProcessImage(loaded, ref Circle_r);
            PicBox_Output.Image = detectedCircle;

            int x = 0;
            while (Circle_r[x] != 0)
            {
                CoinCount[DetectionLibrary.CoinChecker(Circle_r[x])]++; 
                txtBox_Report.AppendText(Circle_r[x].ToString());
                txtBox_Report.AppendText("\n");
                x++;
            }

            CoinCount[DetectionLibrary.CoinChecker(Circle_r[x])]++;
            x++;

            double TotalValue = (CoinCount[0] * 5) + (CoinCount[1] * 1) + (CoinCount[2] * .25) + (CoinCount[3] * .1) + (CoinCount[4] * .05);
            MessageBox.Show("Total Coins Detected: " + x + "\n5 Peso Coins: " + CoinCount[0]
                    + "\n1 Peso Coins: " + CoinCount[1]
                    + "\n25 centavo Coins: " + CoinCount[2]
                    + "\n10 centavo Coins: " + CoinCount[3]
                    + "\n5 centavo Coins: " + CoinCount[4]
                    + "\nTotal Value: " + TotalValue);
        }
    }
}
