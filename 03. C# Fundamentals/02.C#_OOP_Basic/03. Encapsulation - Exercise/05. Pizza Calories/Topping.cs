using System;
using System.Linq;

namespace Pizza_Calories
{
    public class Topping
    {
        private string name;
        private int weight;
        private double calories;

        public Topping(string name, int weight)
        {
            Name = name;
            Weight = weight;
            Calories = calories;
        }

        private string Name
        {
            set
            {
                var toppings = new String[]{ "meat", "veggies", "cheese", "sauce" };
                if (!toppings.Contains(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                name = value;
            }
        }

        public double Calories
        {
            get => calories;
            set
            {
                double toppingMultiplier = 2;

                switch (name.ToLower())
                {
                    case "meat":
                        toppingMultiplier = 1.2;
                        break;
                    case "veggies":
                        toppingMultiplier = 0.8;
                        break;
                    case "cheese":
                        toppingMultiplier = 1.1;
                        break;
                    case "sauce":
                        toppingMultiplier = 0.9;
                        break;
                }

                calories = 2* this.weight * toppingMultiplier;
            }
        }

        private int Weight
        {
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.name} weight should be in the range [1..50].");
                }

                weight = value;
            }
        }

    }
}
