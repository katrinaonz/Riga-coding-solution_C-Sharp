using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    public class Skolens
    {
        public string Vards;
        public string Uzvards;
        public string Epasts;
        public int DzGads;

        public void SkolendsD()
            {
            Klase KlaseCC = new Klase();
            Console.WriteLine("Skolena vards - " + Vards + ", skolena uzvards - " + Uzvards + ", Epasts - " + Epasts + ", dzimšanas gads -" + DzGads);
            KlaseCC.KlaseD();
            }
    }
}
