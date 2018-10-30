using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to calculate some numbers? (Yes or No)");
            string answer = Console.ReadLine();
            while(answer!="Yes")
            {
                Console.WriteLine("Do you want to calculate some numbers? (Yes or No)");
                answer = Console.ReadLine();
            }
            Console.WriteLine("Enter a value for the first number:");
            double numOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value for the second number:");
            double numTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation you wish to use:");
            char symbol = char.Parse(Console.ReadLine());
            if(symbol=='+')
            {
                Console.WriteLine($"The result is {(numOne + numTwo)*0.1}.");
            }
            else if(symbol=='-')
            {
                Console.WriteLine($"The result is {(numOne - numTwo)}.");
            }
            else if(symbol=='*')
            {
                Console.WriteLine($"The result is {numOne * numTwo}.");
            }
            else if(symbol=='/')
            {
                Console.WriteLine($"The result is {numOne / numTwo}.");
            }
            else
            {
                Console.WriteLine("Such an operation does not exist.");
            }
        }
    }
}
