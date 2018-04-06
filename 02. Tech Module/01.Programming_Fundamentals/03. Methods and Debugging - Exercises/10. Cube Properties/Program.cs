using System;

namespace _10.Cube_Properties
{
    public class CubeProperties
    {
        public static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            switch (parameter)
            {
                case "face":
                    var answer = Math.Round(Math.Sqrt(2) * side, 2);
                    Console.WriteLine("{0:F2}", answer);
                    break;
                case "space":
                    answer =  Math.Round(Math.Sqrt(3) * side, 2);
                    Console.WriteLine("{0:F2}", answer);
                    break;
                case "volume":
                    answer = Math.Round(Math.Pow(side, 3), 2);
                    Console.WriteLine("{0:F2}", answer);
                    break;
                case "area":
                    answer = Math.Round(Math.Pow(side, 2) * 6, 2);
                    Console.WriteLine("{0:F2}", answer);
                    break;
                default:
                    break;
            }
        }
    }
}
