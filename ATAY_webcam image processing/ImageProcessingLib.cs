using ImageProcess2;
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
        public class ConvMatrix
        {
            public int TopLeft = 0, TopMid = 0, TopRight = 0;
            public int MidLeft = 0, Pixel = 1, MidRight = 0;
            public int BottomLeft = 0, BottomMid = 0, BottomRight = 0;
            public int Factor = 1;
            public int Offset = 0;
            public void SetAll(int nVal)
            {
                TopLeft = TopMid = TopRight = MidLeft = Pixel = MidRight = BottomLeft = BottomMid = BottomRight = nVal;
            }

            public Bitmap Conv3x3(Bitmap input)
            {
                Bitmap output = new Bitmap(input.Width, input.Height);

                // Loop through each pixel in the input image (excluding the border)
                for (int y = 1; y < input.Height - 1; y++)  // Start from 1 and end at Height - 1 to avoid border issues
                {
                    for (int x = 1; x < input.Width - 1; x++)  // Same for Width
                    {
                        // Extract the 3x3 region around the pixel (x, y)
                        Color topLeft = input.GetPixel(x - 1, y - 1);
                        Color topMid = input.GetPixel(x, y - 1);
                        Color topRight = input.GetPixel(x + 1, y - 1);

                        Color midLeft = input.GetPixel(x - 1, y);
                        Color pixel = input.GetPixel(x, y);  // The current pixel we are processing
                        Color midRight = input.GetPixel(x + 1, y);

                        Color bottomLeft = input.GetPixel(x - 1, y + 1);
                        Color bottomMid = input.GetPixel(x, y + 1);
                        Color bottomRight = input.GetPixel(x + 1, y + 1);

                        // Apply the convolution filter on the current pixel (using the 3x3 matrix)
                        int red = (
                            topLeft.R * TopLeft + topMid.R * TopMid + topRight.R * TopRight +
                            midLeft.R * MidLeft + pixel.R * Pixel + midRight.R * MidRight +
                            bottomLeft.R * BottomLeft + bottomMid.R * BottomMid + bottomRight.R * BottomRight
                            ) / Factor + Offset;
                        red = Math.Min(255, Math.Max(0, red));  // Clamp the value to valid RGB range

                        // Repeat for green and blue channels
                        int green = (
                            topLeft.G * TopLeft + topMid.G * TopMid + topRight.G * TopRight +
                            midLeft.G * MidLeft + pixel.G * Pixel + midRight.G * MidRight +
                            bottomLeft.G * BottomLeft + bottomMid.G * BottomMid + bottomRight.G * BottomRight
                            ) / Factor + Offset;
                        green = Math.Min(255, Math.Max(0, green));

                        int blue = (
                            topLeft.B * TopLeft + topMid.B * TopMid + topRight.B * TopRight +
                            midLeft.B * MidLeft + pixel.B * Pixel + midRight.B * MidRight +
                            bottomLeft.B * BottomLeft + bottomMid.B * BottomMid + bottomRight.B * BottomRight
                            ) / Factor + Offset;
                        blue = Math.Min(255, Math.Max(0, blue));

                        // Set the new pixel color in the output image
                        output.SetPixel(x, y, Color.FromArgb(red, green, blue));
                    }
                }

                return output;
            }

        }
        public static void GreyScale(ref Bitmap input, ref Bitmap output)
        {
            Color pixel;
            int grey_value;

            for (int row = 0; row < input.Width; row++)
            {
                for (int col = 0; col < input.Height; col++)
                {
                    pixel = input.GetPixel(row, col);
                    grey_value = (int)(pixel.R + pixel.G + pixel.B) / 3;
                    pixel = Color.FromArgb(grey_value, grey_value, grey_value);
                    output.SetPixel(row, col, pixel);
                }
            }
        }

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

        public static void Subtraction(ref Bitmap background, ref Bitmap image)
        {
            //maybe ako iimplement....maybe dli sad...basin makaya
            int greyGreen = 255 / 3;
            int threshold = 5;

            Color pixel, backpixel;
            Bitmap subtracted = new Bitmap(background.Width, background.Height);

            for (int row = 0; row < image.Width; row++)
            {
                for (int col = 0; col < image.Height; col++)
                {

                    pixel = image.GetPixel(row, col);
                    backpixel = background.GetPixel(row, col);

                    subtracted.SetPixel(row, col, Math.Abs((pixel.R + pixel.G + pixel.B) / 3 - greyGreen) < threshold 
                        ? background.GetPixel(row, col) 
                        : image.GetPixel(row, col));
                }
            }
            image = subtracted;
            return;
        }

        public static Bitmap GaussianBlur(Bitmap input, int nWeight /* default to 4*/)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(1);
            m.Pixel = nWeight;
            m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = 2;
            m.Factor = nWeight + 12;

            return m.Conv3x3(input);
        }

        public static Bitmap Sharpen(Bitmap input, int nWeight /* default to 11*/)
        {
            ConvMatrix m = new ConvMatrix();
            m.Pixel = nWeight;
            m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = -2;
            m.Factor = nWeight - 8;

            return m.Conv3x3(input);
        }

        public static Bitmap MeanRemoval(Bitmap input, int nWeight /* default to 9*/)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(-1);
            m.Pixel = nWeight;
            m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = -2;
            m.Factor = nWeight - 8;

            return m.Conv3x3(input);
        }

        public static Bitmap Emboss(Bitmap input, int type)
        {
            ConvMatrix m = new ConvMatrix();

            switch (type)
            {
                case 1: //laplascian
                    m.SetAll(-1);
                    m.Pixel = 4;
                    m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = 0;
                    break;
                case 2: //Horz / Vertical
                    m.SetAll(-1);
                    m.Pixel = 4;
                    m.TopLeft = m.TopRight = m.BottomRight = m.BottomLeft = 0;
                    break;
                case 3: //All Directions
                    m.SetAll(-1);
                    m.Pixel = 8;
                    break;
                case 4: //Lossy
                    m.SetAll(-1);
                    m.Pixel = 8;
                    m.TopLeft = m.TopRight = m.BottomMid = 1;
                    break;
                case 5: //Horizontal Only
                    m.Pixel = 2;
                    m.MidLeft = m.MidRight = -1;
                    break;
                case 6: //Vertical Only
                    m.SetAll(0);
                    m.TopMid = -1;
                    m.BottomMid = 1;
                    break;
                default:
                    m.SetAll(1);
                    break;
            }

            return m.Conv3x3(input);
        }

    }
}
