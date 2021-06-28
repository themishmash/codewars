using System.Linq;

namespace CodeWars
{
    public class CountingSheep
    {
        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Count(sheep => sheep);
            // var sheepCount = sheeps.Where(c => c).Count();
            // return sheepCount;
        }
        
    }
}