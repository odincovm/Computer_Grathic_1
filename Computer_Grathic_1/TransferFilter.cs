using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace Computer_Grathic_1
{
    class TransferFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            if (i - 50 < 0) {
                Color sourseColor = sourceImage.GetPixel(0, j);
                Color resultColor = Color.FromArgb(sourseColor.R, sourseColor.G, sourseColor.B);
                return resultColor;
            }
            else
            {
                Color sourseColor = sourceImage.GetPixel(i-50, j);
                Color resultColor = Color.FromArgb(sourseColor.R, sourseColor.G, sourseColor.B);
                return resultColor;
            }
            
            
        }
    }
}
