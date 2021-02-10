using System;
using System.Collections.Generic;

namespace DeckOfCards.Models
{
    public class Player
    {
        private string name;
        public string Name {
            get {
                return name;
            }
        }

        private List<Card> hand;
        public List<Card> Hand {
            get {
                return hand;
            }
        }

        public Player(string player) {
            name = player;
            hand = new List<Card>();
        }

        public Card draw(Deck deck) {
            Card card = deck.deal();
            hand.Add(card);
            Console.WriteLine("Hand Count: " + hand.Count);
            return card;
        }

        public Card discard(int index) {
            if (index > hand.Count - 1) {
                Console.WriteLine("Count after Discard: Null");
                return null;
            }
            else {
                Card result = hand[index];
                hand.RemoveAt(index);
                Console.WriteLine("Count after Discard: " + hand.Count);
                return result;
            }
        }
    }
}