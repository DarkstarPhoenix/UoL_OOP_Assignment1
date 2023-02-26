using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Pack
    {
        private static List<Card> packList = new List<Card>();
        private static List<Card> dealtCards = new List<Card>();
        private static Card dealtCard;
        

        public Pack()
        {
            //Initialise the card pack here
            for (int s = 1; s < 5; s++)
            {
                for (int v = 1; v < 14; v++)
                {
                    Card newCard = new Card(s, v);
                    packList.Add(newCard);
                    
                }
            }
                 
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            bool FisherYates()
            {
                Random random = new Random();
                
                for (int end = 51; end >= 0; end--)
                {                    
                    int randNum = random.Next(end);
                    packList.Add(packList[randNum]);
                    Console.WriteLine(packList[randNum]);

                    packList.Remove(packList[randNum]);
                    
                    Console.WriteLine(packList[packList.Count - 1]);
                }
                return true;
            }

            bool Riffle()
            {

            }

            if (typeOfShuffle == 1)
            {
                FisherYates();
            }

            return true;
        }
        public static Card dealCard()
        {
            //Deals the top card of the pack
            if (packList.Count != 0)
            {
                dealtCard = packList[0];
                packList.RemoveAt(0);
                Console.WriteLine(dealtCard);
                return dealtCard;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("Range Error - Not enough cards left to deal!");
            }

            


        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the top amount of cards according to method(argument)
            if (packList.Count >= amount)
            {
                for (int i = 0; i <= amount -1; i++)
                {
                    dealtCards.Add(packList[0]);
                    Console.WriteLine(packList[0]);
                    packList.RemoveAt(0);
                }
                return dealtCards;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("Range Error - Not enough cards to deal " + amount + " cards!\n " +
                    "Cards remaining: "+ packList.Count());
            }         


            
           
        }  
    }
}
