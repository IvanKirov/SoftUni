using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int one = 1; one < 10; one++)
            {
                for (int two = 1; two < 10; two++)
                {
                    for (int tri = 1; tri < 10; tri++)
                    {
                        for (int four = 1; four < 10; four++)
                        {
                            if (n % one == 0 && n%two==0 && n%tri==0 && n%four==0)
                            {
                                Console.Write("{0}{1}{2}{3} ", one, two, tri, four);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
