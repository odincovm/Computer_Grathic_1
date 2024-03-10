using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace Computer_Grathic_1
{
    internal class Glass : Filters
    {
        Random rnd = new Random();
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            
            double rand = rnd.NextDouble();
            int x = (int) (i + (rand - 0.5) * 10);
            int y = (int) (j + (rand - 0.5) * 10);

            if ((x < 0) || (x > sourceImage.Width - 1) && (y < 0) || (y > sourceImage.Height - 1))
            {
                Color sourseColor = sourceImage.GetPixel(i, j);
                Color resultColor = Color.FromArgb(sourseColor.R, sourseColor.G, sourseColor.B);
                return resultColor;
            }

            if ((x < 0) || (x > sourceImage.Width - 1))
            {
                Color sourseColor = sourceImage.GetPixel(i, y);
                Color resultColor = Color.FromArgb(sourseColor.R, sourseColor.G, sourseColor.B);
                return resultColor;
            }

            if ((y < 0) || (y > sourceImage.Height - 1))
            {
                Color sourseColor = sourceImage.GetPixel(x, j);
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
