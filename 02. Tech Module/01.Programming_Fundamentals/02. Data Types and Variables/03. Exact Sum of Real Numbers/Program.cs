﻿using System;

namespace _03.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum=0;
            for (int i = 0; i < n; i++)
            {
                var stoinost = decimal.Parse(Console.ReadLine());
                sum += stoinost;
            }
            Console.WriteLine(sum);
        }
    }
}
