using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    public class Klase
    {
        public string KlaseString;
        public int SkolenuSk;

        public void KlaseD()
        {
            Telpa TelpaCC = new Telpa();
            Console.WriteLine("Klases nosaukums ir " + KlaseString + " ,bet skolenu skaits "+SkolenuSk);
            TelpaCC.TelpaD();
        }
    }
}
