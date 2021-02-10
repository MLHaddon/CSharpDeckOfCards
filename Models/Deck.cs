using System;
using System.Collections.Generic;
using DeckOfCards.Models;

namespace DeckOfCards.Models
{
    public class Deck
    {
        private List<object> Cards;

        public List<object> cards {
            get {
                return Cards;
            }
        }
        public Deck() {
            List<string> suits = new List<string>() {"Clubs", "Spades", "Hearts", "Diamonds"};
            List<string> stringVals = new List<string>() {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            Cards = new List<object>();
            for (int i = 0; i < suits.Count; i++) {
                for (int j = 0; j < stringVals.Count; j++) {
                    Card card = new Card(stringVals[j], suits[i], j + 1);
                    cards.Add(card);
                }
            }
        // When initializing the deck, make sure that it has a list of 52 unique cards as its "cards" property.
            Console.WriteLine("New Deck Count: " + Cards.Count);
        }
        // Give the Deck a deal method that selects the "top-most" card, removes it from the list of cards, and returns the Card.
        public Card deal() {
            Card result = (Card)Cards[Cards.Count - 1];
            Cards.RemoveAt(Cards.Count - 1);
            Console.WriteLine(result);
            return result;
        }
        
        public void shuffle() {
            for (int i = 0; i < cards.Count; i++) {
                Random rand = new Random();
                int num = rand.Next(0, cards.Count - 1);
                object temp = cards[i];
                cards[i] = cards[num];
                cards[num] = temp;
            }
        }
        public void reset() {
            Deck newDeck = new Deck();
            this.Cards = newDeck.Cards;
        }
    }
}