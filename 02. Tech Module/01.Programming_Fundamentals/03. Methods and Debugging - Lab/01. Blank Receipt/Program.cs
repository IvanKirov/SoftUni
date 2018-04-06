using System;

namespace _01.Blank_Receipt
{
    public class Program
    {
        public static void PrintReceitHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        public static void PrintReceitBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        public static void PrintReceitFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }

        public static void PrintReceit()
        {
            PrintReceitHeader();
            PrintReceitBody();
            PrintReceitFooter();
        }

        public static void Main()
        {
            PrintReceit();
        }
    }
}
