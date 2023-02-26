using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Card
    {
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
            return "The " + value + " of " + suit;
        }

    }
}
