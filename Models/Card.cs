using System;
using DeckOfCards.Models;

namespace DeckOfCards.Models
{
    public class Card
    {
        private string stringVal;
        public string StringVal {
            get {
                return stringVal;
            }
        }
        private string suit;
        public string Suit {
            get {
                return suit;
            }
        }
        private int val;
        public int Val {
            get {
                return val;
            }
        }
        public virtual void GetInfo() {
            Console.WriteLine($"Card: {StringVal}");
            Console.WriteLine($"Suit: {Suit}");
        }

        public Card(string stringValue, string cardSuit, int value) {
            stringVal = stringValue;
            suit = cardSuit;
            val = value;
        }
    }
}