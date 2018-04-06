using System;

namespace _02.Max_Method
{
    public class MaxMetod
    {
        public static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber >= secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            var firstMaxNumber = GetMax(firstNumber, secondNumber);
            var answer = GetMax(firstMaxNumber, thirdNumber);

            Console.WriteLine(answer);
        }
    }
}
