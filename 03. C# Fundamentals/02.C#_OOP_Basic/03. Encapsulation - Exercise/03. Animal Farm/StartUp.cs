﻿using System;
using AnimalFarm.Models;

namespace Animal_Farm
{
    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Chicken chicken = null;

            try
            {
                chicken = new Chicken(name, age);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                return;
            }

            Console.WriteLine(
                "Chicken {0} (age {1}) can produce {2} eggs per day.",
                chicken.Name,
                chicken.Age,
                chicken.ProductPerDay);
        }
    }
}