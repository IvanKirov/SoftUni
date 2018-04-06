using System;

namespace _00.Lekcia
{
    public class Lekcia00
    {
        public static void Main()
        {
            var firstCat = new Cat();
            firstCat.Name = "Ivan";
            firstCat.Age = 3;
            firstCat.IsAsleep = true;

            var secondCat = new Cat();
            secondCat.Age = 5;
            secondCat.Name = "Gosho";

            var thirdCat = new Cat();
            thirdCat.Color = "Black";

            Console.WriteLine(firstCat.Name);
            Console.WriteLine(secondCat.Age);

            var cat = new Cat
            {
                Name = "Ivan",
                Age = 10,
                Color = "Yellow",
                IsAsleep = false
            };
        }
    }
}
