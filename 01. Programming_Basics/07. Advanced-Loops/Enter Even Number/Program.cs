using System;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // NE RABOTI DAVA GRASHKA V JUDJE!
            var n = 0;

            try
            {           // zadavame saobshtenie za greshka
                while (true)
                {
                    Console.Write("Enter an even number: ");
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)      // proverka dali e chetno
                    {
                        break;          // ako e chetno prekasva cikala
                    }
                    Console.WriteLine("The number is not even.");
                }
                Console.WriteLine("The number is: " + n);
            }
            catch 
            {

                Console.WriteLine("Invalid number"); 
            }
            
        }
    }
}
