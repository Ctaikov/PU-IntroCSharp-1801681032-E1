using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isZero = false;
            while(!isZero)
            {
                Console.WriteLine("Enter a number:");
                int num = int.Parse(Console.ReadLine());
                isZero = true;
            }
        }
    }
}
