using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Pack
    {
        public Card[] cards;

        public Pack()
        {
            //Initialise the card pack here
            cards = new Card[52];
            for (int suitIndex = 0; suitIndex < 4; suitIndex++)
            {
                for (int valueIndex = 1; valueIndex < 14; valueIndex++)
                {
                    Card myCard = new Card((CardSuit)suitIndex, (CardValue)valueIndex);
                    cards[suitIndex * 13 + valueIndex - 1] = myCard;
                }
            }
            Console.WriteLine(cards);
        }

        /*public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle

        }
        public static Card deal()
        {
            //Deals one card

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }*/
    }
}
