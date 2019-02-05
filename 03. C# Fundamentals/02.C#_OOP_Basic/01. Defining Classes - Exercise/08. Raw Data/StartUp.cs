using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            var numberCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < numberCars; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();

                var model = input[0];
                var engine = new Engine
                {
                    Speed = int.Parse(input[1]),
                    Power = int.Parse(input[2])
                };

                var cargo = new Cargo
                {
                    Weight = int.Parse(input[3]),
                    Type = input[4]
                };

                var tires = new List<Tire>();

                var tire1 = new Tire
                {
                    Pressure = double.Parse(input[5]),
                    Age = int.Parse(input[6])
                };
                tires.Add(tire1);

                var tire2 = new Tire
                {
                    Pressure = double.Parse(input[7]),
                    Age = int.Parse(input[8])
                };
                tires.Add(tire2);

                var tire3 = new Tire
                {
                    Pressure = double.Parse(input[9]),
                    Age = int.Parse(input[10])
                };
                tires.Add(tire3);

                var tire4 = new Tire
                {
                    Pressure = double.Parse(input[11]),
                    Age = int.Parse(input[12])
                };
                tires.Add(tire4);

                var newCar = new Car(model, engine, cargo, tires);
                cars.Add(newCar);
            }

            var command = Console.ReadLine();
            var answer = new StringBuilder();

            if (command == "fragile")
            {
                //var searchedCars = cars.Where(c => c.Cargo.Type == command && c.Tires.Where(p => p.Pressure < 1).FirstOrDefault() != null).ToList();
                var searchedCars = cars.Where(c => c.Cargo.Type == command)
                    .Where(c => c.Tires.Where(p => p.Pressure < 1).FirstOrDefault() != null)
                    .ToList();
                
                foreach (var car in searchedCars)
                {
                    answer.Append(car.Model).Append('\n');
                }
            }
            else
            {
                var searchedCars = cars.Where(c => c.Cargo.Type == command).Where(c => c.Engine.Power > 250).ToList();
                foreach (var car in searchedCars)
                {
                    answer.Append(car.Model).Append('\n');
                }
            }

            Console.WriteLine(answer);
        }
    }
}

