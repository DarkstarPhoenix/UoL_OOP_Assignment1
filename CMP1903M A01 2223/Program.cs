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
            Test.createPack();
            Console.WriteLine();

            Test.shufflePack();
            Console.WriteLine();

            Test.testDeal();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
