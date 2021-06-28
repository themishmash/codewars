// Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. Return the resulting string.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CodeWars
{
    public static class FakeBinary
    {
        public static string FakeBin(string x)
        {
            var result = "";
            foreach (var c in x)
            {
                var cInt = CharUnicodeInfo.GetDecimalDigitValue(c);
                if (cInt < 5)
                {
                    result += "0"; 
                }
                else
                {
                    result += "1";
                }
            }
            return result;

        }
    }
}