using System;
using System.Collections.Generic;
using System.Text;

namespace Git_workshop_7
{
    class Triangle
    {
        double hypotenuse, width, height;
        public Triangle(int w, int s, int h)
        {
            hypotenuse = s;
            width = w;
            height = h;
        }

        public double Area()
        {
            return width * height * 0.5;
        }
        public double Area(double w, double h)
        {
            return w * h * 0.5;
        }

    }
}
