using System;

namespace _19.Thea_The_Photographer
{
    public class Program
    {
        public static void Main()
        {
            var numberPictures = int.Parse(Console.ReadLine());
            var filterTime = int.Parse(Console.ReadLine());
            var filterFactor = int.Parse(Console.ReadLine());
            var uploadTime = int.Parse(Console.ReadLine());

            long timeAllPictures = numberPictures * (long)filterTime;
            long filterPictures = (int)Math.Ceiling(numberPictures * ((double)filterFactor / 100));
            long totalTime = (filterPictures * uploadTime) + timeAllPictures;

            long days = totalTime / (3600 * 24);
            long hours = (totalTime / 3600) - (days * 24);
            long minutes = (totalTime / 60) - (((days * 24) + hours) * 60);
            long seconds = totalTime - (((((days * 24) + hours) * 60) + minutes) * 60);
            Console.WriteLine($"{days}:{hours:00}:{minutes:00}:{seconds:00}");

            // as above less code
            TimeSpan t = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine($"{t.Days}:{t.Hours:00}:{t.Minutes:00}:{t.Seconds:00}");

            var newTotalTime = new TimeSpan(0, 0, (int)totalTime);
            Console.WriteLine(newTotalTime.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
