// Given an array of integers.
//
// Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers.
//
// If the input array is empty or null, return an empty array.
//
// Example
// For input [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], you should return [10, -65].

using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CodeWars
{
    public class CountOfPositivesSumNegatives
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
           
            if (input == null || input.Length == 0 )
            {
                return new int[] { };

            }
            var countOfPositiveNumbers = input.Count(number => number > 0);
            var sumOfNegativeNumbers = input.Where(number => number < 0).Sum();
            var result = new int[]  { countOfPositiveNumbers, sumOfNegativeNumbers};
            
            return result; //return an array with count of positives and sum of negatives
        }
    }
}