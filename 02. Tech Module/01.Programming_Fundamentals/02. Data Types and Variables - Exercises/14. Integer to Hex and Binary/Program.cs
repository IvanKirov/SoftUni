using System;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputDecimal = int.Parse(Console.ReadLine());            
            Console.WriteLine(Convert.ToString(inputDecimal, 16).ToUpper());
            Console.WriteLine(Convert.ToString(inputDecimal, 2));
        }
    }
}
