using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public enum CardSuit
    {
        Clubs,
        Hearts,
        Spades,
        Diamonds
    }

    public enum CardValue
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
    public class Card
    {
        public CardValue value;
        public CardSuit suit;

        public Card(CardSuit newSuit, CardValue newValue)
        {
            suit = newSuit;
            value = newValue;
        }

        public override string ToString()
        {
            return "The " + value + " of " + suit;
        }
        
    }
}
