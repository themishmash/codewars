// Welcome. In this kata, you are asked to square every digit of a number.
//
// For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.
//
// Note: The function accepts an integer and returns an integer

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CodeWars
{
    public static class SquareEveryDigit
    {
        public static int SquareDigits(int n)
        {
            var stringN = n.ToString();
            var result = stringN.Select(CharUnicodeInfo.GetDecimalDigitValue).Select(cInt => cInt * cInt).Aggregate("", (current, squared) => current + squared.ToString());
            return Convert.ToInt32(result);
        }
    }
}