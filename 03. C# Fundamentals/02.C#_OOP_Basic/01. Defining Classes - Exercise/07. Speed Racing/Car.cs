using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class Car
    {
        //car’s model, fuel amount, fuel consumption for 1 kilometer and  traveled distance
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private int distance;

        public Car()
        {
            this.distance = 0;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public int Distance { get; set; }

        public bool MoveCar(string carModel, double fuelConsumtion, Dictionary<string, Car> cars)
        {
            if (cars[carModel].FuelAmount >= fuelConsumtion)
            {
                return true;
            }

            Console.WriteLine("Insufficient fuel for the drive");
            return false;
        }
    }
}
