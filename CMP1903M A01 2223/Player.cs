using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    /// <summary>
    /// This is an additional class. This contains a constructor for a player, and will be assigned a name, and a hand of cards.
    /// </summary>
    public class Player
    {
        private static string _name;
        private static List<Card> _hand;

        /// <summary>
        /// Interface for Player name.
        /// </summary>
        public static String Name
        {
            get { return _name; }
        }

        /// <summary>
        /// Interface for Player Hand.
        /// </summary>
        public static List<Card> Hand
        {
            get { return _hand; }
        }

        /// <summary>
        /// Constructor for player.
        /// </summary>
        /// <param name="newName"></param>
        public Player (string newName)
        {
            _name = newName;
            _hand = new List<Card>();
        }

        /// <summary>
        /// Adds cards dealt to players hand.
        /// </summary>
        /// <param name="cards"></param>
        public static void PlayersHand(Card cards)
        {
            _hand.Add(cards);                      
        }

        /// <summary>
        /// Overide to convert print player's name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _name;
        }
    }
}
