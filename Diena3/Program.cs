using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena3
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzdevums.Uzdevums20();
            Console.ReadLine();
        }

        static void Piemers()
        {
            string mervieniba = "C";

            switch (mervieniba)
            {
                case "C":
                    Console.Write("Ievaditi celsijs");
                    break;
                case "F":
                    Console.Write("Ievaditi farenheiti");
                    break;
                case "K":
                    Console.Write("Ievaditi Kelvini");
                    break;
                default:
                    Console.Write("Nezinamas mervienibas");
                    break;
            }
            Console.ReadLine();
        }

    }
}
