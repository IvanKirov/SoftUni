using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child :Person
    {
        private int age;

        public Child(string name, int age) : base(name, age)
        {
        }

        public override int Age
        {
            get => age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                else if (value > 15)
                {
                    throw new ArgumentException("Child's age must be less than 15!");
                }
                age = value;
            }
        }
    }
}
