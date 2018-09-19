using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena7
{
    public class Uzdevumi
    {
        public static void Moodinatajs()
        {
            Console.WriteLine("Ievadi dienu skaitu (P,O,T,Pk,Se,Sv) -");
            String diena = Console.ReadLine();

            Console.Write("Vai ir atvalinajums (J/N) - ");
            string irAtvl = Console.ReadLine();

            switch (diena)
            {
                case "P":
                case "O":
                case "T":
                case "Pk":
                     if (irAtvl =="J")
                        {
                        Console.Write("10:00");
}
                    else
                    {
                        Console.Write("7:00");
                    }
                    break;
                case "Se":
                case "Sv":
                    if (irAtvl == "J")
                    {
                        Console.Write("Off");
                    }
                    else
                    {
                        Console.Write("10.00");
                    }
                    break;
            }

        }
        
        
    }
}
