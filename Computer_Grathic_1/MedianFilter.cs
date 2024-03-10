using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using System.Linq;
namespace Computer_Grathic_1
{
    internal class MedianFilter : Filters
    {
        protected float[,] Array1 = null;

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            
                int[] Arrr = new int[3];
                float[] median = new float[3];
                Array1 = new float[3, 3];
                for (int x = -1; x <= 1; x++)
                {
                    for (int y = -1; y <= 1; y++)
                    {
                        Color currColor = sourceImage.GetPixel(Clamp(x + i, 0, sourceImage.Width - 1), Clamp(y + j, 0, sourceImage.Height - 1));
                        Array1[x + 1, y + 1] = (currColor.R + currColor.G + currColor.B) / 3;
                       
                    }

                }
                for (int z = 0; z < 1; z++)
                {
                    int[] tmp = new int[3];
                    tmp[0] = (int)Array1[z, 0];
                    tmp[1] = (int)Array1[z, 1];
                    tmp[2] = (int)Array1[z, 2];
                    int Arr = qsort(tmp, 0, 2);
                    Arrr[z] = Arr;
                }
                int result = qsort(Arrr, 0, 2);
                return Color.FromArgb(Clamp(result, 0, 255), Clamp(result, 0, 255), Clamp(result, 0, 255));
           
        }

        private static int qsort(int[] a, int l, int r)
        {
            int x = a[l + (r - l) / 2], i = l, j = r, temp;
            while (i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    temp = a[i]; a[i] = a[j]; a[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < r) qsort(a, i, r);
            if (l < j) qsort(a, l, j);
            return a[l + (r - l) / 2];
        }
    }
}
