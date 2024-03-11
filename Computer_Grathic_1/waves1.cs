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
            int x = Clamp((int)(i + 20 * Math.Sin(2 * Math.PI * j / 60)), 0, sourceImage.Width - 1);
            int y = j;
            Color sourseColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(sourseColor.R, sourseColor.G, sourseColor.B);
            return resultColor;
        }
    }
}
