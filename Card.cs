using System;

namespace Cards
{
    public class Card 
    {
        public string suit;
        public string value;

        // this is our constructor
        public Card(string suit, string value)
        {
            this.suit = suit;
            this.value = value;
        }

        public void Display()
        {
            Console.WriteLine($"the {value} of {suit}");
        }


    }
}

