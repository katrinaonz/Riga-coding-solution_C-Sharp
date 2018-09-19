using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena5
{
    public class Iedzivotajs
    {
        public string Vards;
        public string Uzvards;

        public Adrese Dzivesvieta;

        public void Apraksts()
        {
            Console.Write(Vards + Uzvards + Dzivesvieta.Pilseta + Dzivesvieta.PilnaAdrese());
        }
    }
}
