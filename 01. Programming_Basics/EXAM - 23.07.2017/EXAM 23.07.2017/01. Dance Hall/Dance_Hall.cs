using System;

namespace _01.Dance_Hall
{
    public class Dance_Hall
    {
        public static void Main()
        {
            var hallLength = double.Parse(Console.ReadLine()) * 100;
            var hallWidth = double.Parse(Console.ReadLine()) * 100;
            var wardrobeSide = double.Parse(Console.ReadLine()) * 100;

            var benchSize = hallLength * hallWidth / 10;
            var freeHallSpace = hallLength * hallWidth - (wardrobeSide * wardrobeSide + benchSize);

            var dancerSpace = 40.00 + 7000;
            Console.WriteLine(Math.Floor(freeHallSpace / dancerSpace));
            // Console.WriteLine(Math.Floor((hallLength * hallWidth - (wardrobeSide * wardrobeSide + (hallLength * hallWidth / 10))) / (40.00 + 7000)));
        }
    }
}
