﻿namespace _12._Google
{
    public class Child
    {
        private string name;
        private string birthday;

        public Child(string name, string birthday)
        {
            this.Name = name;
            this.birthday = birthday;
        }

        public string Name { get => this.name; set => this.name = value; }

        public override string ToString()
        {
            return $"{this.name} {this.birthday}";
        }
    }
}
