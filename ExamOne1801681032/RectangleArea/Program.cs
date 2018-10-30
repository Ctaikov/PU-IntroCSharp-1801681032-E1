using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double a = random.Next(1,100);
            double b = random.Next(1, 200);
            double RectangleArea = a * b;
            Console.WriteLine($"The rectangle height is a={a}cm.");
            Console.WriteLine($"The rectangle width is b={b}cm.");
            Console.WriteLine("The Rectangle area is:");
            Console.WriteLine(Math.Round(RectangleArea,2));
        }
    }
}
