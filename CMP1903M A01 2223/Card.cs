using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Card
    {
        //enums used in override ToString method to convert int values to string.
        enum _value
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

        enum _suit
        {
            Clubs = 1,
            Hearts,
            Spades,
            Diamonds
        }

        public int value;
        public int suit;

        public Card(int newSuit, int newValue)
        {
            suit = newSuit;
            value = newValue;
           
        }

        //An override of System.object's ToString() method
        //to provide a more readable string output of Card
        public override string ToString()
        {
            return "The " + (_value)value + " of " + (_suit)suit;
        }

    }
}
