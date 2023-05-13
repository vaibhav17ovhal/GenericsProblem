using System;

namespace GenericsProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics");

            double firstNumber1 = 80.88;
            double secondNumber1 = 50.55;
            double thirdNumber1 = 10.11;

            double result1 = MaximumNumber.MaxDouble(firstNumber1, secondNumber1, thirdNumber1);
            Console.WriteLine($"{result1} is the greatest float number");
        }
    }
}
