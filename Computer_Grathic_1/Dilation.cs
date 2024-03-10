using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Grathic_1
{
    internal class Dilation: Morfology
    {
        public Dilation(int[,] mask)
        {
            this.mask = mask;
            isDilation = true;
        }
    }
}
