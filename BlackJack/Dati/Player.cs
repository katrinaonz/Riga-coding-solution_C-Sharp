using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Dati
{
    public class Player
    {
        //1. īpašība Cards (List<Card>)
        public List<Card> Cards;
        //2.konstruktors (bez parametriem - tas ir tuksaas iekavas ())
        //2.1. define Cards sarakstu
        public Player()
        {
            Cards = new List<Card>();
        }

        //3. int countPoints() - funkcija kas saskaita visu Cards points
        public int CountPoints()
        {
            //3.1. foreach()
            //3.2. ->GetPoints()
            int points = 0;
            int aceCount = 0;
            foreach (Card c in Cards)
            {
                points += c.getPoints();
                //ja ir duzis tad palielam to skaitu
                if (c.getPoints() == 11)
                {
                    aceCount++;
                }
            }

            //3.3 apstradat dūžus
            //ja punktu skaits parsniedz 21 un ir kāds dūzis tad par katru
            //nemam nost 10 punktus, kamer neparsniedz 21 vai beidzas duži
            while (points > 21 && aceCount > 0)
            {
                points = points - 10;
                aceCount--;
            }
            return points;
        }
        //4. void giveCard(Card Card) - pievienot karti sarakstam - 
        public virtual void GiveCard(Card card)
        {
            Cards.Add(card);
            Console.WriteLine("Spēlētajs saņēma " + card.Suit + card.Value);
            Console.WriteLine("Punkti = " + CountPoints());
        }

        //5. bool needCard() - vai nepieciešama vēl karts spēlētājam? 
        public virtual bool NeedCard()
        {
            if (CountPoints() > 21)
            {
                return false;
            }
            else
            {
                Console.Write(" nepieciesmas karts");
                string atbilde = Console.ReadLine();

                if (atbilde.ToLower() == "j")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
