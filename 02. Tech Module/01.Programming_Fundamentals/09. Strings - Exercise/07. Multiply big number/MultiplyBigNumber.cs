using System;

namespace _07.Multiply_big_number
{
    public class MultiplyBigNumber
    {
        public static void Main()
        {
            var text = Console.ReadLine().TrimStart(new char[] { '0' });
            var Number = text.ToCharArray();

            Array.Reverse(Number);

            var multiplier = int.Parse(Console.ReadLine());            
            var answer = string.Empty;

            if (multiplier == 0)
            {
                answer = "0";
            }
            else if (multiplier == 1)
            {
                answer = text;
            }
            else
            {
                var remainder = 0;

                for (int i = 0; i < Number.Length; i++)
                {
                    var digit = (int)char.GetNumericValue(Number[i]);
                    var sum = 0;

                    sum = multiplier * digit + remainder;
                    remainder = 0;

                    var digitAdd = sum % 10;
                    remainder = sum / 10;
                    answer = digitAdd + answer;
                }

                if (remainder > 0)
                {
                    answer = remainder + answer;
                }
            }

            Console.WriteLine(answer);
        }
    }
}
