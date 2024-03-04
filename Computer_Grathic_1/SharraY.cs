using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace Computer_Grathic_1
{
    internal class SharraY : MatrixFilter
    {
        public SharraY()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            kernel[0, 0] = 3f;
            kernel[1, 0] = 0f;
            kernel[2, 0] = -3f;
            kernel[0, 1] = 10f;
            kernel[1, 1] = 0f;
            kernel[2, 1] = 10f;
            kernel[0, 2] = 3f;
            kernel[1, 2] = 0f;
            kernel[2, 2] = -3f;
        }
    }
}
