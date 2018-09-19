using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    public class aplis
    {
        public string KrasasNosaukums;
        public int Radiuss;

        public void Krasa()
        {
            Console.WriteLine("Krasa - " + KrasasNosaukums);
        }

        public void Perimetrs()
        {
            double P = 2 * Math.PI * Radiuss;
            Console.WriteLine("Perimetrs ir " + P);
        }
        public void Laukums()
        {
            double S = Math.PI * Radiuss * Radiuss;
            Console.WriteLine("Laukums ir " + S);
        }
    }
}
