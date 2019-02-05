using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12._Google
{
    public class Person
    {
        private string name;
        private Company company;
        private Queue<Pokemon> pokemons;
        private Queue<Parent> parents;
        private Queue<Child> children;
        private Car car;

        public Person(string name)
        {
            this.Name = name;
            this.pokemons = new Queue<Pokemon>();
            this.parents = new Queue<Parent>();
            this.children = new Queue<Child>();
        }

        public string Name { get => this.name; set => this.name = value; }
        public Company Company { get => this.company; set => this.company = value; }
        public Car Car { get => this.car; set => this.car = value; }

        public void AddPokemon (Pokemon pokemon)
        {
            this.pokemons.Enqueue(pokemon);
        }

        public void AddParent(Parent parent)
        {
            this.parents.Enqueue(parent);
        }

        public void AddChild (Child child)
        {
            this.children.Enqueue(child);
        }

        public override string ToString()
        {
            var answer = new StringBuilder();
            answer.AppendLine(this.name);

            answer.AppendLine("Company:");
            if (this.company != null)
            {
                answer.AppendLine(this.company.ToString());
            }

            answer.AppendLine("Car:");
            if (this.car != null)
            {
                answer.AppendLine(this.car.ToString());
            }

            answer.AppendLine("Pokemon:");
            if (this.pokemons.Count > 0)
            {
                answer.AppendLine(string.Join(Environment.NewLine, this.pokemons.Select(p => p.ToString())));
            }

            answer.AppendLine("Parents:");
            if (this.parents.Count > 0)
            {
                answer.AppendLine(string.Join(Environment.NewLine, this.parents.Select(p => p.ToString())));
            }

            answer.AppendLine("Children:");
            if (this.children.Count > 0)
            {
                answer.AppendLine(string.Join(Environment.NewLine, this.children.Select(c => c.ToString())));
            }

            return answer.ToString();
        }
    }
}
