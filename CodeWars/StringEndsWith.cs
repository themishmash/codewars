// Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).
//
// Examples:
//
// solution('abc', 'bc') // returns true
// solution('abc', 'd') // returns false

using System.Linq;

namespace CodeWars
{
    public static class StringEndsWith
    {
        public static bool Solution(string str, string ending)
        {
            return str.Contains(ending) && ending.Contains(str.Last()) || ending == "";
        }
    }
}