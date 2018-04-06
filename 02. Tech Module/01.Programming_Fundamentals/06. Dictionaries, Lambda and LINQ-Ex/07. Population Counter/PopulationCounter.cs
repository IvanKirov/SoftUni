using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Population_Counter
{
    class PopulationCounter
    {
        public static void Main()
        {
            var countryPopulation = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();

            while (input != "report")
            {
                string[] inputList = input.Split('|');
                var cityName = inputList[0];
                var country = inputList[1];
                long population = long.Parse(inputList[2]);

                if (!countryPopulation.ContainsKey(country))
                {
                    countryPopulation[country] = new Dictionary<string, long>();
                }
                if (!countryPopulation[country].ContainsKey(cityName))
                {
                    countryPopulation[country][cityName] = population;
                }
                else 
                {
                    countryPopulation[country][cityName] += population;
                }

                input = Console.ReadLine();
            }

            var countryTotalPopulation = new Dictionary<string, long>();

            foreach (KeyValuePair<string, Dictionary<string, long>> state in countryPopulation)
            {
                long totalPopulation = 0;

                foreach (KeyValuePair<string, long> pair in state.Value)
                {
                    totalPopulation += pair.Value;
                }

                countryTotalPopulation[state.Key] = totalPopulation;
            }

            foreach (KeyValuePair<string, long> state in countryTotalPopulation
                .OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{state.Key} (total population: {state.Value})");
                foreach (KeyValuePair<string, Dictionary<string, long>> c in countryPopulation)
                {
                    if (c.Key == state.Key)
                    {
                        foreach (KeyValuePair<string, long> pair in c.Value.OrderByDescending(x => x.Value))
                        {
                            Console.WriteLine($"=>{pair.Key}: {pair.Value}");
                        }
                    } 
                }
            }
        }
    }
}
