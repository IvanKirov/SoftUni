using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Pokemon_Trainer
{
    public class StartUp
    {
        public static void Main()
        {            
            var trainers = new Dictionary<string, Trainer>();

            AddTrainersAndPokemons(trainers);
            TournamentBattle(trainers);

            foreach (var trainer in trainers.OrderByDescending(t => t.Value.Badges).ThenBy(t => t.Value.Id))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.Badges} {trainer.Value.Pokemons.Count}");
            }
        }

        private static void TournamentBattle(Dictionary<string, Trainer> trainers)
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Value.Pokemons.Exists(e => e.Element == input))
                    {
                        trainer.Value.Badges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Value.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }

                        trainer.Value.Pokemons.RemoveAll(p => p.Health <= 0);
                    }
                }
            }
        }

        private static void AddTrainersAndPokemons(Dictionary<string, Trainer> trainers)
        {
            string input;
            var id = 1;

            while ((input = Console.ReadLine()) != "Tournament")
            {
                var tokens = input.Split().ToArray();

                var trainerName = tokens[0];

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName] = new Trainer(id);
                }

                var pokemonName = tokens[1];
                var pokemonElement = tokens[2];
                var pokemonHealth = int.Parse(tokens[3]);

                var newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                trainers[trainerName].Pokemons.Add(newPokemon);
                id++;
            }
        }
    }
}
