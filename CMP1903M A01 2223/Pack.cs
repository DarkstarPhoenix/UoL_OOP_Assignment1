using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        /// <summary>
        /// Lists for current pack and dealt cards. Encapsulation
        /// </summary>
        private readonly static List<Card> _packList = new List<Card>();
        private readonly static List<Card> dealtCards = new List<Card>();
        
        /// <summary>
        /// Interface for packList.
        /// </summary>
        public static List<Card> PackList
        {
            get => _packList;            
        }      
               
        //private static Card dealtCard;
        private static int shuffleCounter = 0;

        /// <summary>
        /// Pack constructor. Pack will always be 52 cards, 4 suits of 13 cards.
        /// </summary>
        public Pack()
        {            
            for (int s = 1; s < 5; s++)
            {
                for (int v = 1; v < 14; v++)
                {
                    Card newCard = new Card(s, v);
                    PackList.Add(newCard);                    
                }
            }                 
        }

        /// <summary>
        /// Shuffles the cards within the park according to type of shuffle chosen and amount of shuffles required (default =0)
        /// </summary>
        /// <param name="typeOfShuffle">Integer used to select the shuffle type 1 = Fisher-Yates, 2 = Riffle shuffle, 3 = No shuffle.</param>
        /// <param name="shuffleAmount">Integer used to select the amount of shuffle required to increase randomness of the pack.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool ShuffleCardPack(int typeOfShuffle, int shuffleAmount = 0)
        {          
            if (PackList.Count != 0)
            {
                //Randomly selects one element from 0-51, then moves to end of list.
                //Randomly selects one element from 0-50, then moves to end of list.
                //Repeats this patern till all cards shuffled.
                bool FisherYates(int numOfShuffles = 1)
                {
                    Random random = new Random();

                    for (int counter = numOfShuffles; counter > 0; counter--)
                    {
                        for (int end = 52; end >= 0; end--)
                        {
                            int randNum = random.Next(end);
                            PackList.Add(PackList[randNum]);
                            PackList.Remove(PackList[randNum]);
                        }
                        shuffleCounter++;
                    }

                    return true;
                }

                //Splits pack in 2 and interlaces the split packs.
                bool Riffle(int numOfShuffles = 1)
                {
                    for (int counter = numOfShuffles; counter > 0; counter--)
                    {
                        //creates new list rifflePack to split the pack into 2.
                        List<Card> rifflePack = new List<Card>();
                        int additionCounter = 0;

                        for (int num = 26; num <= PackList.Count() - 1; num++)
                        {
                            rifflePack.Add(PackList[num]);
                        }

                        //Removes the 2nd half of packList, as these cards will now be in rifflePack.
                        PackList.RemoveRange(26, 26);

                        //Randon number to determine which list is element 0 in shuffled pack.
                        //Increases randomness of the shuffle.
                        Random riffleRandom = new Random();
                        int randNum = riffleRandom.Next(1);

                        if (randNum == 0)
                        {
                            additionCounter = 0;
                        }
                        else if (randNum == 1)
                        {
                            additionCounter = 1;
                        }

                        //Loop to cycle through packList and riffleList and insert 
                        //rifflePack cards between packList cards.
                        for (int riffleIndex = 0; riffleIndex < rifflePack.Count(); riffleIndex++)
                        {
                            int packListIndex = riffleIndex + additionCounter;

                            PackList.Insert(packListIndex, rifflePack[riffleIndex]);
                            additionCounter++;
                        }

                        shuffleCounter++;
                    }

                    return true;
                }

                if (typeOfShuffle == 1)
                {
                    FisherYates(shuffleAmount);
                    Console.WriteLine();
                    Console.WriteLine("Deck Shuffled: " + shuffleCounter + " times.");
                }
                else if (typeOfShuffle == 2)
                {
                    Riffle(shuffleAmount);
                    Console.WriteLine();
                    Console.WriteLine("Deck Shuffled: " + shuffleCounter + " times.");
                }
                else if (typeOfShuffle == 3)
                {
                    return true;
                }
                else
                {
                    //Custome exception to ensure only values 1, 2, or 3 are used.
                    Console.WriteLine("ShuffleTypeException: Incorrect value entered. Enter 1, 2, or 3 only.");
                    int shuffleNum = Int32.Parse(Console.ReadLine());

                    ShuffleCardPack(shuffleNum, shuffleAmount);
                }               
            }
            else
            {
                throw new Exception("Range Error - no cards in Pack to shuffle");
            }

            return true;
        }

        /// <summary>
        /// Deals a single Card.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static List<Card> DealCard()
        {
            //Deals the top card of the pack
            if (PackList.Count != 0)
            {
                dealtCards.RemoveRange(0, dealtCards.Count);
                dealtCards.Add(PackList[0]);
                PackList.RemoveAt(0);
                
                return dealtCards;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Range Error - Not enough cards left to deal!");
            }           
        }

        /// <summary>
        /// Deals multiples cards, buy add to dealtCards List and return list.
        /// </summary>
        /// <param name="amount">Integer to determine amount of cards to deal.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static List<Card> DealCard(int amount)
        {
            //Deals the top amount of cards according to method(argument)
            if (PackList.Count >= amount)
            {
                dealtCards.RemoveRange(0, dealtCards.Count);
                for (int i = 0; i <= amount -1; i++)
                {
                    
                    dealtCards.Add(PackList[0]);
                    PackList.RemoveAt(0);
                }
                return dealtCards;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Range Error - Not enough cards to deal " + amount + " cards!\n " +
                    "Cards remaining: "+ PackList.Count());
            }           
        }  
    }
}