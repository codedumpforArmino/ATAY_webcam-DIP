using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;

namespace ATAY_webcam_image_processing
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed;
        VideoCapture webcam;
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
            loaded = new Bitmap(openFileDialog1.FileName);
            PicBox_Input.Image = loaded;
            processed = new Bitmap(loaded.Width, loaded.Height);
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
            ImageProcessingLib.GreyScale(ref loaded,ref processed);
            PicBox_Output.Image = processed;
        }

        //Color Inversion
        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageProcessingLib.InvertColor(ref loaded,ref processed);
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
            PicBox_Input.Image = null;
        }

        //Camera Greyscale
        private void greyscaleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var img = webcam.QueryFrame().ToImage<Bgr, byte>();
            Bitmap bmp = img.ToBitmap();
            processed = new Bitmap(bmp.Width, bmp.Height);

            ImageProcessingLib.GreyScale(ref bmp, ref processed);
            PicBox_Output.Image = processed;
        }
        //Camera Pixel Copy
        private void greyscaleToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            PicBox_Output.Image = PicBox_Input.Image;
        }

        //Camera Invert
        private void inversionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var img = webcam.QueryFrame().ToImage<Bgr, byte>();
            Bitmap bmp = img.ToBitmap();
            processed = new Bitmap(bmp.Width, bmp.Height);
            ImageProcessingLib.InvertColor(ref bmp, ref processed);
            PicBox_Output.Image = processed;
        }

        //Camera Sepia
        private void sepiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var img = webcam.QueryFrame().ToImage<Bgr, byte>();
            Bitmap bmp = img.ToBitmap();
            processed = new Bitmap(bmp.Width, bmp.Height);
            ImageProcessingLib.Sepia(ref bmp, ref processed);
            PicBox_Output.Image = processed;
        }

        //Camera Histogram
        private void histogramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var img = webcam.QueryFrame().ToImage<Bgr, byte>();
            Bitmap bmp = img.ToBitmap();
            processed = new Bitmap(bmp.Width, bmp.Height);
            ImageProcessingLib.Histogram(ref bmp, ref processed);
            PicBox_Output.Image = processed;
        }
    }
}
