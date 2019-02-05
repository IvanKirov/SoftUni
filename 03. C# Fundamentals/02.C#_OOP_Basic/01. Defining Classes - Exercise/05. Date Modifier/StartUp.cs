using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            var days = new DateModifier();
            int answer = days.Difference(firstDate, secondDate);
            
            Console.WriteLine(answer);
        }
    }
}
