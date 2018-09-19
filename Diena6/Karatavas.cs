using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena6
{
    public class Karatavas
    {
        List<String> Vardi;
        public char[] MinamaisVards;
        public char[] AtminetaisVards;
        int atlikusieMeginajumi;

        public Karatavas()
        {
            Vardi = new List<String>()
            {
               "ALA",
            "BITE",
            "LAPSA",
           "PLAVA",
             "KAFIJA",
            };
        }

        public void StartGame()
        {
            Random rnd = new Random();
            Vardi = Vardi.OrderBy(v=> rnd.Next()).ToList(); 
            string vards = Vardi[0];

             MinamaisVards = new char[vards.Length];
             AtminetaisVards = new char[vards.Length];
            atlikusieMeginajumi = 5;

            for (int i = 0; i < vards.Length; i++)
            {

                MinamaisVards[i] = vards[i];
                AtminetaisVards[i] = '_';
            }
           
            Console.WriteLine(String.Join(" ", AtminetaisVards));

        }

        public void MinetBurtu(char burts)
        {
            bool vaiirVarda = false;
            for (int i = 0; i < MinamaisVards.Length; i++)
            {
                
                if (Char.ToUpper(MinamaisVards [i]) == char.ToUpper(burts))
                {
                    if (AtminetaisVards[i] != burts)
                    {
                        AtminetaisVards[i] = burts;
                        vaiirVarda = true;
                    }
                    else
                    {
                        Console.WriteLine("Šis burts jau ir atminēts");
                        break;
                    }
                                      
                    
                }
            }
            if (vaiirVarda)
            {
                Console.WriteLine(string.Join(" ", AtminetaisVards));
            }
            else
            {
                
                atlikusieMeginajumi--;
                Console.WriteLine(("Atlikušie mēģinājumi ir tik - " + atlikusieMeginajumi));
            }
        }
        public bool VaiIrMeginajumi()
        {
            return atlikusieMeginajumi > 0;
        }

        public string Vards()
        {
            return new string(MinamaisVards);
        }

        public bool VaiIrAtminets()
        {
            bool irAtminets = true;

            foreach (char burts in AtminetaisVards)
            {
                if (burts == '_')
                {
                    irAtminets = false;
                    
                    break;

                }
            }
            return irAtminets;
        }


    }
}
