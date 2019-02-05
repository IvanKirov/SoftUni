using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Football_Team_Generator
{
    public class Team
    {
        private string name;
        private double rating;
        private List<Player> players;

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }
        
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            Player player = players.Find(p => p.Name == playerName);
            if (player == null)
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }
            players.Remove(player);
        }

        public void Raiting()
        {
            var raiting = 0d;
            foreach (Player player in this.players)
            {
                raiting += player.OveralSkillLevel;
            }

            Console.WriteLine(this.Name + " - " + Math.Round(raiting));
        }
    }
}
