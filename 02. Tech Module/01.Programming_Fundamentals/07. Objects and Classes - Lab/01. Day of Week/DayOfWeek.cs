using System;
using System.Globalization;

namespace _01.Day_of_Week
{
    public class DayOfWeek
    {
        public static void Main()
        {
            string inputDate = Console.ReadLine();

            var date = DateTime.ParseExact(inputDate, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
