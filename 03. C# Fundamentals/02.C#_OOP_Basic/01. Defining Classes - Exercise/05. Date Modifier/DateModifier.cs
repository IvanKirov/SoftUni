using System;

namespace DefiningClasses
{
    public class DateModifier
    {
        private string firstDate;
        private string secondDate;

        public DateModifier()
        {            
        }

        public int Difference (string firstDate, string secondDate)
        {
            var first = DateTime.ParseExact(firstDate, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);
            var second = DateTime.ParseExact(secondDate, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);
            return Math.Abs((first-second).Days); 
        }

        public string FirstDate { get; set; }
        public string SecondDate { get; set; }
    }
}
