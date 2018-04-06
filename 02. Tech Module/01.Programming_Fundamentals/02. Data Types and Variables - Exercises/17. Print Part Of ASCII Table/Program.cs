using System;

namespace _17.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstChar = int.Parse(Console.ReadLine());
            var lastChar = int.Parse(Console.ReadLine());
            for (int printChar = firstChar; printChar <= lastChar; printChar++)
            {
                Console.Write(Convert.ToChar(printChar)+" ");
            }
        }
    }
}
