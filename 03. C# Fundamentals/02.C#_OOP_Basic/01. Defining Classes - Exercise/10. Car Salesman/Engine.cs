namespace _10._Car_Salesman
{
    public class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = 0;
            this.Efficiency = "n/a";
        }

        public string Model
        {
            get => model;
            set => this.model = value;
        }

        public int Power
        {
            get => power;
            set => this.power = value;
        }

        public int Displacement
        {
            get => displacement;
            set => this.displacement = value;
        }

        public string Efficiency
        {
            get => efficiency;
            set => this.efficiency = value;
        }
    }
}
