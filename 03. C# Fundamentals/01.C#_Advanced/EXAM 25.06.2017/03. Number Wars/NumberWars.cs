using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Number_Wars
{
    public class NumberWars
    {
        public static void Main()
        {
            var cardsFirstPlayer = new Queue<string>(Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries));
            var cardsSecondPlayer = new Queue<string>(Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries));

            var turnsCount = 0;
            var winner = "first";

            while (turnsCount < 1000000 && cardsFirstPlayer.Count > 0 && cardsSecondPlayer.Count > 0)
            {
                var firstPlayerCard = cardsFirstPlayer.Dequeue();
                var cardNumberFirstPlayerCard = int.Parse(firstPlayerCard.Substring(0, firstPlayerCard.Length - 1));
                var cardLetterFirstPlayerCard = firstPlayerCard.Last();

                var secondPlayerCard = cardsSecondPlayer.Dequeue();
                var cardNumberSecondPlayercard = int.Parse(secondPlayerCard.Substring(0, secondPlayerCard.Length - 1));
                var cardLetterSecondPlayercard = secondPlayerCard.Last();

                if (cardNumberFirstPlayerCard > cardNumberSecondPlayercard)
                {
                    cardsFirstPlayer.Enqueue(firstPlayerCard);
                    cardsFirstPlayer.Enqueue(secondPlayerCard);
                }
                else if (cardNumberSecondPlayercard > cardNumberFirstPlayerCard)
                {
                    cardsSecondPlayer.Enqueue(secondPlayerCard);
                    cardsSecondPlayer.Enqueue(firstPlayerCard);
                }
                else
                {
                    var drawnCards = new List<string>();
                    drawnCards.Add(firstPlayerCard);
                    drawnCards.Add(secondPlayerCard);

                    winner = DrawCardsInWar(cardsFirstPlayer, cardsSecondPlayer, firstPlayerCard, secondPlayerCard, drawnCards);

                    if (winner == "first")
                    {
                        if (cardsSecondPlayer.Count == 0)
                        {
                            turnsCount++;
                            break;
                        }
                        AddCards(cardsFirstPlayer, drawnCards);
                    }
                    else if (winner == "second")
                    {
                        if (cardsFirstPlayer.Count == 0)
                        {
                            turnsCount++;
                            break;
                        }
                        AddCards(cardsSecondPlayer, drawnCards);
                    }
                    else
                    {
                        turnsCount++;
                        break;
                    }
                }
                turnsCount++;
            }

            if (winner == "draw")
            {
                Console.WriteLine($"Draw after {turnsCount} turns");
            }
            else if (cardsFirstPlayer.Count == 0)
            {
                Console.WriteLine($"Second player wins after {turnsCount} turns");
            }
            else //if(cardsSecondPlayer.Count == 0)
            {
                Console.WriteLine($"First player wins after {turnsCount} turns");
            }
            //else
            //{
            //    Console.WriteLine($"Draw after {turnsCount} turns");
            //}
        }

        private static void AddCards(Queue<string> cardsPlayer, List<string> drawnCards)
        {
            foreach (var card in drawnCards.OrderBy(c => c))
            {
                cardsPlayer.Enqueue(card);
            };
        }

        private static string DrawCardsInWar(Queue<string> cardsFirstPlayer,
            Queue<string> cardsSecondPlayer,
            string firstPlayerCard,
            string secondPlayerCard,
            List<string> drawnCards)
        {
            var strengthFrstPlayer = 0;
            var strengthSecondPlayer = 0;

            for (int i = 0; i < 3; i++)
            {
                firstPlayerCard = cardsFirstPlayer.Dequeue();
                var cardNumberFirstPlayerCard = int.Parse(firstPlayerCard.Substring(0, firstPlayerCard.Length - 1));
                var cardLetterFirstPlayerCard = firstPlayerCard.Last();
                strengthFrstPlayer += cardLetterFirstPlayerCard - 96;
                drawnCards.Add(firstPlayerCard);

                secondPlayerCard = cardsSecondPlayer.Dequeue();
                var cardNumberSecondPlayercard = int.Parse(secondPlayerCard.Substring(0, secondPlayerCard.Length - 1));
                var cardLetterSecondPlayercard = secondPlayerCard.Last();
                strengthSecondPlayer += cardLetterSecondPlayercard - 96;
                drawnCards.Add(secondPlayerCard);
            }

            if (strengthFrstPlayer > strengthSecondPlayer)
            {
                return "first";
            }
            else if (strengthSecondPlayer > strengthFrstPlayer)
            {
                return "second";
            }
            else
            {
                if (cardsFirstPlayer.Count + cardsSecondPlayer.Count == 0)
                {
                    return "draw";
                }
                else if (cardsSecondPlayer.Count <= 2)
                {
                    return "first";
                }
                else if (cardsFirstPlayer.Count <= 2)
                {
                    return "second";
                }
                else
                {
                    return DrawCardsInWar(cardsFirstPlayer, cardsSecondPlayer, firstPlayerCard, secondPlayerCard, drawnCards);
                }
            }
        }
    }
}
