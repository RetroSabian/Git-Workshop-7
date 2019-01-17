using System;
using System.Collections.Generic;
using System.Text;

namespace Git_workshop_7
{
    class rectangle
    {
        double length, breadth;
        public rectangle(double l, double b)
        {
            length = l;
            breadth = b;
        }

        public double Area()
        {
           return length * breadth;
        }

    }
}
