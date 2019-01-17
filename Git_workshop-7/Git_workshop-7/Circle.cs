using System;

namespace Git_workshop_7
{
    class Circle
    {
        public void Area(){
            double radius = Console.Read();
            Console.WriteLine("The circle radius is "+Math.pi*radius*radius);
        }
    }
}
