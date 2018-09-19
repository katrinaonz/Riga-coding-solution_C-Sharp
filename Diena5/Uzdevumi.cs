using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena5
{
    public class Uzdevumi
    {
        public static void Uzdevums24()
        { 
            int[] masivs = { 0, 10, 20, 30, 40, 50 };

            Console.WriteLine("Ievadi pārbaudāmo skaitli - ");
            int Skaitlis = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < masivs.Length; i++)
            {
                if (Skaitlis == masivs[i])
                {
                    Console.WriteLine("Skaitlis atrast pozicijā " + i);
                    return;
                } 
            }
            Console.Write("Skaitlis nav atrast!");
        }
        public static void Uzd28()
        {
            List<Prece> saraksts = new List<Prece>();
            saraksts.Add(new Prece("Dators", 900));
            saraksts.Add(new Prece("Bikses", 50));
            saraksts.Add(new Prece("Auto", 10000));
            saraksts.Add(new Prece("Mobilais", 200));
            saraksts.Add(new Prece("TV", 550));
            saraksts.Add(new Prece("Koferis", 100));
            saraksts.Add(new Prece("Cimdi", 20));
            saraksts.Add(new Prece("Cepure", 10));

            Console.WriteLine("Pieejamas preces: ");

            foreach (Prece p in saraksts)
            {
                Console.WriteLine(p.Nosaukums + "$" + p.Cena);
            }

            double summa = 0;
            while (true)
            {
                Console.Write("Ievadi preci - ");
                string nosaukums = Console.ReadLine();
                if (nosaukums == "0")
                {
                    break;
                }
                foreach (var pr in saraksts)
                {
                    if (pr.Nosaukums.Equals(nosaukums, StringComparison.OrdinalIgnoreCase))
                    {
                        summa += pr.Cena;
                        break;
                    }
                }
            }
            Console.WriteLine("Summa ir $" + summa);

        }

        public static void Uzd27()
        {
            List<int> saraksts = new List<int>();

            while (true)
            {
                Console.Write("Ievadi skaitli (partraukt 0) - ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                if (skaitlis == 0)
                {
                    break;
                }
                saraksts.Add(skaitlis);
            }
            int max = saraksts[0];
            foreach (int skaitlis in saraksts)
            {
                if (skaitlis > max)
                {
                    max = skaitlis;
                }

            }
            Console.WriteLine("Lielakais skaitlis ir " + max);
            int min = saraksts[0];
            foreach (int skaitlis in saraksts)
            {
                if (skaitlis < min)
                {
                    min = skaitlis;
                }
            }
            Console.WriteLine("Mazakais skaitlis ir " + min);
        }

        public static void Uzd26()
        {
           
            List<int> saraksts = new List<int>();

            while (true)
            {
                Console.Write("Ievadi skaitli (partraukt 0) - ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                if (skaitlis == 0)
                {
                    break;
                }
                saraksts.Add(skaitlis);
            }
            int skaits = 0;
            foreach (int skaitlis in saraksts)
            {
                if (skaitlis == 5)
                {
                    skaits++;
                }
            }
            Console.WriteLine("Atrasti ti daudz skaitli kas ir 5 - " + skaits);
        }
    }
}
