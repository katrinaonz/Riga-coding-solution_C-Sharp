using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    public class Taisnsturis
    {
        public int MalasGarums1;
        public int MalasGarums2;
        public void Perimetrs()
            {
            int P = (MalasGarums1 + MalasGarums2) * 2;
            Console.WriteLine("Perimetrs - " + P);
            }
        public void Laukums()
        {
            int S = MalasGarums2 * MalasGarums1;
            Console.WriteLine("Laukums - " + S);
        }

    }
}
