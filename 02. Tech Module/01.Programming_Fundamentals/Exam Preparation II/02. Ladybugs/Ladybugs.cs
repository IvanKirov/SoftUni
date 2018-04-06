using System;
using System.Linq;

namespace _02.Ladybugs
{
    public class Ladybugs
    {
        public static void Main()
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var ladybugsIndexes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Where(i => i >= 0 && i < fieldSize)
                .ToArray();

            var ladybugs = new int[fieldSize];

            for (int i = 0; i < ladybugsIndexes.Length; i++)
            {
                var currentLadybugIndex = ladybugsIndexes[i];
                ladybugs[currentLadybugIndex] = 1;
            }

            var inputComands = Console.ReadLine();
            while (inputComands != "end")
            {
                var tokens = inputComands.Split();
                var ladybugIndex = int.Parse(tokens[0]);
                var direction = tokens[1];
                var flyLength = int.Parse(tokens[2]);

                if (ladybugIndex < 0 || ladybugIndex >= ladybugs.Length)
                {
                    inputComands = Console.ReadLine();
                    continue;
                }

                if (ladybugs[ladybugIndex] == 0)
                {
                    inputComands = Console.ReadLine();
                    continue;
                }

                moveLadybugs(ladybugs, ladybugIndex, direction, flyLength);
                inputComands = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", ladybugs));
        }

        public static void moveLadybugs(int[] ladybugs, int ladybugIndex, string direction, int flyLength)
        {
            ladybugs[ladybugIndex] = 0;

            var leftArrayOrFoundPlace = false;

            while (!leftArrayOrFoundPlace)
            {
                switch (direction)
                {
                    case "left":
                        ladybugIndex -= flyLength;
                        break;
                    case "right":
                        ladybugIndex += flyLength;
                        break;
                    default:
                        break;
                }

                if (ladybugIndex < 0 || ladybugIndex >= ladybugs.Length)
                {
                    leftArrayOrFoundPlace = true;
                    continue;
                }

                if (ladybugs[ladybugIndex] == 1)
                {

                }

                if (ladybugs[ladybugIndex] == 0)
                {
                    ladybugs[ladybugIndex] = 1;
                    leftArrayOrFoundPlace = true;
                    continue;
                }
            }
        }
    }
}
