using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            var broiDni = int.Parse(Console.ReadLine());
            decimal playTime = ((365 - broiDni) * 63) + (broiDni * 127);
            var razlika = Math.Abs(30000 - playTime);
            var hours = Math.Truncate(razlika / 60);
            var minutes = razlika - (hours * 60);
            if (playTime > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
        }
    }
}
