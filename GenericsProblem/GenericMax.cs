﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class GenericMax<T> where T : IComparable
    {
        public static T Max(T firstNumber3, T secondNumber3, T thirdNumber3)
        {
            if (firstNumber3.CompareTo(secondNumber3) > 0 && firstNumber3.CompareTo(thirdNumber3) > 0 ||
                firstNumber3.CompareTo(secondNumber3) >= 0 && firstNumber3.CompareTo(thirdNumber3) > 0 ||
                firstNumber3.CompareTo(secondNumber3) > 0 && firstNumber3.CompareTo(thirdNumber3) >= 0)
            {
                return firstNumber3;
            }

            else if (secondNumber3.CompareTo(firstNumber3) > 0 && secondNumber3.CompareTo(thirdNumber3) > 0 ||
                secondNumber3.CompareTo(firstNumber3) >= 0 && secondNumber3.CompareTo(thirdNumber3) > 0 ||
                secondNumber3.CompareTo(firstNumber3) > 0 && secondNumber3.CompareTo(thirdNumber3) >= 0)
            {
                return secondNumber3;
            }

            else if (thirdNumber3.CompareTo(firstNumber3) > 0 && thirdNumber3.CompareTo(secondNumber3) > 0 ||
                thirdNumber3.CompareTo(firstNumber3) >= 0 && thirdNumber3.CompareTo(secondNumber3) > 0 ||
                thirdNumber3.CompareTo(firstNumber3) > 0 && thirdNumber3.CompareTo(secondNumber3) >= 0)
            {
                return thirdNumber3;
            }
            return firstNumber3;
        }
    }
}
