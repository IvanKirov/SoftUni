using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var broi = int.Parse(Console.ReadLine());
            var maxNumber = int.MinValue; //най-малката възможна стойност за int
            // var maxNumber = int.Parse(Console.ReadLine()); въвежда се първото число и то се приема за най-малко
            for (int i = 1; i <= broi; i++) //внимавай с броя повторения, ако почнеш с 0 трябва да е само <
            // for (int i = 1; i <= broi - 1; i++) намаляваш броката с 1 заради първото въведено число!
            {
                var number = int.Parse(Console.ReadLine());
                if (maxNumber < number)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
