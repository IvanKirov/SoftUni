using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_Reversed_Numbers
{
    public class SumReversedNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var sumReversedNumbers = 0;

            foreach (var number in numbers)
            {
                var currentNumberLenght = number.ToString();
                var currentNumber = number;
                var reversedNumber = 0;

                for (int i = currentNumberLenght.Length - 1; i >=0 ; i--)
                {
                    var currentDigit = currentNumber % 10;  // vzemam poslednata cifra
                    currentNumber = currentNumber / 10;     // maham poslednata cifra
                    reversedNumber = int.Parse(reversedNumber.ToString() + currentDigit); // zalepyam novata cifra za chisloto
                }

                sumReversedNumbers += reversedNumber;
            }

            Console.WriteLine(sumReversedNumbers);
        }
    }
}
