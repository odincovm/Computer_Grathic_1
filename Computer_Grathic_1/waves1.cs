using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace Computer_Grathic_1
{
    internal class waves1 : Filters
    {
        
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            int x = (int)((i + 20 * Math.Sin(2 * Math.PI * j / 60)));
            int y = j;

            if ((x < 0) || (x > sourceImage.Width-1))
            {
                x = sourceImage.Width - 1;
                Color sourseColor = sourceImage.GetPixel(x, y);
                Color resultColor = Color.FromArgb(sourseColor.R, sourseColor.G, sourseColor.B);
                return resultColor;
            }
            else
            {
                Color sourseColor = sourceImage.GetPixel(x, y);
                Color resultColor = Color.FromArgb(sourseColor.R, sourseColor.G, sourseColor.B);
                return resultColor;
            }

        }
    }
}
