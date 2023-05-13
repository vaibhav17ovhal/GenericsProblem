using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class MaximumNumber
    {
        public static string MaxString(string firstNumber2, string secondNumber2, string thirdNumber2)
        {
            if (firstNumber2.CompareTo(secondNumber2) > 0 && firstNumber2.CompareTo(thirdNumber2) > 0 ||
                firstNumber2.CompareTo(secondNumber2) >= 0 && firstNumber2.CompareTo(thirdNumber2) > 0 ||
                firstNumber2.CompareTo(secondNumber2) > 0 && firstNumber2.CompareTo(thirdNumber2) >= 0)
            {
                return firstNumber2;
            }

            else if (secondNumber2.CompareTo(firstNumber2) > 0 && secondNumber2.CompareTo(thirdNumber2) > 0 ||
                secondNumber2.CompareTo(firstNumber2) >= 0 && secondNumber2.CompareTo(thirdNumber2) > 0 ||
                secondNumber2.CompareTo(firstNumber2) > 0 && secondNumber2.CompareTo(thirdNumber2) >= 0)
            {
                return secondNumber2;
            }

            else if (thirdNumber2.CompareTo(firstNumber2) > 0 && thirdNumber2.CompareTo(secondNumber2) > 0 ||
                thirdNumber2.CompareTo(firstNumber2) >= 0 && thirdNumber2.CompareTo(secondNumber2) > 0 ||
                thirdNumber2.CompareTo(firstNumber2) > 0 && thirdNumber2.CompareTo(secondNumber2) >= 0)
            {
                return thirdNumber2;
            }
            return null;
        }
    }
}
