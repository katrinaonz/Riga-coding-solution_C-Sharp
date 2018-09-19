using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena8
{
    public class Aplis : GeometriskasFiguras
    {
        public double Radiuss;

        public Aplis(double radiuss)
        {
            this.Radiuss = radiuss;
        }

        public void Laukums()
        {
            double laukums = Math.PI * Radiuss * Radiuss;
            Console.WriteLine("Laukums = " + laukums);
            //void - neatgriez resultatu tikai izvada
        }

        public double Perimetrs()
        {
            double perimetrs = 2 * Math.PI * Radiuss;
            return perimetrs;
            //double - metode aprekina reszultatu ko var izmantot talak programma. atgriez resultatu
        }
    }
}
