using System;
using System.Linq;

namespace _06.Rectangle_Position
{
    public class RectanglePosition
    {
        public static bool FirstIsInsideSecond(Rectangle first, Rectangle second)
        {
            var leftIsCorrect = first.Left >= second.Left;
            var rightIsCorrect = first.Right <= second.Right;
            var bottomIsCorrect = first.Bottom >= second.Bottom;
            var topIsCorrect = first.Top <= second.Top;

            return leftIsCorrect
                && rightIsCorrect
                && bottomIsCorrect
                && topIsCorrect;
        }

        public static void Main()
        {
            var firstRectangleDetails = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var firstRectangle = new Rectangle
            {
                Left = firstRectangleDetails[0],
                Top = firstRectangleDetails[1],
                Width = firstRectangleDetails[2],
                Height = firstRectangleDetails[3]
            };

            var secondRectangleDetails = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var secondRectangle = new Rectangle
            {
                Left = secondRectangleDetails[0],
                Top = secondRectangleDetails[1],
                Width = secondRectangleDetails[2],
                Height = secondRectangleDetails[3]
            };

            bool answer = FirstIsInsideSecond(firstRectangle, secondRectangle);
            Console.WriteLine(answer ? "Inside" : "Not inside");
        }
    }
}
