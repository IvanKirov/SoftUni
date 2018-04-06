using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.TeamworkProjects
{
    public class TeamworkProjects
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var teamList = new List<Team>();

            for (int i = 0; i < number; i++)
            {
                var stringSplit = Console.ReadLine()
                    .Split('-')
                    .ToArray();

                var nameCreator = stringSplit[0];
                var teamName = stringSplit[1];

                if (!teamList.Any(t => t.Name == teamName))     // if there is no such team
                {
                    if (!teamList.Any(c => c.CreatorName == nameCreator))  // if there is no such creator
                    {
                        var newTeam = new Team();
                        newTeam.Name = teamName;
                        newTeam.CreatorName = nameCreator;
                        newTeam.Members = new List<string>();
                        Console.WriteLine($"Team {teamName} has been created by {nameCreator}!");
                        teamList.Add(newTeam);
                    }
                    else
                    {
                        Console.WriteLine($"{nameCreator} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            var inputText = string.Empty;

            while ((inputText = Console.ReadLine()) != "end of assignment")
            {
                var stringSplit = inputText
                        .Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                var nameMember = stringSplit[0];
                var teamJoin = stringSplit[1];

                if (teamList.Any(t => t.Name == teamJoin))      // has such a team
                {
                    if (teamList.Any(n => n.Members.Contains(nameMember)) ||
                        teamList.Any(n => n.CreatorName == nameMember))    // has such a member or creator
                    {
                        Console.WriteLine($"Member {nameMember} cannot join team {teamJoin}!");
                    }
                    else
                    {
                        var teamIndex = teamList.FindIndex(n => n.Name == teamJoin);
                        teamList[teamIndex].Members.Add(nameMember);
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamJoin} does not exist!");
                }
            }


            var disbandedTeams = new List<string>();

            foreach (var team in teamList.OrderByDescending(c => c.Members.Count).ThenBy(n => n.Name))
            {
                var membersCount = team.Members.Count;
                if (membersCount > 0)
                {
                    Console.WriteLine(team.Name);
                    Console.WriteLine("- " + team.CreatorName);

                    var teamIndex = teamList.FindIndex(n => n.Name == team.Name);
                    var members = teamList[teamIndex].Members;

                    foreach (var member in members.OrderBy(n => n))
                    {
                        Console.WriteLine("-- " + member);
                    }
                }
                else
                {
                    disbandedTeams.Add(team.Name);
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in disbandedTeams.OrderBy(n => n))
            {
                Console.WriteLine(team);
            }
        }
    }
}
