using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Dati
{
    public class Dealer : Player //manto tas klases ipašības - blakus klase atzimeja virtual 2 klases
    { 
        //tpc raksta override and izvelas tas divas klases kuras kko mainis, parejas izpildisies tapat
        public override void GiveCard(Card card)
        {
            Cards.Add(card);
        }
    
        public override bool NeedCard()
        {
            //ja nav sasniegti 17, punkti, ir nepieciešama kārts
            return CountPoints() < 17;
        }
    }
}
