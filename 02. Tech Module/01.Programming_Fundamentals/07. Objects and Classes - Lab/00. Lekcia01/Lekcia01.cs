using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Lekcia01
{
    public class Lekcia01
    {
        public static void Main()
        {
            var firstCat = new Cat()
            {
                Name = "Ivan",
                Age = 2,
                Color = "Blue",
                IsAsleep = true
            };

            var firstCatIntro = Cat.SayHello;
        }
    }
}
