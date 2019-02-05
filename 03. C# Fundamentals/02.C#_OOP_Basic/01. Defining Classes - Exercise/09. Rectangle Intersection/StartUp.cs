using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class RectangleIntersection
    {
        public static void Main()
        {
            int[] param = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            int recNum = param[0];
            int intersecCheck = param[1];

            Dictionary<string, Rectangle> rectangles = new Dictionary<string, Rectangle>();

            for (int i = 0; i < recNum; i++)
            {
                string[] dateStrings = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Rectangle rectangle = new Rectangle(dateStrings[0], double.Parse(dateStrings[1]), double.Parse(dateStrings[2]), new double[] { double.Parse(dateStrings[3]), double.Parse(dateStrings[4]) });

                rectangles[dateStrings[0]] = rectangle;
            }

            for (int i = 0; i < intersecCheck; i++)
            {
                string[] recIds = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (rectangles.ContainsKey(recIds[0]) && rectangles.ContainsKey(recIds[1]))
                {
                    Console.WriteLine(Rectangle.Intersect(rectangles[recIds[0]], rectangles[recIds[1]]).ToString().ToLower());
                }
            }
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace DefiningClasses
//{
//    public class StartUp
//    {
//        public static void Main()
//        {
//            var input = Console.ReadLine()
//                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
//                .Select(int.Parse)
//                .ToArray();

//            var numberRectangles = input[0];
//            var checksNumber = input[1];
//            var recktangles = new Dictionary<string, Rectangle>();

//            for (int i = 0; i < numberRectangles; i++)
//            {
//                var tokens = Console.ReadLine()
//                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
//                    .ToArray();

//                var newRectangle = new Rectangle();
//                newRectangle.Id = tokens[0];
//                newRectangle.Width = double.Parse(tokens[1]);
//                newRectangle.Height = double.Parse(tokens[2]);
//                newRectangle.XCoordinate = double.Parse(tokens[3]);
//                newRectangle.YCoordinate = double.Parse(tokens[4]);

//                recktangles[newRectangle.Id] = newRectangle;
//            }

//            for (int i = 0; i < checksNumber; i++)
//            {
//                var checkIds = Console.ReadLine()
//                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
//                    .ToArray();

//                if (recktangles.ContainsKey(checkIds[i]) && recktangles.ContainsKey(checkIds[i++]))
//                {
//                    Console.WriteLine(Rectangle.Intersect(recktangles[checkIds[i]], recktangles[checkIds[i]]).ToString().ToLower());
//                }
//            }            
//        }
//    }
//}
