using System;
using System.Collections.Generic;
using DeckOfCards.Models;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a players list and a new deck, then shuffle the deck.
            List<Player> players = new List<Player>();
            Deck deck = new Deck();
            deck.shuffle();


            // Create new players and add them to the player list.
            Player Michael = new Player("Michael");
            players.Add(Michael);
            Player John = new Player("John");
            players.Add(John);


            // Each player draws 5 cards.
            for (int i = 1; i <= 5; i++) {
                Console.WriteLine("Michael Drawing...");
                Michael.draw(deck);

                Console.WriteLine("John Drawing...");
                John.draw(deck);
            }


            // List out each player's hand.
            Console.WriteLine("PLAYERS HANDS");
            List<Card> michaelHand = Michael.Hand;
            for (int i = 0; i < michaelHand.Count; i++) {
                Console.WriteLine("Player : " + Michael.Name + "--- Count: " + (i + 1));
                michaelHand[i].GetInfo();
            }
            List<Card> JohnHand = John.Hand;
            for (int i = 0; i < JohnHand.Count; i++) {
                Console.WriteLine("Player : " + John.Name + "--- Count: " + (i + 1));
                JohnHand[i].GetInfo();
            }


            // Reset the deck and player hands.
            for (int i = 0; i < players.Count; i++) {
                Player player = players[i];
                for (int j = player.Hand.Count - 1; j >= 0; j--) {
                    player.discard(j);
                }
            }
            deck.reset();
        }
    }
}
