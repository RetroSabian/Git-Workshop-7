using System;

namespace Git_workshop_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle(3, 3, 3);
            square s = new square(3);
            Circle c = new Circle(3);
            hexagon h = new hexagon(3);
            rectangle r = new rectangle(3, 3);
            Console.WriteLine("Triangle Area: " + t.Area());
            Console.WriteLine("Square Area: " + s.Area());
            Console.WriteLine("Circle Area: " + c.Area());
            Console.WriteLine("Hexagon Area: " + h.Area());
            Console.WriteLine("Rectangle Area: " + r.Area());
            Console.WriteLine("Press ESC to stop");
            do
            {
                while (!Console.KeyAvailable)
                {
                    // Do something
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
