using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Dati
{
    public class Card
    {
        //1. ipašība - Suit (string) masts
        //2. īpašība - Value (string) vertiba
        public string Suit;
        public string Value;

        //3. konstruktors - aizpilda abas īpašības. 
        public Card(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }

        //4. funkcija kas atgriež kārts vertību - getPoints() - atgriez karts skaitlisko vertibu
        
        public int getPoints()
        {
            switch (Value)
            {
                //seit var nelietot brake; jo return visu partrauc un iziete ara getpoints ar vertibu
                case "A":
                    return 11;
                case "Q":
                case "K":
                case "J":
                    return 10;
                default:
                    return Int32.Parse(Value);
            }
        }
    }
}
