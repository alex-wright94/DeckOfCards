using System;
using System.Collections.Generic;

namespace Cards
{
    public class Deck
    {
           public List<Card> cards = new List<Card>();

           // this is the constructor
           public Deck ()
           {
            this.Reset();
           }
        //shuffle method for deck
           public void Shuffle()
           {
               Random r = new Random();
               for(int i=0; i<cards.Count; i++)
               {
                   int randomIndex = r.Next(cards.Count);
                   Card temp = cards[i];
                   cards[i] = cards[randomIndex];
                   cards[randomIndex] = temp;
               }
           }
           //Deal a card method

           public Card Deal()
           {
               if(cards.Count == 0)
               {
                   throw new Exception("Deck is empty");
               }
               Card cardToReturn = cards[0];
               cards.RemoveAt(0);
               return cardToReturn;

           }
        //Reset the deck method


        public void Reset()
        {
              cards = new List<Card>();
               List<string> values = new List<string>()
               {
                   "Ace", "King", "Queen", "Jack", "10",  "9", "8", "7",  "6", "5", "4", "3", "2",

               };
                List<string> suits = new List<string>()
                {
                    "Spades", "Hearts", "Clubs", "Diamonds"
                };

                foreach(string value in values)
                {
                    foreach(string suit in suits)
                    {
                       cards.Add(
                           new Card(suit, value) );
                    }

                }
        }






    }


}