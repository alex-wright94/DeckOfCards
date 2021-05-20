using System;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            deck1.Shuffle();
            Card[] hand = new Card[5];
            for(int i=0; i<5; i++)
            {
                hand[i] = deck1.Deal();
            }
            foreach(Card card in hand)
            {
                card.Display();
            }
            deck1.Reset();
            deck1.cards[0].Display();

        }
    }
}
