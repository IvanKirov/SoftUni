using System;

namespace _04.Sieve_of_Eratosthenes
{
    public class SieveOfEratosthenes
    {
        private static string SieveOfErat(int[] arrayInput, bool[] checkNumbers, string primeNumbers)
        {
            checkNumbers[0] = false;
            checkNumbers[1] = false;

            for (int i = 0; i < arrayInput.Length; i++)
            {
                if (checkNumbers[i])
                {
                    primeNumbers += $"{arrayInput[i]} ";

                    for (int j = i + 1; j < arrayInput.Length; j++)
                    {
                        if (arrayInput[j] % i == 0 && checkNumbers[j] == true)
                        {
                            checkNumbers[j] = false;
                        }
                    }
                }
            }

            return primeNumbers;
        }

        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            int[] arrayInput = new int[number + 1];
            bool[] checkNumbers = new bool[number + 1];

            string primeNumbers = null;

            for (int i = 0; i <= number; i++)
            {
                arrayInput[i] = i;
                checkNumbers[i] = true;
            }

            primeNumbers = SieveOfErat(arrayInput, checkNumbers, primeNumbers);

            Console.WriteLine(primeNumbers.Trim());
        }
    }
}