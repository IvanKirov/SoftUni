using System;

namespace MythicalNumbers
{
    public class MythicalNumbers
    {
        public static void Main()
        {
            /*decimal number = decimal.Parse(Console.ReadLine());

            decimal firstDigit = Math.Truncate(number / 100);
            decimal secondDigit = (Math.Truncate(number / 10)) % 10;
            decimal thirdDigit = number % 10;*/

            var input = Console.ReadLine();

            decimal firstDigit = input[0] - 48;
            decimal secondDigit = input[1] - 48;
            decimal thirdDigit = input[2] - 48;

            var digitOne = (decimal)Char.GetNumericValue(input[0]);
            var digitTwo = (decimal)Char.GetNumericValue(input[1]);
            var digitThree = (decimal)Char.GetNumericValue(input[2]);

            if (thirdDigit == 0)
            {
                decimal produktOne = firstDigit * secondDigit;
                Console.WriteLine("{0:f2}", produktOne);
            }
            else if (thirdDigit > 0 && thirdDigit <= 5)
            {
                decimal produktTwo = (firstDigit * secondDigit) / thirdDigit;
                Console.WriteLine("{0:f2}", produktTwo);
            }
            else
            {
                decimal produktThree = (firstDigit + secondDigit) * thirdDigit;
                Console.WriteLine("{0:f2}", produktThree);
            }
        }
    }
}
