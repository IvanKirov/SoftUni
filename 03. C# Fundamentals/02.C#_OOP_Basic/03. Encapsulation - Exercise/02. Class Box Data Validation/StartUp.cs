using System;

namespace Class_Box_Data_Validation
{
    public class StartUp
    {
        public static void Main()
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            Box box = null;            

            try
            {
                box = new Box(length, width, height);
                Console.WriteLine(box);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                return;
            }
        }
    }
}
