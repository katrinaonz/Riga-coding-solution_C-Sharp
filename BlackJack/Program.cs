using BlackJack.Dati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table();

            while (true)
            {
                table.StartNewGame();
                table.PlayerTurn();
                table.DealerTurn();
                table.ShowResults();
                //if (table.PlayAgain() == false) - zemak ir isaks piemers
                if (!table.PlayAgain())
                {
                    break;
                }
            }
            //1. ja speletajam ir 21 tad partraukt vaicāšanu--> player
            //2. pie reuzltata izvadit abu dalibnieka punktus --> table
            //3.cikliski uzsakt jaunu spēli --> Main() tas ir tas while cikls

            Console.ReadLine();

        }
    }
}
