using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Knight_Game
{
    public class KnightGame
    {

        public static void Main()
        {
            var sizeBoard = int.Parse(Console.ReadLine());
            var knights = new List<Knight>();

            for (int row = 0; row < sizeBoard; row++)
            {
                var curretRow = Console.ReadLine();
                for (int col = 0; col < sizeBoard; col++)
                {
                    if (curretRow[col] == 'K')
                    {
                        knights.Add(new Knight {Col = col, Row = row });
                    }
                }
            }

            if (sizeBoard < 3)
            {
                Console.WriteLine(0);
            }
            else
            {
                var answer = CheckKnights(knights, sizeBoard);
                Console.WriteLine(answer);
            }
        }

        private static object CheckKnights(List<Knight> knights, int sizeBoard)
        {
            var answer = 0;
            var knightsHits = new Dictionary<Knight, int>();

            for (int i = 0; i < knights.Count; i++)
            {
                var hits = hitsOfKnight(knights[i].Col, knights[i].Row, knights);
                knightsHits.Add(knights[i], hits);
            }

            return answer;
        }

        private static int hitsOfKnight(int col, int row, List<Knight> knights)
        {
            var answer = 0;
            //col - 2, row +1            
            if (knights.Any(k => k.Col == col - 2 && k.Row == row + 1))
            {
                answer++;
            }
            //col - 2, row -1
            if (knights.Any(k => k.Col == col - 2 && k.Row == row + 1))
            {
                answer++;
            }
            //col + 2, row +1
            if (knights.Any(k => k.Col == col - 2 && k.Row == row + 1))
            {
                answer++;
            }
            //col + 2, row -1
            if (knights.Any(k => k.Col == col - 2 && k.Row == row + 1))
            {
                answer++;
            }
            //col + 1, row + 2
            if (knights.Any(k => k.Col == col - 2 && k.Row == row + 1))
            {
                answer++;
            }
            //col - 1, row + 2
            if (knights.Any(k => k.Col == col - 2 && k.Row == row + 1))
            {
                answer++;
            }
            //col - 1, row + 2
            if (knights.Any(k => k.Col == col - 2 && k.Row == row + 1))
            {
                answer++;
            }
            //col + 1, row - 2
            if (knights.Any(k => k.Col == col - 2 && k.Row == row + 1))
            {
                answer++;
            }            
            //col - 1, row - 2
            if (knights.Any(k => k.Col == col - 2 && k.Row == row + 1))
            {
                answer++;
            }
            return answer;
        }
    }

    public class Knight
    {
        public int Col { get; set; }
        public int Row { get; set; }
    }
}
