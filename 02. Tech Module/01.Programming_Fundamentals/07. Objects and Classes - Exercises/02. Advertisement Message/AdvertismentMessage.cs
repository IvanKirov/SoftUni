using System;

namespace _02.Advertisement_Message
{
    public class AdvertismentMessage
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var phrases = new string[]
                {
                    "Excellent product.",
                    "Such a great product.",
                    "I always use that product.",
                    "Best product of its category.",
                    "Exceptional product.",
                    "I can’t live without this product."
                };

            var events = new string[]
                {
                    "Now I feel good.",
                    "I have succeeded with this product.",
                    "Makes miracles. I am happy of the results!",
                    "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.",
                    "I feel great!"
                };

            var author = new string[]
                {
                    "Diana",
                    "Petya",
                    "Stella",
                    "Elena",
                    "Katya",
                    "Iva",
                    "Annie",
                    "Eva"
                };

            var cities = new string[]
                {
                    "Burgas",
                    "Sofia",
                    "Plovdiv",
                    "Varna",
                    "Ruse"
                };

            var random = new Random();

            for (int i = 0; i < number; i++)
            {
                var phraseIndex = random.Next(0, phrases.Length);
                var eventIndex = random.Next(0, events.Length);
                var authotIndex = random.Next(0, author.Length);
                var cityIndex = random.Next(0, cities.Length);

                Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} {author[authotIndex]} - {cities[cityIndex]}");
            }
        }
    }
}
