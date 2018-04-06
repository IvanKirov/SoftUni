using System;

namespace _01.Reverse_String
{
    public class ReverseString
    {
        public static void Main()
        {
            string inputText = Console.ReadLine();

            var answer = string.Empty;

            for (int i = 0; i < inputText.Length; i++)
            {
                answer += inputText.Substring(inputText.Length - i - 1, 1);
            }
            
            Console.WriteLine(answer);
        }
    }
}
