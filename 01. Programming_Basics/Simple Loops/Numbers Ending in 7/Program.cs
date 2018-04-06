using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_Ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<=1000; i++)
            {
                if (i % 10 == 7)    //проверявам дали отатъка при деление с 10 е равен на 7
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
