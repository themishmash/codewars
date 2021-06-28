// In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.
//
// Example
// ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"}) => {1, 2}
// ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", 0, 15}) => {1, 2, 0, 15}
// ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", "aasf", "1",

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class ListFiltering
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return listOfItems.OfType<int>().ToArray();
          
        }
    }
}