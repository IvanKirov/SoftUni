using System;

namespace _04.Numbers_in_Reversed_Order
{
    public class NumbersInReversedOrder
    {
        public static double ReversedNumber(double number)
        {
            var numString = number.ToString();
            var reversedString = string.Empty;
            // foreach (decimal digit in number.ToString())
            for (int i = numString.Length - 1; i >= 0; i--)
            {
                reversedString += numString[i]; 
            }

            var reversedNumber = double.Parse(reversedString);
            return reversedNumber;
        }

        public static void Main()
        {
            var number = Math.Abs(double.Parse(Console.ReadLine()));

            var answer = ReversedNumber(number);

            Console.WriteLine(answer);

            // string number = Console.ReadLine();
            // number = new string(number.ToCharArray().Reverse().ToArray());
            // Console.WriteLine(number);
        }
    }
}
