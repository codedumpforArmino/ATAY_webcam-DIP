using System.Drawing;
using WebCamLib;

namespace ATAY_webcam_image_processing
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed;
        Device[] currDevices;
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
            Color pixel;
            int grey_value;

            for (int row = 0; row < loaded.Width; row++)
            {
                for (int col = 0; col < loaded.Height; col++)
                {
                    pixel = loaded.GetPixel(row, col);
                    grey_value = (int)(pixel.R + pixel.G + pixel.B) / 3;
                    pixel = Color.FromArgb(grey_value, grey_value, grey_value);
                    processed.SetPixel(row, col, pixel);
                }
            }

            PicBox_Output.Image = processed;
        }

        //Color Inversion
        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pixel;
            int R_value, G_value, B_value;

            for (int row = 0; row < loaded.Width; row++)
            {
                for (int col = 0; col < loaded.Height; col++)
                {
                    pixel = loaded.GetPixel(row, col);
                    R_value = 255 - pixel.R;
                    G_value = 255 - pixel.G;
                    B_value = 255 - pixel.B;

                    pixel = Color.FromArgb(R_value, G_value, B_value);
                    processed.SetPixel(row, col, pixel);
                }
            }

            PicBox_Output.Image = processed;
        }

        //Sepia
        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pixel;
            int R_value, G_value, B_value;

            for (int row = 0; row < loaded.Width; row++)
            {
                for (int col = 0; col < loaded.Height; col++)
                {
                    pixel = loaded.GetPixel(row, col);

                    R_value = (int)((pixel.R * .393) + (pixel.G * .769) + (pixel.B * .189));
                    G_value = (int)((pixel.R * .349) + (pixel.G * .686) + (pixel.B * .168));
                    B_value = (int)((pixel.R * .272) + (pixel.G * .534) + (pixel.B * .131));

                    if (R_value > 255)
                        R_value = 255;
                    if (G_value > 255)
                        G_value = 255;
                    if (B_value > 255)
                        B_value = 255;

                    pixel = Color.FromArgb(R_value, G_value, B_value);
                    processed.SetPixel(row, col, pixel);
                }
            }

            PicBox_Output.Image = processed;
        }

        //histogram

        private void histogramToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int[] histData = new int[256];
            Color pixel;
            int grey_value;

            for (int row = 0; row < loaded.Width; row++)
            {
                for (int col = 0; col < loaded.Height; col++)
                {
                    pixel = loaded.GetPixel(row, col);
                    grey_value = (int)(pixel.R + pixel.G + pixel.B) / 3;
                    histData[grey_value]++;
                }
            }


            processed = new Bitmap(256, 800);
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < 800; y++)
                {
                    processed.SetPixel(x, y, Color.White);
                }
            }

            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histData[x] / 5, processed.Height - 1); y++)
                    processed.SetPixel(x, (processed.Height - 1) - y, Color.Black);
            }

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
            currDevices = DeviceManager.GetAllDevices();
        }

        private void activateCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currDevices[0].ShowWindow(PicBox_Input);
        }

        private void deactivateCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currDevices[0].Stop();
            PicBox_Output.Image = null;
        }
    }
}
