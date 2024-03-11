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
    internal class CorrectionWithReferenceColor : Filters
    {
        Color reference;
        protected double Rsrc = 0, Gsrc = 0, Bsrc = 0;
        public CorrectionWithReferenceColor(Color r)
        {
            reference = r;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            Color sourseColor = sourceImage.GetPixel(i, j);
            Color resultColor = Color.FromArgb(Clamp((int)(sourseColor.R * Rsrc / reference.R), 0, 255), Clamp((int)(sourseColor.G * Gsrc / reference.G), 0, 255), Clamp((int)(sourseColor.B * Bsrc / reference.B), 0, 255));
            return resultColor;
        }
        public  Bitmap processImage(Bitmap sourceImage)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    if (sourceImage.GetPixel(i, j).R > Rsrc) Rsrc = sourceImage.GetPixel(i, j).R;
                    if (sourceImage.GetPixel(i, j).G > Gsrc) Gsrc = sourceImage.GetPixel(i, j).G;
                    if (sourceImage.GetPixel(i, j).B > Bsrc) Bsrc = sourceImage.GetPixel(i, j).B;
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

