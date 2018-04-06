using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var broi = int.Parse(Console.ReadLine());
            int sumOld = 0;
            int sumNew = 0;
            int razlika = 0;
            var oddNumber = int.Parse(Console.ReadLine());
            var evenNumber = int.Parse(Console.ReadLine());
            sumOld = oddNumber + evenNumber;
            for (int i = 1; i <= broi-1; i++)
            {
                oddNumber = int.Parse(Console.ReadLine());
                evenNumber = int.Parse(Console.ReadLine());
                sumNew = oddNumber + evenNumber;
                if (sumOld != sumNew)
                {
                    razlika = Math.Abs(sumOld-sumNew);
                    sumOld = sumNew;
                }
            }            
            if (razlika == 0)
            {
                Console.WriteLine("Yes, value=" + sumOld);
            }
            else
            {
                Console.WriteLine("No, maxdiff=" + razlika);
            }
        }
    }
}
