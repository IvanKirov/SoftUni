using System;

namespace DefiningClasses
{
    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double[] topLeft;

        public Rectangle(string id, double width, double height, double[] topLeft)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.topLeft = new double[] { topLeft[0], topLeft[1] };
        }
        //private string id;
        //private double width;
        //private double height;
        //private double xCoordinate;
        //private double yCoordinate;

        //public Rectangle()
        //{
        //    //this.id = id;
        //    //this.width = width;
        //    //this.height = height;
        //    //this.xCoordinate = xCoordinate;
        //    //this.yCoordinate = yCoordinate;
        //}

        //public string Id
        //{
        //    get
        //    {
        //        return this.id;
        //    }
        //    set
        //    {
        //        this.id = value;
        //    }
        //}
        //public double Width
        //{
        //    get => width;
        //    set => width = value;
        //}
        //public double Height
        //{
        //    get => height;
        //    set => height = value;
        //}
        //public double XCoordinate
        //{
        //    get => xCoordinate;
        //    set => xCoordinate = value;
        //}
        //public double YCoordinate
        //{
        //    get => yCoordinate;
        //    set => yCoordinate = value;
        //}

        public static bool Intersect(Rectangle r1, Rectangle r2)
        {
            bool intersect = false;

            if (Math.Abs(r1.topLeft[0]) < Math.Abs(r2.topLeft[0] + r2.width))
            {
                if (Math.Abs(r1.topLeft[0] + r1.width) >= Math.Abs(r2.topLeft[0]))
                {
                    if (r1.topLeft[1] < Math.Abs((r2.topLeft[1] - r2.height)))
                    {
                        if (Math.Abs(r1.topLeft[1] + r1.height) >= Math.Abs(r2.topLeft[1]))
                        {
                            intersect = true;
                        }
                    }
                }
            }

            return intersect;
        }

        //public static bool Intersect(Rectangle rectangleOne, Rectangle rectangleTwo)
        //{
        //    if (Math.Abs(rectangleOne.XCoordinate) < Math.Abs(rectangleTwo.XCoordinate + rectangleTwo.width))
        //    {
        //        if (Math.Abs(rectangleOne.XCoordinate + rectangleOne.width) >= Math.Abs(rectangleTwo.XCoordinate))
        //        {
        //            if (rectangleOne.YCoordinate < Math.Abs((rectangleTwo.YCoordinate - rectangleTwo.height)))
        //            {
        //                if (Math.Abs(rectangleOne.YCoordinate + rectangleOne.height) >= Math.Abs(rectangleTwo.YCoordinate))
        //                {
        //                    return true;
        //                }
        //            }
        //        }
        //    }

        //    return false;
        //}

        //public static bool Intersect(Rectangle one, Rectangle two)
        //{
        //    double newX = two.XCoordinate;
        //    double newY = two.YCoordinate;
        //    if (CheckIfIsIn(one, newX, newY))
        //    {
        //        return true;
        //    }

        //    newX = two.XCoordinate + two.Width;
        //    if (CheckIfIsIn(one, newX, newY))
        //    {
        //        return true;
        //    }

        //    newY = two.YCoordinate + two.Height;
        //    if (CheckIfIsIn(one, newX, newY))
        //    {
        //        return true;
        //    }

        //    newX = two.XCoordinate;
        //    if (CheckIfIsIn(one, newX, newY))
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        //private static bool CheckIfIsIn(Rectangle one, double newX, double newY)
        //{
        //    var topLeftX = one.XCoordinate;
        //    var topLeftY = one.YCoordinate;
        //    var bottomRightX = topLeftX + one.Width;
        //    var bottomRightY = topLeftY + one.Height;

        //    bool isIn = topLeftX <= newX && newX <= bottomRightX &&
        //                topLeftY <= newY && newY <= bottomRightY;
        //    if (isIn)
        //    {
        //        return true;
        //    }

        //    return false;
        //}
    }
}
