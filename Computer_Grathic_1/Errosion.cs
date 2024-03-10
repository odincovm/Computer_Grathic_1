using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Grathic_1
{
    internal class Errosion:Morfology
    {
        public Errosion(int[,] mask)
        {
            this.mask = mask;
            isDilation = false;
        }
    }
}
