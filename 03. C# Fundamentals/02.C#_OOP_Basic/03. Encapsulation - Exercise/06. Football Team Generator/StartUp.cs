using System;
using System.Collections.Generic;
using System.Linq;

namespace Football_Team_Generator
{
    public class StartUp
    {
        public static void Main()
        {
            var teams = new List<Team>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split(';');

                try
                {
                    switch (tokens[0])
                    {
                        case "Team":
                            var name = tokens[1];
                            teams.Add(new Team(name));
                            break;
                        case "Add":
                            AddPlayerToTeam(teams, tokens);
                            break;
                        case "Remove":
                            RemovePlayerFromteam(teams, tokens);
                            break;
                        case "Rating":
                            var teamName = tokens[1];
                            CheckTeamExists(teams, teamName);
                            teams.First(t => t.Name == teamName).Raiting();
                            break;
                    }
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message); 
                }
            }
        }

        private static void RemovePlayerFromteam(List<Team> teams, string[] tokens)
        {
            var teamName = tokens[1];
            CheckTeamExists(teams, teamName);

            var playerName = tokens[2];
            var team = teams.First(t => t.Name == teamName);
            team.RemovePlayer(playerName);
        }

        private static void AddPlayerToTeam(List<Team> teams, string[] tokens)
        {
            var teamName = tokens[1];
            CheckTeamExists(teams, teamName);

            var playerName = tokens[2];
            var endurance = int.Parse(tokens[3]);
            var sprint = int.Parse(tokens[4]);
            var dribble = int.Parse(tokens[5]);
            var passing = int.Parse(tokens[6]);
            var shooting = int.Parse(tokens[7]);
            var player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

            var team = teams.First(t => t.Name == teamName);
            team.AddPlayer(player);
        }

        private static void CheckTeamExists(List<Team> teams, string name)
        {
            if (!teams.Exists(t => t.Name == name))
            {
                throw new ArgumentException($"Team {name} does not exist.");
            }
        }
    }
}
