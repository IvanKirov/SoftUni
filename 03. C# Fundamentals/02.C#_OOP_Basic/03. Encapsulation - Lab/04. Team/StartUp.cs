using System;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var team = new Team("SoftUni");

            for (int i = 0; i < lines; i++)
            {
                var args = Console.ReadLine().Split();
                var person = new Person(args[0], args[1], int.Parse(args[2]), decimal.Parse(args[3]));

                team.AddPlayer(person);
            }

            Console.WriteLine($"First team have {team.FirstTeam.Count} players");
            Console.WriteLine($"Reserve team have {team.ReserveTeam.Count} players");
        }
    }
}
