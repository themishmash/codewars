// Given two integers a and b, which can be positive or negative, find the sum of all the numbers between including them too and return it. If the two numbers are equal return a or b.
//
// Note: a and b are not ordered!

// GetSum(1, 0) == 1   // 1 + 0 = 1
// GetSum(1, 2) == 3   // 1 + 2 = 3
// GetSum(0, 1) == 1   // 0 + 1 = 1
// GetSum(1, 1) == 1   // 1 Since both are same
// GetSum(-1, 0) == -1 // -1 + 0 = -1
// GetSum(-1, 2) == 2  // -1 + 0 + 1 + 2 = 2

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class SumOfNumbers
    {

        public static int GetSum(int a, int b)
        {
            var newA = a;
            var newB = b;
            if (a > b)
            {
                newA = b;
                newB = a;
            }
            var allNumbers = Enumerable.Range(newA, (newB-newA)+1);
            return allNumbers.Sum();
        }
        
        public static int GetSum2(int a, int b)
        {
            IEnumerable<int> allNumbers;
            if (a > b)
            {
                allNumbers = Enumerable.Range(b,(a-b)+1);
                return allNumbers.Sum();
            }
            allNumbers = Enumerable.Range(a, (b-a)+1);

            return allNumbers.Sum();

        }
    }
}

//order the int (?)
//get the range of numbers - maybe in a list
//add all numbers in the list (some numbers could be negative) --> using sum

