using System;

namespace GenericsProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics");

            int firstNumber = 15;
            int secondNumber = 25;
            int thirdNumber = 5;

            int result = MaximumNumber.MaxInt(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine($"{result} is the greatest number");
        }
    }
}
