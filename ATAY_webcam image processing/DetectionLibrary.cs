﻿using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV;
using ImageProcess2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV.Util;
using Emgu.CV.Reg;

namespace ATAY_webcam_image_processing
{
    public class DetectionLibrary
    {
        public static Bitmap ProcessImage(Bitmap img)
        {
            using (UMat gray = new UMat())
            using (UMat cannyEdges = new UMat())
            using (Mat circleImage = new Mat(img.Size, DepthType.Cv8U, 3)) //image to draw circles on
            {
                Mat converted_img = img.ToMat();

                //Convert the image to grayscale and filter out the noise
                CvInvoke.CvtColor(converted_img, gray, ColorConversion.Bgr2Gray);

                //Remove noise
                CvInvoke.GaussianBlur(gray, gray, new Size(3, 3), 1);

                #region circle detection
                double cannyThreshold = 180.0;
                double circleAccumulatorThreshold = 120;
                CircleF[] circles = CvInvoke.HoughCircles(gray, HoughModes.Gradient, 1.0, 15.0, cannyThreshold, circleAccumulatorThreshold, 0, img.Height/4);
                #endregion


                #region draw circles
                circleImage.SetTo(new MCvScalar(0));
                Image<Bgr, byte> Img_Result_Bgr = new Image<Bgr, byte>(img.Width, img.Height);
                for (int y = 0; y < img.Height; y++)
                {
                    for (int x = 0; x < img.Width; x++)
                    {
                        // Get the pixel color from the bitmap (this is in ARGB format)
                        Color color = img.GetPixel(x, y);

                        // Set the pixel color in Img_Result_Bgr (Convert ARGB to BGR format)
                        Img_Result_Bgr[y, x] = new Bgr(color.B, color.G, color.R);
                    }
                }

                foreach (CircleF circle in circles)
                {
                    Console.WriteLine($"Circle center: ({circle.Center.X}, {circle.Center.Y}), Radius: {circle.Radius}");
                    Img_Result_Bgr.Draw(circle, new Bgr(Color.Red), 2);
                }
                    

                #endregion
                return Img_Result_Bgr.ToBitmap();
            }
        }
    }
}