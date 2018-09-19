using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzerienuAutomats
{
    public class DzerienaAutomats
    {
        public double IemaksataSumma;

        public DzerienaAutomats()
        {
            IemaksataSumma = 0;
        }

        public void Iemaksat(double summa)
        {
            IemaksataSumma = IemaksataSumma + summa; 
        }

        public void PirktDzerienu()
        {
            while (true)
            {
                if (IemaksataSumma > 0.8)
                {
                    IemaksataSumma = IemaksataSumma - 0.8;
                    Console.WriteLine("Atlikums - " + IemaksataSumma);
                }
                else
                {
                    Console.WriteLine("Nepietiek līdzekli");
                    break;
                }
            }
        }
        public void SanemtAlikumu()
        {
            Console.WriteLine("Atlikums - " + IemaksataSumma);
            IemaksataSumma = 0;
        }

        public void Darbibas()
        {
            Console.WriteLine("Izvelies darbību: ");
            Console.WriteLine("- Iemaksat (i)");
            Console.WriteLine("- Pirkt (p)");
            Console.WriteLine("- Izdot atlikumu (a)");
            Console.WriteLine("- Beigt darbu (b)");

            while (true)
            {
                Console.Write("Darbība: ");
                string darbiba = Console.ReadLine().ToLower();

                if (darbiba == "b")
                {
                    break;
                }

                switch (darbiba)
                {
                    case "i":
                        Console.WriteLine("Ievadi summu - ");
                        double summa = Convert.ToDouble(Console.ReadLine());
                        Iemaksat(summa);
                            break;
                    case "p":
                        PirktDzerienu();
                        break;
                    case "a":
                        SanemtAlikumu();
                        break;
                }

            }
        }
        
    }
}
