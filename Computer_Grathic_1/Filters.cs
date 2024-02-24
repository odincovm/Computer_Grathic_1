﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Filters
    {
        protected abstract Color calculateNewPixelColor(Bitmap sourceImage, int i, int j);
        public Bitmap processImage(Bitmap sourceImage)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    resultImage.SetPixel(i,j,calculateNewPixelColor(sourceImage, i ,j));
                }
            
            }

            return resultImage;
        }
        public int Clamp(int value, int min, int max)
        {
            if(value < min)
                return min;
            if(value > max)
                return max;
            return value;
        }
        
    }
    
}
