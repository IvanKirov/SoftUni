using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_Spree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Bag = new List<Product>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }

        public decimal Money
        {
            get => money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                money = value;
            }
        }

        public List<Product> Bag { get; set; }

        public void Purchase(Product product)
        {
            if (this.Money < product.Price)
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} bought {product.Name}");
                Bag.Add(product);
                this.Money -= product.Price;
            }
        }
    }
}
