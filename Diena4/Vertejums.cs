using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    public class Vertejums
    {
        public string Priekšmets;
        public int Atzime;

        public void VertejumsD()
        {
            Skolens SkolensCC = new Skolens();
            Console.WriteLine("Prieksmets - " + Priekšmets + " un atzime - " + Atzime);
            SkolensCC.SkolendsD();
        }
    }
}
