using System;
using System.Collections.Generic;
using System.Text;

namespace Git_workshop_7
{
    class hexagon
    {
        double side;

        public hexagon(double s)
        {
            side = s;
        }

        public double Area()
        {
            return side * side * 3 / 2 * Math.Sqrt(3);
        }

    }
}
