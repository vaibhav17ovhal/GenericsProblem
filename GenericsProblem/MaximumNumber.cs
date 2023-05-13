using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class MaximumNumber
    {
        public static int MaxInt(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0 ||
                firstNumber.CompareTo(secondNumber) >= 0 && firstNumber.CompareTo(thirdNumber) > 0 ||
                firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) >= 0)
            {
                return firstNumber;
            }

            else if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0 ||
                secondNumber.CompareTo(firstNumber) >= 0 && secondNumber.CompareTo(thirdNumber) > 0 ||
                secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) >= 0)
            {
                return secondNumber;
            }

            else if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0 ||
                thirdNumber.CompareTo(firstNumber) >= 0 && thirdNumber.CompareTo(secondNumber) > 0 ||
                thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) >= 0)
            {
                return thirdNumber;
            }
            return 0;
        }

        public static double MaxDouble(double firstNumber1, double secondNumber1, double thirdNumber1)
        {
            if (firstNumber1.CompareTo(secondNumber1) > 0 && firstNumber1.CompareTo(thirdNumber1) > 0 ||
                firstNumber1.CompareTo(secondNumber1) >= 0 && firstNumber1.CompareTo(thirdNumber1) > 0 ||
                firstNumber1.CompareTo(secondNumber1) > 0 && firstNumber1.CompareTo(thirdNumber1) >= 0)
            {
                return firstNumber1;
            }

            else if (secondNumber1.CompareTo(firstNumber1) > 0 && secondNumber1.CompareTo(thirdNumber1) > 0 ||
                secondNumber1.CompareTo(firstNumber1) >= 0 && secondNumber1.CompareTo(thirdNumber1) > 0 ||
                secondNumber1.CompareTo(firstNumber1) > 0 && secondNumber1.CompareTo(thirdNumber1) >= 0)
            {
                return secondNumber1;
            }

            else if (thirdNumber1.CompareTo(firstNumber1) > 0 && thirdNumber1.CompareTo(secondNumber1) > 0 ||
                thirdNumber1.CompareTo(firstNumber1) >= 0 && thirdNumber1.CompareTo(secondNumber1) > 0 ||
                thirdNumber1.CompareTo(firstNumber1) > 0 && thirdNumber1.CompareTo(secondNumber1) >= 0)
            {
                return thirdNumber1;
            }
            return 0;
        }
    }
}
