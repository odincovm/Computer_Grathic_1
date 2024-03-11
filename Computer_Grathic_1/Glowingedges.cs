using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace Computer_Grathic_1
{
    internal class Glowingedges : Filters
    {
        
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int maxR =0,maxG=0,maxB = 0;
            for (int i = -1; i <= 1; i++)
            {
                int max = -1;
                for (int j = -1; j <= 1; j++)
                {
                    Color currColor = sourceImage.GetPixel(Clamp(x + i, 0, sourceImage.Width - 1), Clamp(y + j, 0, sourceImage.Height - 1));
                    if (currColor.R > maxR)
                    {
                        maxR = currColor.R;
                    }
                    if (currColor.G > maxG)
                    {
                        maxG = currColor.G;
                    }
                    if (currColor.B > maxB)
                    {
                        maxB = currColor.B;
                    }
                }
            }
            return Color.FromArgb(maxR, maxG, maxB);
        }
    }
}
