using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Lekcia_01
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var result = new StringBuilder(4 * n);

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    result.AppendLine(i.ToString());
                }
            }

            var resultAsString = result.ToString();

            File.WriteAllText("../../result.txt", resultAsString);
        }
    }
}
