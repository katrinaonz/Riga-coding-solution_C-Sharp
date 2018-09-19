using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena5_1
{
    public class Uzdevumi_1
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
    }
}
