using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena5
{
    class Program
    {
        static void Main(string[] args)
        {
            //IedzivotajsAdrese();

            //MasivaPemers();
            //Uzdevums25();
            //Uzdevumi.Uzd26();
            //Uzdevumi.Uzd27();
            Uzdevumi.Uzd28();
            //Uzdevumi.Uzdevums24();
            Console.ReadLine();
        }
        static void IedzivotajsAdrese()
        {
            Iedzivotajs iedz = new Iedzivotajs();
            iedz.Vards = "Andris";
            iedz.Uzvards = "Berzins";
            iedz.Dzivesvieta = new Adrese();
            iedz.Dzivesvieta.Valsts = "Latvija";
            iedz.Dzivesvieta.Pilseta = "Riga";
            iedz.Dzivesvieta.Iela = "Brivibas gatve";
            iedz.Dzivesvieta.MajasNr = "12c";
            iedz.Dzivesvieta.DzivoklaNr = 5;

            iedz.Apraksts();
        }
        static void Uzdevums25()
        {
            int count = 1;
            List<int> saraksts = new List<int>();

            /*while (true) vareja var izveidot
             * 
             * tad ieliek if (skaitlis ==0) {break} 
             * else {saraksts.add(skaitlis)}
             * */

            while (count != 0)
            {
                Console.WriteLine("Ievadiet skaitli, ja gribiet pārtraukt tad ievadiet 0 - ");
                int Skaitlis = Convert.ToInt32(Console.ReadLine());
                count = Skaitlis;
                saraksts.Add(Skaitlis);
            }
            //jo mes pie 5 elementa nevaram pieklut jo sak skaiti no nulles
            for (int i = saraksts.Count-1; i >= 0; i--)
            {
                Console.WriteLine(saraksts[i]);
            }

        }

        static void SarakstaPiemers()
        {
            List<int> saraksts = new List<int>();
            //sarakstam nav uzreiz japasaka izmers tpc ertaks
            saraksts.Add(5);
            saraksts.Add(10);
            saraksts.Add(17);

            foreach (int sk in saraksts)
            {
                Console.WriteLine(sk);
            }
            for (int i = 0; i < saraksts.Count; i++)
            {
                Console.WriteLine(saraksts[i]);
                //tas pats kas tika darits pie massiva jo izdala skaitli masiva kura vieta ir
            }
        }

        static void MasivaPemers()
        {

            //vienkarsi ta butu
            //int skaitlis1 = 5;
            //int skaitlis = 10;
            //bet zemak masivs - [] apzime ka bus masivs, 3 ka bus tris vertibas
            int[] saraksts = new int[3];
            saraksts[0] = 5;
            saraksts[1] = 10;
            saraksts[2] = 19;
            //saraksts[3] <- izmestu kludu, jo tikai 3 elementi pateicam

            //isais piemers ja ir zinamas vertibas ko izvaddit
            int[] saraksts2 = { 5, 10, 19 };
            //lai noskaidrotu cik vertibas ir masiva so raksta
            int skaitsMasiva = saraksts2.Length;

            //lai izvaditu vertibas - attiecigi izvads 5 10 19
            for (int i = 0; i < saraksts.Length; i++)
            {
                //izvada skaitli pozicija i (bus no 0 lidz 2)
                Console.WriteLine(saraksts[i]);
            }

            //lai nebutu gari jaraskta spec cikls pirkes masiviem. soreiz izvadis 5 10 19
            foreach (int skaitlis in saraksts2)
            {
                Console.WriteLine(skaitlis);
            }

        }
    }
}
