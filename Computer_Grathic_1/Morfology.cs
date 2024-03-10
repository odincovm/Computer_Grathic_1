using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace Computer_Grathic_1
{
    internal class Morfology : Filters
    {
        protected bool isDilation;
        protected int[,] mask = null;
        protected Morfology()
        {
            mask = new int[,] { { 0, 1, 0 }, { 1, 1, 1 }, { 0, 1, 0 } };
        }
        public Morfology(int[,] mask)
        {
            this.mask = mask;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = mask.GetLength(0) / 2;
            int radiusY = mask.GetLength(1) / 2;
            int minR = 255; int minG = 255; int minB = 255;
            int maxR = 0; int maxG = 0; int maxB = 0;
            for (int i = -radiusX; i <= radiusX; i++)
                for (int j = -radiusY; j <= radiusY; j++)
                {
                    if (isDilation)
                    {
                        if ((mask[i + radiusX, j + radiusY] != 0) && (x + i > 0) && (y + j > 0)&&(x+i<sourceImage.Width)&&(y+j<sourceImage.Height)&& (sourceImage.GetPixel(x + i, y + j).R > maxR))
                            maxR = sourceImage.GetPixel(x + i, y + j).R;
                        if ((mask[i + radiusX, j + radiusY] != 0) && (x + i > 0) && (y + j > 0)  && (x + i < sourceImage.Width) && (y + j < sourceImage.Height) && (sourceImage.GetPixel(x + i, y + j).G > maxG))
                            maxG = sourceImage.GetPixel(x + i, y + j).G;
                        if ((mask[i + radiusX, j + radiusY] != 0) && (x + i > 0) && (y + j > 0) && (x + i < sourceImage.Width) && (y + j < sourceImage.Height) && (sourceImage.GetPixel(x + i, y + j).B > maxB))
                            maxB = sourceImage.GetPixel(x + i, y + j).B;
                    }
                    else
                    {
                        if ((mask[i + radiusX, j + radiusY] != 0) && (x + i > 0) && (y + j > 0) && (x + i < sourceImage.Width) && (y + j < sourceImage.Height) && (sourceImage.GetPixel(x + i, y + j).R < minR))
                            minR = sourceImage.GetPixel(x + i, y + j).R;
                        if ((mask[i + radiusX, j + radiusY] != 0) && (x + i > 0) && (y + j > 0) && (x + i < sourceImage.Width) && (y + j < sourceImage.Height) && (sourceImage.GetPixel(x + i, y + j).G < minG))
                            minG = sourceImage.GetPixel(x + i, y + j).G;
                        if ((mask[i + radiusX, j + radiusY] != 0) && (x + i > 0) && (y + j > 0) && (x + i < sourceImage.Width) && (y + j < sourceImage.Height) && (sourceImage.GetPixel(x + i, y + j).B < minB))
                            minB = sourceImage.GetPixel(x + i, y + j).B;
                    }
                }
            if (isDilation)
                return Color.FromArgb(maxR, maxG, maxB);
            else
                return Color.FromArgb(minR, minG, minB);
        }
        
    }
}
