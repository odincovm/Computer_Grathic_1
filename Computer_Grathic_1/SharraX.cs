using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace Computer_Grathic_1
{
    internal class SharraX : MatrixFilter
    {
        public SharraX()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            kernel[0, 0] = 3f;
            kernel[1, 0] = 10f;
            kernel[2, 0] = 3f;
            kernel[0, 1] = 0f;
            kernel[1, 1] = 0f;
            kernel[2, 1] = 0f;
            kernel[0, 2] = -3f;
            kernel[1, 2] = 10f;
            kernel[2, 2] = -3f;
        }
    }
}
