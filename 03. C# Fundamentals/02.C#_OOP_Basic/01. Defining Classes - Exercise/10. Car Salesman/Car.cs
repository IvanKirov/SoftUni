using System;
using System.Collections.Generic;

namespace _10._Car_Salesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = 0;
            this.Color = "n/a";
        }

        //public string Model { get; set; }
        public string Model { get => model; set => this.model = value;}
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            var nl = Environment.NewLine;
            return $"{this.model}:" + nl +
                   $"  {this.Engine.Model}:" + nl +
                   $"    Power: {this.Engine.Power}" + nl +
                    "    Displacement: " + (this.Engine.Displacement == 0 ? "n/a" : $"{ this.Engine.Displacement}") + nl +
                   $"    Efficiency: {this.Engine.Efficiency}" + nl +
                    "  Weight: " + (this.Weight == 0 ? "n/a" : $"{this.Weight}") + nl +
                   $"  Color: {this.Color}";
        }
    }
}
