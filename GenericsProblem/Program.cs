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

            double firstNumber1 = 80.88;
            double secondNumber1 = 50.55;
            double thirdNumber1 = 10.11;

            double result1 = MaximumNumber.MaxDouble(firstNumber1, secondNumber1, thirdNumber1);
            Console.WriteLine($"{result1} is the greatest float number");

            string firstNumber2 = "Vaibhav";
            string secondNumber2 = "vai";
            string thirdNumber2 = "vaibhavovhal";

            string result2 = MaximumNumber.MaxString(firstNumber2, secondNumber2, thirdNumber2);
            Console.WriteLine($"{result2} is the greatest string length");

            int firstNumber3 = 10;
            int secondNumber3 = 80;
            int thirdNumber3 = 50;

            int result3 = GenericMax<int>.Max(firstNumber3, secondNumber3, thirdNumber3);
            Console.WriteLine(result3);
        }
    }
}
