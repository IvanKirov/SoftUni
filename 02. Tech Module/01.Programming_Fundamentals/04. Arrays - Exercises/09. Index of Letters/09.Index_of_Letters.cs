using System;

namespace _09.Index_of_Letters
{
    public class IndexOfLetters
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]} -> {input[i] - 'a'}");
            }
        }
    }
}
