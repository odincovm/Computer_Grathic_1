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
    internal class Grad:Morfology
    {
        public Grad(int[,] mask)
        {
            this.mask = mask;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            return sourceImage.GetPixel(x, y);
        }
        public Bitmap ProcessImage(Bitmap sourceImage)
        {
            Bitmap result = new Bitmap(sourceImage.Width, sourceImage.Height);
            Filters filter1 = new Dilation(mask);
            Bitmap result1 = filter1.processImage(sourceImage);
            Filters filter2 = new Errosion(mask);
            Bitmap result2 = filter2.processImage(sourceImage);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    int newR = Clamp(result1.GetPixel(i, j).R - result2.GetPixel(i, j).R, 0, 255);
                    int newG = Clamp(result1.GetPixel(i, j).G - result2.GetPixel(i, j).G, 0, 255);
                    int newB = Clamp(result1.GetPixel(i, j).B - result2.GetPixel(i, j).B, 0, 255);
                    result.SetPixel(i, j, Color.FromArgb(newR, newG, newB));
                }
            }
            return result;
        }

    }
}

