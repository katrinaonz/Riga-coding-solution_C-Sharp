using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    public class kvadrats
    {
        public int MalasGarums;
        public string Krasa;
        public void Laukums()
        {
            int S = MalasGarums * MalasGarums;
            Console.WriteLine("Laukums ir " + S);
        }

        public void Perimetrs()
        {
            int P = MalasGarums * 4;
            Console.WriteLine("Perimetrs ir " + P);
        }

        public void KKrasa()
        {
            Console.WriteLine("Krasa ir " + Krasa);
        }
    }
}
