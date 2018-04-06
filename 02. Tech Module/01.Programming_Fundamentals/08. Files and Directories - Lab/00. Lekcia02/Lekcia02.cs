using System;
using System.IO;

namespace _00.Lekcia02
{
    public class Lekcia02
    {
        public static void Main()
        {
            var file = "myfile.txt";

            File.WriteAllText(file, "Tekst input");
            File.AppendAllText(file, "Nov text");

            var text = File.ReadAllText("myfile.txt");

            Console.WriteLine(text);
        }
    }
}
