using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena5
{
    public class Prece
    {
        public string Nosaukums;
        public double Cena;

        public Prece(string nosaukums, double cena)
        {
            //this.Nosaukums - parada ka javertas pie klases vertibas ja mulsina ka viens nosaukums
            Nosaukums = nosaukums;
            Cena = cena;
        }
    }
}
