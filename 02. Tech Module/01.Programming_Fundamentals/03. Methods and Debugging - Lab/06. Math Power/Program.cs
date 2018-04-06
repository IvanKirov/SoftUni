using System;

namespace _06.Math_Power
{
    public class Program
    {
        public static double RaiseToPower(double number, double power)
        {
            double result = number;
            for (int i = 1; i < power; i++)
            {
                result *= number;
            }

            return result;
        }

        public static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            var power = double.Parse(Console.ReadLine());

            var answer = RaiseToPower(number, power);
            Console.WriteLine(answer);
        }
    }
}
