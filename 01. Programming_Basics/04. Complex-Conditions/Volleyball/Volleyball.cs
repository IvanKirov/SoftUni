using System;

namespace Volleyball
{
    public class Volleyball
    {
        public static void Main()
        {
            string Year = Console.ReadLine();
            var BrPraznici = int.Parse(Console.ReadLine());
            var BrWeekendi = int.Parse(Console.ReadLine());

            double resultat = (48 - BrWeekendi) * 3.0 / 4 + BrWeekendi + BrPraznici * 2.0 /3;

            if ( Year == "leap")
            {
                resultat = resultat * 1.15;            
            }
            Console.WriteLine(Math.Truncate(resultat));
        }
    }
}
