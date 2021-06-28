
// Take 2 strings s1 and s2 including only letters from ato z. Return a new sorted string, the longest possible, containing distinct letters,

using System;
using System.Linq;

namespace CodeWars

{
    public class TwoToOne
    {
        public static string Longest (string s1, string s2) 
        {
            s1 = "abc";
            s2 = "abcdefg";
            
            var joinedString = s1 + s2;
            var uniqueString = string.Join("", joinedString.ToCharArray().Distinct());
            var sortedString = string.Concat(uniqueString.OrderBy(c => c));
            return sortedString;
        }
    }
}