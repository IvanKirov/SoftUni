using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random randomGenerator;

        public RandomList()
        {
            randomGenerator = new Random();
        }

        public string GetRandomElement()
        {
            if (Count < 1)
            {
                return "No questions left.";
            }
            var index = randomGenerator.Next(0, Count - 1);
            string result = this[index];
            Remove(result);
            return result;
        }
    }
}
