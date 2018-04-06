using System;

namespace _06.Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            for (int firstLetter = 0; firstLetter < number; firstLetter++)
            {
                for (int secondLetter = 0; secondLetter < number; secondLetter++)
                {
                    for (int thirdLetter = 0; thirdLetter < number; thirdLetter++)
                    {
                        char letterOne = (char)('a' + firstLetter);
                        char letterTwo = (char)('a' + secondLetter);
                        char letterThree = (char)('a' + thirdLetter);
                        Console.WriteLine($"{letterOne}{letterTwo}{letterThree}");
                    }

                }

            }
        }
    }
}
