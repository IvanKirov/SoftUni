using System;

namespace Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
                       
            for (var numberOne = 1; numberOne <= n; numberOne++)
            {
                for (var numberTwo = 1; numberTwo <= n; numberTwo++)
                {
                    for (var numberTri = 'a'; numberTri < 'a' + l; numberTri++)
                    {
                        for (var numberChetri = 'a'; numberChetri < 'a' + l; numberChetri++)
                        {                            
                            for (var numberFive = Math.Max(numberOne, numberTwo)+1; numberFive <= n; numberFive++)
                            {                                
                                    Console.Write("{0}{1}{2}{3}{4} ", numberOne, numberTwo, numberTri, numberChetri, numberFive);
                              
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
