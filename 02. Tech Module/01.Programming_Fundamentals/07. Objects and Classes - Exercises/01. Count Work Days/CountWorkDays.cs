using System;
using System.Globalization;
using System.Linq;

namespace _01.Count_Work_Days
{
    public class CountWorkDays
    {
        public static void Main()
        {
            DateTime startDate = DateTime
                .ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime endDate = DateTime
                .ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var holidays = new DateTime[]
            {
                new DateTime( 16, 01, 01),
                new DateTime( 16, 03, 03),
                new DateTime( 16, 05, 01),
                new DateTime( 16, 05, 06),
                new DateTime( 16, 05, 24),
                new DateTime( 16, 09, 06),
                new DateTime( 16, 09, 22),
                new DateTime( 16, 11, 01),
                new DateTime( 16, 12, 24),
                new DateTime( 16, 12, 25),
                new DateTime( 16, 12, 26)
            };

            var workingDayCounter = 0;
       
            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1.0))
            {
                var currentDayOfWeek = currentDate.DayOfWeek;           // za da rabotyat tezi dolu dobavi .ToString();
                if (!holidays.Any(h => h.Day == currentDate.Day && h.Month == currentDate.Month)
                    && !currentDayOfWeek.Equals(DayOfWeek.Saturday)       //currentDayOfWeek != "Saturday"      
                    && !currentDayOfWeek.Equals(DayOfWeek.Sunday))        //currentDayOfWeek != "Sunday"
                {
                    workingDayCounter++;
                }
            }
           
            Console.WriteLine(workingDayCounter);
        }
    }
}
