using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena8
{
    public 
        class Taisnsturis : GeometriskasFiguras
    {
        public double Mala1;
        public double Mala2;

        public Taisnsturis(double mala1, double mala2)
        {
            Mala1 = mala1;
            Mala2 = mala2;
        }

        public void Laukums()
        {
            double laukums = Mala1 * Mala2;
            Console.WriteLine("Laukums ir " + laukums);
        }

        public double Perimetrs()
        {
            double perimetrs = Mala1 * 2 + Mala2 * 2;
            return perimetrs;
        }
    }
}
