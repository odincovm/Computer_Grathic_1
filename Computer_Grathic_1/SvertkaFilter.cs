using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace Computer_Grathic_1
{
    class SvertkaFilter : MatrixFilter
    {
        public SvertkaFilter()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            kernel[0, 0] = 0.5f;
            kernel[1, 0] = 0.75f;
            kernel[2, 0] = 0.5f;
            kernel[0, 1] = 0.75f;
            kernel[1, 1] = 1f;
            kernel[2, 1] = 0.75f;
            kernel[0, 2] = 0.5f;
            kernel[1, 2] = 0.75f;
            kernel[2, 2] = 0.5f;
        }
    }
}
