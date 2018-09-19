using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    public class Tristuris
    {
        public int MalasGarums1;
        public int MalasGarums2;
        public int MalasGarums3;
        public void Perimetrs()
        {
            int P = MalasGarums1 + MalasGarums2 + MalasGarums3;
            Console.WriteLine("Perimetrs ir " + P);
        }
        public void Laukums()
        {
            int PP = (MalasGarums1 + MalasGarums2 + MalasGarums3) / 2;
            double S = Math.Sqrt(PP * (PP - MalasGarums1) * (PP - MalasGarums2) * (PP - MalasGarums3));
            Console.WriteLine("Laukums ir " + S);
        }
    }
}
