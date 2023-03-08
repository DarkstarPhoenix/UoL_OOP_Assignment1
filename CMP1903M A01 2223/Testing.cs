using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
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
        public static Player CreatePlayer()
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
            int shuffleNum = 0;
            bool shuffleBool = false;

            while (!shuffleBool)
            {
                try
                {
                    Console.WriteLine("What type of shuffle would do you require?:");
                    Console.WriteLine("1 -- Fisher-Yates.");
                    Console.WriteLine("2 -- Riffle.");
                    Console.WriteLine("3 -- No Shuffle.");
                    shuffle = Console.ReadLine();
                    Console.WriteLine();

                    shuffleNum = Int32.Parse(shuffle);
                    shuffleBool= true;
                }
                catch (FormatException e)
                {
                    shuffleBool = false;
                    Console.WriteLine($"{e.Message} Use integers only. \n");
                }
            }
         
            if (shuffleNum != 3)
            {
                shuffleBool = false;
                while (!shuffleBool)
                {
                    try
                    {
                        Console.WriteLine("How may times would you like the deck shuffled?:");
                        Console.WriteLine("Enter value:");
                        shuffleAmount = Console.ReadLine();
                        int shuffleAmountNum = Int32.Parse(shuffleAmount);

                        Pack.ShuffleCardPack(shuffleNum, shuffleAmountNum);
                        shuffleBool= true;
                    }
                    catch (FormatException e)
                    {
                        shuffleBool = false;
                        Console.WriteLine($"{e.Message} Use integers only. \n");
                    }
                }
            }       
        }

        /// <summary>
        /// Test the deal methods.
        /// </summary>
        public static void Deal()
        {            
            {
                bool dealBool = false;
                string dealAmount;
                int dealAmountNum = 0;
                
                while (!dealBool)
                {
                    try
                    {
                        Console.WriteLine("How many cards do you require to be dealt");
                        Console.WriteLine("Enter a value");
                        dealAmount = Console.ReadLine();

                        dealAmountNum = Int32.Parse(dealAmount);

                        dealBool = true;
                    }
                    catch (FormatException e)
                    {
                        dealBool = false;
                        Console.WriteLine($"{e.Message} Use integers only. \n");
                    }
                }

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
