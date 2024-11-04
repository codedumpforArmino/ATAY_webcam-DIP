using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATAY_webcam_image_processing
{
    static class ImageProcessingLib
    {
        public static void InvertColor(ref Bitmap input, ref Bitmap output)
        {
            Color pixel;
            int R_value, G_value, B_value;

            for (int row = 0; row < input.Width; row++)
            {
                for (int col = 0; col < input.Height; col++)
                {
                    pixel = input.GetPixel(row, col);
                    R_value = 255 - pixel.R;
                    G_value = 255 - pixel.G;
                    B_value = 255 - pixel.B;

                    pixel = Color.FromArgb(R_value, G_value, B_value);
                    output.SetPixel(row, col, pixel);
                }
            }
        }

        public static void Sepia(ref Bitmap input, ref Bitmap output)
        {
            Color pixel;
            int R_value, G_value, B_value;

            for (int row = 0; row < input.Width; row++)
            {
                for (int col = 0; col < input.Height; col++)
                {
                    pixel = input.GetPixel(row, col);

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
                    output.SetPixel(row, col, pixel);
                }
            }
        }

        public static void Histogram(ref Bitmap input, ref Bitmap output)
        {
            int[] histData = new int[256];
            Color pixel;
            int grey_value;

            for (int row = 0; row < input.Width; row++)
            {
                for (int col = 0; col < input.Height; col++)
                {
                    pixel = input.GetPixel(row, col);
                    grey_value = (int)(pixel.R + pixel.G + pixel.B) / 3;
                    histData[grey_value]++;
                }
            }


            output = new Bitmap(256, 800);
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < 800; y++)
                {
                    output.SetPixel(x, y, Color.White);
                }
            }

            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histData[x] / 5, output.Height - 1); y++)
                    output.SetPixel(x, (output.Height - 1) - y, Color.Black);
            }
        }

    }
}
