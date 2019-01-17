using System;

namespace Git_workshop_7
{
    class Circle
    {
        double radius;
        public Circle(double r)
        {
            radius = r;
        }
        public double Area(){
            return Math.PI * radius * radius;
        }
    }
}
