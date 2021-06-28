// Implement a function that adds two numbers together and returns their sum in binary. The conversion can be done before, or after the addition.
//
// The binary number returned should be a string.

using System;
using System.Collections.Generic;

namespace CodeWars
{
    public static class BinaryAddition
    {
        public static string AddBinary(int a, int b)
        {
            var sum = a + b;
            var output = Convert.ToString(sum, 2);
            return output;
        }

        public static string AddBinary2(int a, int b)
        {
            var sum = a + b;
            var binary = "";
            while (sum > 0)
            {
                binary = binary.Insert(0, sum % 2 == 1 ? "1" : "0");
                var i = sum >> 1;
            }

            return binary;
        }
    }
}