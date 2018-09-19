using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    public class MacibuPrieksmets
    {
        public string Nosaukums;
        public string SkolotajsMP;
        public void MprieksD()
        {
            Skolotajs SkolotajsCC = new Skolotajs();
            Telpa TelpaCC = new Telpa();
            Console.WriteLine("Priekšmeta nosaukums - " + Nosaukums);
            SkolotajsCC.SkolotajsDarb();
            TelpaCC.TelpaD();

        }
    }
}
