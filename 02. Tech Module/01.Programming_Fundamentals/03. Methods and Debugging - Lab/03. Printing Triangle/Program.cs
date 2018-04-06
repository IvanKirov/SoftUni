using System;

namespace _03.Printing_Triangle
{
    public class Program
    {
        public static void PrintLine(int star, int end)
        {
            for (int row = star; row <= end; row++)
            {
                Console.Write(row + " ");
            }

            Console.WriteLine();
        }

        public static void TopHalf(int number)
        {
            for (int column = 1; column <= number; column++)
            {
                PrintLine(1, column);
            }
        }

        public static void BottomHalf(int number)
        {
            for (int column = number - 1; column > 0; column--)
            {
                PrintLine(1, column);
            }
        }

        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            TopHalf(number);
            BottomHalf(number);
        }
    }
}
