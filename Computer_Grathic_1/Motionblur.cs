using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Computer_Grathic_1
{
    internal class Motionblur: MatrixFilter
    {
        public Motionblur() {
            int sizeX = 5;
            int sizeY = 5;
            kernel = new float[sizeX, sizeY];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                   if (i== j)
                    {
                        kernel[i, j] = 1.0f/3f;
                    }
                    else
                    {
                        kernel[i, j] = 0;
                    }
                }
            }
        }
    }
}
