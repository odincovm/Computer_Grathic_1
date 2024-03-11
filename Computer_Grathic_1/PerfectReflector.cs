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
    internal class PerfectReflector : Filters
    {
        protected double Rmax = 0, Gmax = 0, Bmax = 0;
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            Color sourseColor = sourceImage.GetPixel(i, j);
            Color resultColor = Color.FromArgb(Clamp((int)(sourseColor.R * 255 / Rmax), 0, 255), Clamp((int)(sourseColor.G * 255 / Gmax), 0, 255), Clamp((int)(sourseColor.B * 255 / Bmax), 0, 255));
            return resultColor;
        }

        public  Bitmap processimage(Bitmap sourceImage)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);           
            for (int i = 0; i < sourceImage.Width; i++){            
                for (int j = 0; j < sourceImage.Height; j++){
                    if (sourceImage.GetPixel(i, j).R > Rmax) Rmax = sourceImage.GetPixel(i, j).R;
                    if (sourceImage.GetPixel(i, j).G > Gmax) Gmax = sourceImage.GetPixel(i, j).G;
                    if (sourceImage.GetPixel(i, j).B > Bmax) Bmax = sourceImage.GetPixel(i, j).B;
                }
            }
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
            }
            return resultImage;
        }
    }

}

