using System;

namespace _12.Master_Number
{
    public class MasterNumber
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            for (int masterNumber = 1; masterNumber <= number; masterNumber++)
            {
                if (hasEven(masterNumber) && sumDigits(masterNumber) && isPalindrome(masterNumber))
                {
                    Console.WriteLine(masterNumber);
                }
            }
        }

        private static bool isPalindrome(int number)
        {
            string myString = number.ToString();
            int length = myString.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (myString[i] != myString[length - i - 1])
                    return false;
            }
            return true;
        }

        private static bool sumDigits(int number)
        {
            int sumDigits = 0;
            int newNumber = number;
            while (newNumber >0)
            {
                sumDigits += newNumber % 10;
                newNumber = newNumber / 10;
            }
            if (sumDigits % 7 == 0)
            {
                return true;
            }
            return false;
        }

        private static bool hasEven(int number)
        {
            string n = number.ToString();
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
