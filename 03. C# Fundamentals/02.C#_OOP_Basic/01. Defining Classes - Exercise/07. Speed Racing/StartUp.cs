using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            var numberCars = int.Parse(Console.ReadLine());
            var cars = new Dictionary<string, Car>();
            //var cars = new List<Car>();

            for (int i = 0; i < numberCars; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                var newCar = new Car();
                newCar.Model = input[0];
                newCar.FuelAmount = double.Parse(input[1]);
                newCar.FuelConsumption = double.Parse(input[2]);
                
                cars[newCar.Model] = newCar;
            }

            var commands = "";
            while ((commands = Console.ReadLine()) != "End")
            {
                var tokens = commands.Split(' ').ToArray();
                var carModel = tokens[1];
                var kmAmount = int.Parse(tokens[2]);

                var fuelConsumtion = kmAmount * cars[carModel].FuelConsumption;
                
                if (cars[carModel].MoveCar(carModel, fuelConsumtion, cars))
                {
                    cars[carModel].FuelAmount -= fuelConsumtion;
                    cars[carModel].Distance += kmAmount;
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} {car.Value.FuelAmount:F2} {car.Value.Distance}");
            }
        }
    }
}
