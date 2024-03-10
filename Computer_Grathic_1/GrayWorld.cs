using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace Computer_Grathic_1
{
    internal class GrayWorld : Filters
    {
        protected int Avg;
        protected int R, G, B;
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourseColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(Clamp(sourseColor.R * Avg / R, 0, 255), Clamp(sourseColor.G * Avg / G, 0, 255), Clamp(sourseColor.B * Avg / B, 0, 255));
            return resultColor;
        }

        public  Bitmap processimage(Bitmap sourceImage)
        {
            {
                Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
                R = 0; 
                G = 0; 
                B = 0; 
                Avg = 0;
                for (int i = 0; i < sourceImage.Width; i++)
                {
                    for (int j = 0; j < sourceImage.Height; j++)
                    {
                        Color sourceColor = sourceImage.GetPixel(i, j);
                        R += sourceColor.R;
                        G += sourceColor.G;
                        B += sourceColor.B;
                    }
                }
                R = R / (sourceImage.Width * sourceImage.Height);
                G = G / (sourceImage.Width * sourceImage.Height);
                B = B / (sourceImage.Width * sourceImage.Height);
                Avg = (R + G + B) / 3;
                for (int i = 0; i < sourceImage.Width; i++)
                {
                    for (int j = 0; j < sourceImage.Height; j++)
                        resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
                }
                return resultImage;
            }
        }
    }
}

    


  

