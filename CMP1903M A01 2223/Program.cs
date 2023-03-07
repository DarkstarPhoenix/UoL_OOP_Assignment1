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
            Player player = Testing.createPlayer();
            Console.WriteLine();

            Testing.CreatePack();
            Console.WriteLine();

            Testing.ShufflePack();
            Console.WriteLine();

            Testing.Deal();
            Console.WriteLine();

            Testing.ShowPlayerHand(player, Player.Hand);
            Console.WriteLine();

            Testing.Deal();
            Console.WriteLine();

            Testing.ShowPlayerHand(player, Player.Hand);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
