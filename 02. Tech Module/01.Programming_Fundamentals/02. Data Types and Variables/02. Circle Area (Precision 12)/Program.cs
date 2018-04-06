using System;

namespace _02.Circle_Area__Precision_12_
{
    class Program
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f12}",Math.PI*radius*radius);
        }
    }
}
