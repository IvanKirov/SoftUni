using System;
using System.IO;

namespace _00.Lekcia_01
{
    public class Lekcia01
    {
        public static void Main()
        {
            if(!File.Exists("myText.txt"))
            {
                File.Create("myText.txt");
            }

            var text = File.ReadAllText("../../myfile.txt");

            text = File.ReadAllText("myText.txt");

            Console.WriteLine(text);
        }
    }
}
