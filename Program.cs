using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var suits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };
            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            var suitValues = suits.Count;
            var rankValues = ranks.Count;

            foreach (var chosenSuit in suits)
            {
                foreach (var chosenRank in ranks)
                {
                    var card = chosenSuit + chosenRank;
                    Console.WriteLine(card);
                }
            }
        }
    }
}
