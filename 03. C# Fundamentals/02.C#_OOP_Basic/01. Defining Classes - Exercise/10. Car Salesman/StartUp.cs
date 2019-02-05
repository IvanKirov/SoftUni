using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Car_Salesman
{
    public class StartUp
    {
        public static void Main()
        {            
            var engines = new Dictionary<string, Engine>();
            InputEngines(engines); 
            
            var cars = new List<Car>();
            InputCars(cars, engines);

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }

        private static void InputCars(List<Car> cars, Dictionary<string, Engine> engines)
        {
            var numberCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberCars; i++)
            {
                var inputNewCar = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var carModel = inputNewCar[0];
                var carEngine = inputNewCar[1];

                var currentCar = new Car(carModel, engines[carEngine]);

                if (inputNewCar.Length > 2)
                {
                    if (inputNewCar.Length == 3)
                    {
                        int result;
                        var weightOrColor = int.TryParse(inputNewCar[2], out result);

                        if (weightOrColor)
                        {
                            currentCar.Weight = result;
                        }
                        else
                        {
                            currentCar.Color = inputNewCar[2];
                        }
                    }

                    if (inputNewCar.Length == 4)
                    {
                        currentCar.Weight = int.Parse(inputNewCar[2]);
                        currentCar.Color = inputNewCar[3];
                    }
                }

                cars.Add(currentCar);
            }
        }

        private static void InputEngines(Dictionary<string, Engine> engines)
        {
            var numberEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberEngines; i++)
            {
                var inputNewEngine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var engineModel = inputNewEngine[0];
                var enginePower = int.Parse(inputNewEngine[1]);
                var currentEngine = new Engine(engineModel, enginePower);

                if (inputNewEngine.Length > 2)
                {
                    if (inputNewEngine.Length == 3)
                    {
                        int result;
                        var displacementOrEfficiency = int.TryParse(inputNewEngine[2], out result);
                        if (displacementOrEfficiency)
                        {
                            currentEngine.Displacement = result;
                        }
                        else
                        {
                            currentEngine.Efficiency = inputNewEngine[2];
                        }
                    }

                    if (inputNewEngine.Length == 4)
                    {
                        currentEngine.Displacement = int.Parse(inputNewEngine[2]);
                        currentEngine.Efficiency = inputNewEngine[3];
                    }
                }

                engines[engineModel] = currentEngine;
            };
        }
    }
}
