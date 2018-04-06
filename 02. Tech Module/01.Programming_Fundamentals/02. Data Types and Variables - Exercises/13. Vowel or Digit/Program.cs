using System;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {            
            char inputChar = char.Parse(Console.ReadLine());                     
            if (inputChar >= '0' && inputChar <= '9')
            { 
                Console.WriteLine("digit");
            }
            else if (inputChar == 'a' || inputChar == 'e' || inputChar == 'i' || inputChar == 'o' || inputChar == 'u' || inputChar == 'A' || inputChar == 'E' || inputChar == 'I' || inputChar == 'O' || inputChar == 'U')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
