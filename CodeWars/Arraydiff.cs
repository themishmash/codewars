// Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.
//
// It should remove all values from list a, which are present in list b.
//
// Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
// If a value is present in b, all of its occurrences must be removed from the other:
//
// Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class Arraydiff
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {

            var newList = new List<int>();
            var newArray = a.Concat(b);
            var duplicateItems = newArray.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key).ToArray();
         
            
            foreach (var item in newArray)
            {
                foreach (var num in duplicateItems)
                {
                    if (item != num)
                    {
                        newList.Add(item);
                    }
                }
            }

            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }

            return newList.ToArray();
        }
    }
}