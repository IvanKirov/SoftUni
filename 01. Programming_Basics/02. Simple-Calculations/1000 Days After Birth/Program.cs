using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            var RD = Console.ReadLine();
            DateTime ND = DateTime.ParseExact(RD, "dd-MM-yyyy", null);
            Console.WriteLine(ND.AddDays(999).ToString("dd-MM-yyyy"));                
        }
    }
}
