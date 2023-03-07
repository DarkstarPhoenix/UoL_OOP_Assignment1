using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Testing
    {
        /// <summary>
        /// Creates a Pack object.
        /// </summary>
        /// <returns></returns>
        public static Pack CreatePack()
        {
            Pack newPack= new Pack();
            Console.WriteLine("New Pack created!");

            return newPack;
        }

        /// <summary>
        /// Create new player object.
        /// </summary>
        /// <returns></returns>
        public static Player createPlayer()
        {
            Console.WriteLine("Enter name of Player 1: ");
            string playerName = Console.ReadLine();
            Console.WriteLine();
            Player player = new Player(playerName);
            Console.WriteLine("Welcome " + player);
            Console.WriteLine();

            return player;
        }

        /// <summary>
        /// Tests the the shuffle methods of Pack class
        /// </summary>
        public static void ShufflePack()
        {
            string shuffle;
            string shuffleAmount;

            Console.WriteLine("What type of shuffle would do you require?:");
            Console.WriteLine("1 -- Fisher-Yates.");
            Console.WriteLine("2 -- Riffle.");
            Console.WriteLine("3 -- No Shuffle.");
            shuffle = Console.ReadLine();
            Console.WriteLine();
            int shuffleNum = Int32.Parse(shuffle);

            if (shuffleNum != 3)
            {
                Console.WriteLine("How may times would you like the deck shuffled?:");
                Console.WriteLine("Enter value:");
                shuffleAmount = Console.ReadLine();
                int shuffleAmountNum = Int32.Parse(shuffleAmount);

                Pack.ShuffleCardPack(shuffleNum, shuffleAmountNum);
            }       
            
        }

        /// <summary>
        /// Test the deal methods. Loops untill all cards are dealt.
        /// </summary>
        public static void Deal()
        {            
            {
                string dealAmount;                                            
                                
                Console.WriteLine("How many cards do you require to be dealt");
                Console.WriteLine("Enter a value");
                dealAmount = Console.ReadLine();
                
                int dealAmountNum = Int32.Parse(dealAmount);

                if (dealAmountNum > 1)
                {
                    List<Card> dealtCards = Pack.DealCard(dealAmountNum);
                        
                    foreach (Card card in dealtCards)
                    {
                        Player.PlayersHand(card);
                                                      
                    }
                }
                else
                {
                    List<Card> dealtCards = Pack.DealCard();

                    foreach (Card card in dealtCards)
                    {
                        Player.PlayersHand(card);
                            
                    }

                }
                 
                if (Pack.PackList.Count == 0)
                {
                    Console.WriteLine("No more cards left in pack!");
                }                
               
            }
        }

        public static void ShowPlayerHand(Player player, List<Card> playerHand)
        {
            Console.WriteLine($"{player}'s hand: ");

            foreach (Card card in playerHand)
            {
                Console.WriteLine(card);
            }
        }

    }
}
