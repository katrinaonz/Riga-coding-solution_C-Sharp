using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Dati
{
    public class Deck
    {
        public string[] Suits = { "H", "S", "D", "C" };
        public string[] Values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A", };
        //1. īpašība - Cards - ieksa nepieciešams saraksts ar kartim un kads tips bus 
        public List<Card> Cards; 

        //2. konstruktors (bez parametriem)
        //2.1. aipilda karsu sarakstu ar visam 52 kartim
        public Deck()
        {
            Cards = new List<Card>();
            foreach (string suit in Suits) 
            {
                foreach (string value in Values)
                {
                    Cards.Add(new Card(suit, value));
                }
            }
        }
        public void Shuffle()
        {
            Random rnd = new Random();
            Cards = Cards.OrderBy(c => rnd.Next()).ToList(); 
        }

        //3. funkcija shuffle() - sajauc Cards.
        //4. Card getCard() - atgriez vienu kārti no saraksta un dzēš no saraksta - nevar to otreiz izmantot
        public Card GetCard()
        {
            //4.1. panem karti no saraksta ... card atkal jauns mainigais
            Card card = Cards [0];
            //4.2. izdzes no saraksta
            Cards.Remove(card);
            //4.3. atgriez ka rezultatu
            return card;
        }
    }
}
