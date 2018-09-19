using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena8
{
    class Program
    {
        static void Main(string[] args)
        {
            Aplis aplis = new Aplis(5);
            Kvadrats kvadrats = new Kvadrats(10);
            Taisnsturis taisnsturis = new Taisnsturis(5, 10);
            
            Figuras("Kvadrats",kvadrats);
            Figuras("Aplis", aplis);
            Figuras("Taisnsturis", taisnsturis);
            Console.ReadLine();
        }
        static void Figuras(string nosaukums, GeometriskasFiguras tr)
        {
            Console.WriteLine(nosaukums);
            double perimetrs = tr.Perimetrs();
            Console.WriteLine("Perimetrs ir " + perimetrs);
            tr.Laukums();

            if (tr is Kvadrats)
            {
                Console.WriteLine("TIka izvadits kvadrats");
            }
        }

        static void Piemers(string[] args)
        {
            Auto auto = new Auto();
            Lidmašīna lidmasina = new Lidmašīna();
            ParvietotAuto(auto);
            ParvietotLidmasina(lidmasina);

            Parvietot(auto);
            Parvietot(lidmasina);

            Console.ReadLine();
        }
        static void ParvietotAuto(Auto auto)
        {
            auto.Parvietoties();
        }
        static void ParvietotLidmasina(Lidmašīna lidmasina)
        {
            lidmasina.Parvietoties();
        }

        static void Parvietot(Transportlidzeklis tr)
        {
            tr.Parvietoties();
        }

    }
}
