using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Card
    {
        /// <summary>
        /// Enums will use index value to convert integer value to corresponding Card value & suit, i.e Ace of Spades.
        /// </summary>
        enum enumValue
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

        enum enumSuit
        {
            Clubs = 1,
            Hearts,
            Spades,
            Diamonds
        }


        /// <summary>
        /// Encapsulation for Card values & suits.
        /// </summary>
        private int _value;
        private int _suit;
        
        public int value
        {
            get => _value;
            
        }
        public int suit
        {
            get => _suit;
            
        }


        /// <summary>
        /// Card Constructor 
        /// </summary>
        /// <param name="newSuit">Integer values representing corresponding values in the cards 1-13 (Ace-King)</param>
        /// <param name="newValue">Intger values representing Card suit 1=Clubs, 2=Hearts, 3=Spades, 4=Diamonds</param>
        public Card(int newSuit, int newValue)
        {
            _suit = newSuit;
            _value = newValue;
           
        }

        /// <summary>
        /// Overide to convert integers to corresponding cards, i.e Ace of Spades.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (enumValue)value + " of " + (enumSuit)suit;
        }

    }
}
