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
        private static int shuffleCounter = 0;

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
            
            bool FisherYates(int numOfShuffles=1)
            {
                Random random = new Random();
                
                for (int counter = numOfShuffles; counter > 0; counter--)
                {
                    for (int end = 51; end >= 0; end--)
                    {
                        int randNum = random.Next(end);
                        packList.Add(packList[randNum]);
                        packList.Remove(packList[randNum]);


                    }
                    shuffleCounter++;
                }
                
                foreach (Card card in packList)
                {
                    Console.WriteLine(card);
                }
                
                return true;

            }

            bool Riffle(int numOfShuffles=1)
            {
                
                //List<Card> rifflePack = new List<Card>();

                //Required to ensure packList and rifflePack cards alternate.
                

                for (int counter = numOfShuffles; counter > 0; counter--)
                {
                    List<Card> rifflePack = new List<Card>();
                    int additionCounter = 1;

                    for (int num = 26; num <= packList.Count() - 1; num++)
                    {
                        rifflePack.Add(packList[num]);
                    }

                    packList.RemoveRange(26, 26);
                    

                    //Loop to cycle through packList and riffleList and insert 
                    //rifflePack cards between packList cards.
                    for (int riffleIndex = 0; riffleIndex < rifflePack.Count(); riffleIndex++)
                    {
                        int packListIndex = riffleIndex + additionCounter;

                        packList.Insert(packListIndex, rifflePack[riffleIndex]);
                        additionCounter++;
                    }
                    shuffleCounter++;
                    
                    
                }

                
                foreach (Card card in packList)
                {
                    Console.WriteLine(card);
                }
                Console.WriteLine(packList.Count);
                return true;
            }

            if (typeOfShuffle == 1)
            {
                FisherYates(3);
                Console.WriteLine("Deck Shuffled: " + shuffleCounter + " times.");
            }
            else if( typeOfShuffle == 2)
            {
                Riffle();
            }
            else if( typeOfShuffle == 3)
            {
                return true;
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
