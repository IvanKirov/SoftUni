using System;

namespace _04.Draw_a_Filled_Square
{
    public class Program
    {
        public static void PrintLine(int number)
        {
            Console.WriteLine(new string('-', number * 2));
        }

        public static void PrintMiddleLine(int number)
        {
            Console.Write('-');
            for (int i = 1; i < number; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine('-');
        }

        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            PrintLine(number);
            for (int i = 1; i < number - 1; i++)
            {
                PrintMiddleLine(number);
            }

            PrintLine(number);
        }
    }
}
