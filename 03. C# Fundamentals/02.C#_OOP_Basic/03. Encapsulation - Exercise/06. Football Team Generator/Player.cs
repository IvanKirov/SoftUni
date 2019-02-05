using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Team_Generator
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        private double overalSkillLevel;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
            overalSkillLevel = (Endurance + Sprint + Dribble + Passing + Shooting) / 5D;
        }        

        public double OveralSkillLevel { get => overalSkillLevel; }

        public int Shooting
        {
            get => shooting; 
            set
            {
                ValidateStat(value, nameof(Shooting));
                shooting = value;
            }
        }

        public int Passing
        {
            get => passing; 
            set
            {
                ValidateStat(value, nameof(Passing));
                passing = value;
            }
        }

        public int Dribble
        {
            get => dribble; 
            set
            {
                ValidateStat(value, nameof(Dribble));
                dribble = value;
            }
        }

        public int Sprint
        {
            get => sprint; 
            set
            {
                ValidateStat(value, nameof(Sprint));
                sprint = value;
            }
        }

        public int Endurance
        {
            get => endurance; 
            set
            {
                ValidateStat(value, nameof(Endurance));                
                endurance = value;
            }
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

        private void ValidateStat(int value, string statName)
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{statName} should be between 0 and 100.");
            }
        }
    }
}
