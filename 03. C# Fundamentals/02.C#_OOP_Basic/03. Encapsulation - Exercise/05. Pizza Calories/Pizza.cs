using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories
{
    public class Pizza
    {
        private const int MaxToppingsCount = 10;

        private string name;
        private List<Topping> toppings;
        private Dough dough;
        private double calories;

        public Pizza(string name)
        {
            Name = name;            
            toppings = new List<Topping>();
            Calories = calories;
        }

        public Pizza(string name, Dough dough) :this(name)
        {
            Dough = dough;
        }

        public Dough Dough
        {
            set { this.dough = value; }
        }

        public double Calories { get; set; }
        //public List<Topping> Toppings { get; set; }        

        public string Name
        {
            get => name; 
            set
            {
                if (value.Length > 14 || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
            if (toppings.Count - 1 > MaxToppingsCount)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }
    }
}

