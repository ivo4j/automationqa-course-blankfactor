using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3.Collections
{
    internal class CardsGame
    {
        public void FindTheWinner()
        {
            // Input: Two hands of cards
            Console.WriteLine("Enter the first player's cards (space-separated integers):");
            List<int> firstPlayerDeck = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine("Enter the second player's cards (space-separated integers):");
            List<int> secondPlayerDeck = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            // Game logic
            while (firstPlayerDeck.Count > 0 && secondPlayerDeck.Count > 0)
            {
                int firstCard = firstPlayerDeck[0];
                int secondCard = secondPlayerDeck[0];

                // Remove the cards from the front of both decks
                firstPlayerDeck.RemoveAt(0);
                secondPlayerDeck.RemoveAt(0);

                if (firstCard > secondCard)
                {
                    // First player wins the round
                    firstPlayerDeck.Add(firstCard);
                    firstPlayerDeck.Add(secondCard);
                }
                else if (secondCard > firstCard)
                {
                    // Second player wins the round
                    secondPlayerDeck.Add(secondCard);
                    secondPlayerDeck.Add(firstCard);
                }
                // If the cards are equal, both are discarded, and no action is taken
            }

            // Determine the winner and calculate the sum
            if (firstPlayerDeck.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerDeck.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerDeck.Sum()}");
            }
        }
    }
}
