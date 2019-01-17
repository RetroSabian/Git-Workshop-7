using System;
using System.Collections.Generic;
using System.Text;

namespace Git_workshop_7
{
    class square
    {
        double side;
        public square(double s)
        {
            side = s;
        }

        public double Area()
        {
            return side * side;
        }
    }
}
