using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Sum_big_numbers
{
    public class SumBigNumbers
    {
        public static void Main()
        {
            var text = new List<string>();
            text.Add(Console.ReadLine().TrimStart(new char[] { '0' }));
            text.Add(Console.ReadLine().TrimStart(new char[] { '0' }));
            
            var firstNumber = text
                .OrderByDescending(s => s.Length)
                .First()                
                .ToCharArray();

            Array.Reverse(firstNumber);

            var secondNumber = text
                .OrderByDescending(s => s.Length)
                .Last()
                .ToCharArray();

            Array.Reverse(secondNumber);

            var length = Math.Min(firstNumber.Length, secondNumber.Length);

            var remainder = 0;
            var answer = string.Empty;

            for (int i = 0; i < length; i++)
            {
                var digitOne = (int)char.GetNumericValue(firstNumber[i]);
                var digitTwo = (int)char.GetNumericValue(secondNumber[i]);

                var sum = digitOne + digitTwo + remainder;
                remainder = 0;

                if (sum > 9)
                {
                    var digit = sum % 10;
                    remainder = sum / 10;
                    answer = digit + answer;
                }
                else
                {
                    answer = sum + answer;
                }
            }
            
            if (remainder > 0 && firstNumber.Length != secondNumber.Length)
            {
                for (int i = length; i < firstNumber.Length; i++)
                {
                    var digit = (int)char.GetNumericValue(firstNumber[i]);

                    var sum = digit + remainder;
                    remainder = 0;

                    if (sum > 9)
                    {
                        var lastDigit = sum % 10;
                        remainder = sum / 10;
                        answer = lastDigit + answer;
                    }
                    else
                    {
                        answer = sum + answer;
                    }
                }
            }
            else if (firstNumber.Length != secondNumber.Length)
            {
                for (int i = length; i < firstNumber.Length; i++)
                {
                    answer = firstNumber[i] + answer;
                }
            }

            if (remainder > 0)
            {
                answer = remainder + answer;
            } 
            
            Console.WriteLine(answer);
        }
    }
}
