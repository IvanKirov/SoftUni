using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Hands_of_Cards
{
    public class HandsOfCards
    {
        public static void Main()
        {
            var playersCards = new Dictionary<string, List<string>>();
            string input = "";

            while ((input = Console.ReadLine()) != "JOKER")
            {
                string[] cards = input
                    .Split(':')
                    .ToArray();

                if (!playersCards.ContainsKey(cards[0]))
                {
                    List<string> cardsList = cards[1]
                        .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    playersCards.Add(cards[0], cardsList);
                }
                else
                {
                    List<string> cardsList = cards[1]
                        .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    var allCardsList = playersCards[cards[0]]
                        .Concat(cardsList)
                        .Distinct()
                        .ToList();
                    playersCards[cards[0]] = allCardsList;
                }
            }

            foreach (var item in playersCards)
            {
                int sum = 0;
                foreach (var card in item.Value.Distinct())
                {
                    int result = 0;
                    switch (card.Substring(0, card.Length - 1))
                    {
                        case "2":
                            result = 2;
                            break;
                        case "3":
                            result = 3;
                            break;
                        case "4":
                            result = 4;
                            break;
                        case "5":
                            result = 5;
                            break;
                        case "6":
                            result = 6;
                            break;
                        case "7":
                            result = 7;
                            break;
                        case "8":
                            result = 8;
                            break;
                        case "9":
                            result = 9;
                            break;
                        case "10":
                            result = 10;
                            break;
                        case "J":
                            result = 11;
                            break;
                        case "Q":
                            result = 12;
                            break;
                        case "K":
                            result = 13;
                            break;
                        case "A":
                            result = 14;
                            break;
                    }

                    switch (card.Substring(card.Length - 1))
                    {
                        case "S":
                            result = result * 4;
                            break;
                        case "H":
                            result = result * 3;
                            break;
                        case "D":
                            result = result * 2;
                            break;
                        case "C":
                            result = result * 1;
                            break;
                    }
                    sum += result;
                }

                Console.WriteLine($"{item.Key}: {sum}");
            }
        }
    }
}

