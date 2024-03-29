﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using static System.Math;
namespace Computer_Grathic_1
{
    internal class TurnFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            int  x = (int)((i - 150) * Math.Cos(0.2) - (j - 255) * Math.Sin(0.2) + 150);
            int y = (int)((i - 150) * Math.Sin(0.2) + (j - 255) * Math.Cos(0.2) + 150);
            if ((x<0)||(y<0)||(x>=sourceImage.Width))
            {
              
                Color resultColor = Color.FromArgb(255, 255, 255);
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
