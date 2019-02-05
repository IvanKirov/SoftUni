using Online_Radio_Database.ExceptionClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Online_Radio_Database
{
    public class StartUp
    {
        public static void Main()
        {
            var numberOfSongs = int.Parse(Console.ReadLine());
            var songs = new List<Song>();
            var totalSongsLenght = new TimeSpan(0, 0, 0);

            for (int i = 0; i < numberOfSongs; i++)
            {
                var input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    var artistName = input[0];
                    var songName = input[1];
                    var time = input[2].Split(':').ToArray();
                    int minutes;
                    int seconds;
                    if (int.TryParse(time[0], out minutes) && int.TryParse(time[1], out seconds))
                    {
                        songs.Add(new Song(artistName, songName, minutes, seconds));
                        Console.WriteLine("Song added.");                        
                        totalSongsLenght += songs.Last().Length;
                    }
                    else
                    {
                        throw new InvalidSongLengthException();
                    }                    
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

            Console.WriteLine($"Songs added: {songs.Count}");            
            Console.WriteLine($"Playlist length: {totalSongsLenght.Hours}h {totalSongsLenght.Minutes}m {totalSongsLenght.Seconds}s");
        }
    }
}
