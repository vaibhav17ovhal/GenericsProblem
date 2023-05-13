using System;

namespace GenericsProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics");
            
            string firstNumber2 = "Vaibhav";
            string secondNumber2 = "vai";
            string thirdNumber2 = "vaibhavovhal";

            string result2 = MaximumNumber.MaxString(firstNumber2, secondNumber2, thirdNumber2);
            Console.WriteLine($"{result2} is the greatest string length");
        }
    }
}
