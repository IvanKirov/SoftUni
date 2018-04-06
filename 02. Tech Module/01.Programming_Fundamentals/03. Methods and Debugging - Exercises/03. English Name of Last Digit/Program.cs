using System;

namespace _03.English_Name_of_Last_Digit
{
    public class EnglishNameofLastDigit
    {
        private static string ReturnsEnglishName(long number)
        {
            long lastDigit = Math.Abs(number) % 10;
            switch (lastDigit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "Wrong input";
            }
        }

        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            var answer = ReturnsEnglishName(number);

            Console.WriteLine(answer);

            // as above
            // string[] names = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            // Console.WriteLine(names[Math.Abs(number % 10)]);
        }
    }
}
