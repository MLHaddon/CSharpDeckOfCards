using System;
using System.Collections.Generic;
using DeckOfCards.Models;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.shuffle();
            Player michael = new Player("Michael");
            michael.draw(deck);
            michael.draw(deck);
            michael.draw(deck);
            michael.discard(2);
            michael.discard(3);
            deck.reset();
        }
    }
}
