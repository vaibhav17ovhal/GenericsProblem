using System;

namespace GenericsProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics");

            int firstNumber3 = 10;
            int secondNumber3 = 80;
            int thirdNumber3 = 50;

            int result3 = GenericMax<int>.Max(firstNumber3, secondNumber3, thirdNumber3);
            Console.WriteLine(result3);
        }
    }
}
