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
    
            protected int Arr;
            protected int[] newArr;
            protected const int size = 9;
            protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
            {
                newArr = new int[size];
                int k = 0;
                for (int i = -1; i <= 1; i++)
                    for (int j = -1; j <= 1; j++)
                    {
                        Color currColor = sourceImage.GetPixel(Clamp(x + i, 0, sourceImage.Width - 1), Clamp(y + j, 0, sourceImage.Height - 1));
                        newArr[k++] = (currColor.R + currColor.G + currColor.B) / 3;
                    }
                Color sourceColor = sourceImage.GetPixel(x, y);
                Arr = qsort(newArr, 0, size - 1);
                Color resultColor = Color.FromArgb(Clamp(Arr, 0, 255), Clamp(Arr, 0, 255), Clamp(Arr, 0, 255));
                return resultColor;
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
