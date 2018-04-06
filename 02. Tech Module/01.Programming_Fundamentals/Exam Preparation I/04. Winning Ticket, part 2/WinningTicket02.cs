using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Winning_Ticket_part_2
{
    public class WinningTicket02
    {
        public static void FindReapitingSymbols(char[] symbols)
        {
            var prevSymbol = symbols.First();
            int count = 1;
            int maxCount = 0;
            var maxSymbol =

            for (int i = 0; i < symbols.Length; i++)
            {
                var currentSymbol = symbols[i];

                if (prevSymbol == currentSymbol)
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxSymbol = prevSymbol;
                    }

                    count = 1;
                }
            }
        }

        public static void Main()
        {
            var tickets = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim())
               .ToArray();

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var left = new string(ticket.Take(10).ToArray());
                var right = new string(ticket.Skip(10).ToArray());


            }

            if (!winningTicket)
            {
                Console.WriteLine($"ticket \"{ticket}\" - no match");
            }
        }
    }
}
}
