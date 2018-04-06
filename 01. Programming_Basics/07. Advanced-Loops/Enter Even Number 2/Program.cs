using System;

namespace Enter_Even_Number_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;

            while (true)
            {
                Console.Write("Enter an even number: ");
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)      // proverka dali e chetno
                    {
                        break;          // ako e chetno prekasva cikala
                    }
                    Console.WriteLine("The number is not even.");
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid number");
                }                
            }
            Console.WriteLine("The number is: " + n);
        }
    }
}
