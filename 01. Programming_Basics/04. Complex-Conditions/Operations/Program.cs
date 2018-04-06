using System;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var chisloEdno = int.Parse(Console.ReadLine());
            var chisloDve = int.Parse(Console.ReadLine());
            string deistvie = Console.ReadLine();
            double rezultat = 0d;
            switch (deistvie)
            {
                case "*":
                    rezultat = chisloDve * chisloEdno;                    
                    break;
                case "+":
                    rezultat = chisloDve + chisloEdno;
                    break;
                case "-":
                    rezultat = chisloEdno - chisloDve;
                    break;
                case "/":
                    if (chisloDve != 0)
                    {
                        rezultat = (double)chisloEdno / chisloDve;
                        Console.Write("{0} {1} {2} = {3:f2}", chisloEdno, deistvie, chisloDve, rezultat);
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide {0} by zero", chisloEdno);
                        goto end;
                    }                    
                    break;
                case "%":
                    if (chisloDve != 0)
                    {
                        rezultat = chisloEdno % chisloDve;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide {0} by zero", chisloEdno);
                        goto end; 
                    }
                    break;
                default:
                    break;
            }
            Console.Write("{0} {1} {2} = {3:f2}", chisloEdno, deistvie, chisloDve, rezultat);
            if (deistvie == "*" || deistvie == "-" || deistvie == "+")
            {
                if (rezultat % 2 == 0)
                {
                    Console.WriteLine(" - even");
                }
                else
                {
                    Console.WriteLine(" - odd");
                }                
            }            
        end:;
        }
    }
}
