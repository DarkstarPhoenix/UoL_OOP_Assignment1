using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Test
    {

        public static Pack createPack()
        {
            Pack newPack= new Pack();
            Console.WriteLine("New Pack created!");

            return newPack;
        }

        public static void shufflePack()
        {
            string shuffle;
            string shuffleAmount;

            Console.WriteLine("What type of shuffle would do you require?:");
            Console.WriteLine("1 -- Fisher-Yates.");
            Console.WriteLine("2 -- Riffle.");
            Console.WriteLine("3 -- No Shuffle.");
            shuffle = Console.ReadLine();
            int shuffleNum = Int32.Parse(shuffle);

            Console.WriteLine("How may times would you like the deck shuffled?:");
            Console.WriteLine("Enter value:");
            shuffleAmount= Console.ReadLine();
            int shuffleAmountNum = Int32.Parse(shuffleAmount);
            

            Pack.shuffleCardPack(shuffleNum, shuffleAmountNum);

        }

        public static void testDeal()
        {
            
            {
                string dealAmount;
                
                
                
                Console.WriteLine("How many cards do you require to be dealt");
                Console.WriteLine("Enter a value");
                dealAmount = Console.ReadLine();
                int dealAmountNum = Int32.Parse(dealAmount);

                if (dealAmountNum > 1)
                {
                    List<Card> dealtCards = Pack.dealCard(dealAmountNum);
                    foreach (Card card in dealtCards)
                    {
                        Console.WriteLine(card);
                    }
                }
                else
                {
                    Console.WriteLine(Pack.dealCard());
                    
                }
               
            }
        }

    }
}
