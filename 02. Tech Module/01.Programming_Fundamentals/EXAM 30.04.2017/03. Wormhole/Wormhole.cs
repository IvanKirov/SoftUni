using System;
using System.Linq;

namespace _03.Wormhole
{
    public class Wormhole
    {
        public static void Main()
        {
            var wormholeList = Console.ReadLine()
                .Split()                    // new[] {' '}, StringSplitOptions.RemoveEmptyEntries
                .Select(int.Parse)
                .ToList();

            var counter = 0;
            var length = wormholeList.Count;

            for (int i = 0; i < length; i++)
            {
                counter += 1;
                if (wormholeList[i] > 0)
                {
                    var newIndex = wormholeList[i];
                    wormholeList[i] = 0;
                    i = newIndex;                    
                }
            }

            Console.WriteLine(counter);
        }
    }
}
