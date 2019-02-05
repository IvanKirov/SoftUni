using System;

namespace Pizza_Calories
{
    public class StartUp
    {
        public static void Main()
        {
            string input;
            Pizza pizza = new Pizza("Default");

            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split();

                try
                {
                    if (tokens[0] == "Pizza")
                    {
                        var name = tokens[1];
                        pizza.Name = name;
                    }
                    else if (tokens[0] == "Dough")
                    {
                        var flour = tokens[1].ToLower();
                        var technique = tokens[2].ToLower();
                        var weight = int.Parse(tokens[3]);
                        var dough = new Dough(flour, technique, weight);
                        pizza.Calories += dough.Calories;
                    }
                    else
                    {
                        var name = tokens[1];
                        var weight = int.Parse(tokens[2]);
                        var topping = new Topping(name, weight);                        
                        pizza.AddTopping(topping);
                        pizza.Calories += topping.Calories;
                    }
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                    return;
                }
                
                
            }

            Console.WriteLine($"{pizza.Name} - {pizza.Calories:F2} Calories.");
        }
    }
}
