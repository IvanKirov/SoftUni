using System;

namespace MagicCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int cifra1 = 1; cifra1 <= 9; cifra1++)
            {
                for (int cifra2 = 1; cifra2 <= 9; cifra2++)
                {
                    for (int cifra3 = 1; cifra3 <= 9; cifra3++)
                    {
                        for (int cifra4 = 1; cifra4 <= 9; cifra4++)
                        {
                            for (int cifra5 = 1; cifra5 <= 9; cifra5++)
                            {
                                for (int cifra6 = 1; cifra6 <= 9; cifra6++)
                                {
                                    if (cifra1*cifra2*cifra3*cifra4*cifra5*cifra6==n)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", cifra1, cifra2, cifra3, cifra4, cifra5, cifra6);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
;