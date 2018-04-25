using System;
using System.Collections.Generic;
using System.Text;

namespace War
{
    class Deck
    {
        public List<Card> theCards;
        

        //creates a deck of 52 cards
        public Deck()
        {
            theCards = new List<Card>();
            for (int count = 0; count <= 4; count++)
            {
                for (int count2 = 0; count2 <= 13; count2++)
                {
                    Card card = new Card(count2, count);
                    theCards.Add(card);
                }

            }

        }

        //shuffles the deck randomly
        public void Shuffle()
        {
            for (int n = 0; n < theCards.Count; n++)
            {
                Random random = new Random();
                int randomPosition = random.Next(theCards.Count - 1);
                Card tempCard = theCards[n];
                theCards[n] = theCards[randomPosition];
                theCards[randomPosition] = tempCard;
            }
        }

        //Draws a card and reduces the size of the deck
        public Card Draw()
        {
            Card card = theCards[theCards.Count - 1];
            theCards.RemoveAt(theCards.Count - 1);
            return card;
        }
    }

}
