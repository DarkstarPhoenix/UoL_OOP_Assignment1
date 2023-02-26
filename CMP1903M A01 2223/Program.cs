using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
     
        static void Main(string[] args)
        {
            string shuffle;
            Pack newPack = new Pack();

            Console.WriteLine("Your card pack has been created. How would you like it to be shuffled?: ");
            Console.WriteLine("1: Fisher-Yates.");
            Console.WriteLine("2: Riffle.");
            Console.WriteLine("3: No Shuffle");
            Console.WriteLine("Please select an option: ");
            shuffle = Console.ReadLine();
            int shuffleNum = Int32.Parse(shuffle);

            Pack.shuffleCardPack(shuffleNum);
            

            

            Console.ReadLine();
        }
    }
}
