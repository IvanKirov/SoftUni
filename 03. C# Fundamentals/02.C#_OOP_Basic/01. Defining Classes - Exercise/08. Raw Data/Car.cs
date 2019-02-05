using System.Collections.Generic;

namespace DefiningClasses
{
    public class Car
    {        
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.tires = new List<Tire>(tires);
            this.Engine = engine;
            this.Cargo = cargo;
            this.Model = model;
        }

        public string Model { get; set; }
        public Engine Engine
        {
            get
            {
                return this.engine;
            }
            set
            {
                this.engine = new Engine
                {
                    Speed = value.Speed,
                    Power = value.Power
                };
            }
        }
        public Cargo Cargo
        {
            get
            {
                return this.cargo;
            }
            set
            {
                this.cargo = new Cargo
                {
                    Weight = value.Weight,
                    Type = value.Type
                };
            }
        }
        public List<Tire> Tires
        {
            get
            {
                return this.tires;
            }
        }
    }
}
