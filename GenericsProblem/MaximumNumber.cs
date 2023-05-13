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
    }
}
