using System;

namespace Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            var Animal = Console.ReadLine();
            switch (Animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "snake":
                case "tortoise":
                case "crocodile":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
