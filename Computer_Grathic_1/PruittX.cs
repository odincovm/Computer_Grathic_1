using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace Computer_Grathic_1
{
    internal class PruittX : MatrixFilter
    {
        public PruittX()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            kernel[0, 0] = -1f;
            kernel[1, 0] = -1f;
            kernel[2, 0] = -1f;
            kernel[0, 1] = 0f;
            kernel[1, 1] = 0f;
            kernel[2, 1] = 0f;
            kernel[0, 2] = 1f;
            kernel[1, 2] = 1f;
            kernel[2, 2] = 1f;
        }
    }
}
