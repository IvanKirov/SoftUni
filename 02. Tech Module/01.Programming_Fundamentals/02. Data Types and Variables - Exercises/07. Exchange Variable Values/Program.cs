using System;

namespace _07.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int variableA = int.Parse(Console.ReadLine());
            int variableB = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:");
            Console.WriteLine($"a = {variableA}");
            Console.WriteLine($"b = {variableB}");
            Console.WriteLine("After:");
            int swapVariable = variableA;
            variableA = variableB;
            variableB = swapVariable;
            Console.WriteLine($"a = {variableA}");
            Console.WriteLine($"b = {variableB}");
        }
    }
}
