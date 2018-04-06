using System;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double absDiffernce = Math.Abs(firstNumber - secondNumber);
            Console.WriteLine(absDiffernce < eps ? "True":"False");
        }
    }
}
