// An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.
//
// isIsogram "Dermatoglyphics" == true
// isIsogram "aba" == false
// isIsogram "moOse" == false -- ignore letter case


using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class Isograms
    {
        public static bool IsIsogram(string str)
        {
            var lowerCaseString = str.ToLower();
            var d = new Dictionary<char, int>();
 
            foreach (var c in lowerCaseString)
            {
                if (d.ContainsKey(c))
                    return false;
                d.Add(c, 1);
            }
            return true;
        } 
        
        public static bool IsIsogramGreatAnswer(string str) 
        {
            return str.ToLower().Distinct().Count()==str.Length;
        }
    }
}