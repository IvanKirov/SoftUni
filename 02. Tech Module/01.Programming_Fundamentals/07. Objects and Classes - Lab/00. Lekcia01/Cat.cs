
namespace _00.Lekcia01
{
    class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Color { get; set; }

        public bool IsAsleep { get; set; }

        public string SayHello()
        {
            return $"Hi, I am {Name}! I am {Age} years old.";
        }
    }
}

