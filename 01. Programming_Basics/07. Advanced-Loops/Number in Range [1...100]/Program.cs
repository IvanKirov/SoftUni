using System;

namespace Number_in_Range__1._._._100_
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;

            while (true)
            {
                Console.Write("Еnter a number in the range [1...100]: ");
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n >= 1 && n <= 100)      // proverka dali e mejdu 1 i 100
                    {
                        break;          // ako e vatre prekasva cikala
                    }
                    Console.WriteLine("Invalid number!");
                }
                catch 
                {

                    Console.WriteLine("Invalid number!"); ;
                }
            }
            Console.WriteLine("The number is: " + n);           
        }
    }
}
