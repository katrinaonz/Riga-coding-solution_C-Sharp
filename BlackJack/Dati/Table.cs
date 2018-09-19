using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Dati
{
    public class Table
    {
        private Deck deck;
        private Dealer dealer;
        private Player player;

        //1. void StartNewGame()

        public void StartNewGame()
        {
            //1.1. paņem jaunu karšu kavu
            deck = new Deck(); //sanak ka tikai konstruktors darbojas
            dealer = new Dealer();
            player = new Player();
            //1.2. samaisa kartis
            deck.Shuffle();
            //1.3. speletama pieksir divas kartis
            player.GiveCard(deck.GetCard());
            player.GiveCard(deck.GetCard());
            //1.4. dealerim pieskir divas kartis
            dealer.GiveCard(deck.GetCard());
            dealer.GiveCard(deck.GetCard());
        }

        //2. bool PlayAgain()
        //2.1. vaicā lietotajam vai uzsākt jaunu spēli
        public bool PlayAgain()
        {
                Console.WriteLine("Vai vēlies spēlet velreiz? Atbldi J vai N");
                string answer = Console.ReadLine();
                return answer.ToLower() == "j"; //atgriiezis true ko velak izmantos
        }

        //3. void ShowResults()
        //3.1.izvada resultatu - kurš uzvarēja
        public void ShowResults()
        {
            int playerPoints = player.CountPoints();
            int dealerPoints = dealer.CountPoints();

            Console.WriteLine("Dīlera punkti: " + dealerPoints);
            Console.WriteLine("Spēlētāja punkti: " + playerPoints);

            if (playerPoints < 21)
            {
                Console.WriteLine("Spēletājs Zaudeji!");
            }
            else if (dealerPoints < 21)
            {
                Console.WriteLine("Dealer zaudeja, tu uzvarēji");
            }
            else if (dealerPoints == playerPoints)
            {
                Console.WriteLine("Neizšķirts");

            }
            else if (playerPoints > dealerPoints)
            {
                Console.WriteLine("Tu uzvarēji");
            }
            else
            {
                Console.WriteLine("Tu zaudēji!");
            }

        }

        //4. void PlayerTurn()
        //4.1. dod kārtis spēletājam tik ilgi, kamēr vēlās
        public void PlayerTurn()
        {
            while (player.NeedCard())
            {
                player.GiveCard(deck.GetCard());
            }
        }

        //5. void DealerTurn()
        //5.1. dod kārtis dīlerim tik ilgi, kamēr ir nepieciešams
        public void DealerTurn()
        {
            while (dealer.NeedCard())
            {
                dealer.GiveCard(deck.GetCard());
            }

        }
    }
}
