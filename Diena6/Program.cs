using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena6
{
    class Program
    {
        static void Main(string[] args)
        {
            Karatavas kar = new Karatavas();
            kar.StartGame();
            
            while (!kar.VaiIrAtminets() && kar.VaiIrMeginajumi())
            {
                Console.Write("Ievadi burtu - ");
                char burts = Convert.ToChar(Console.ReadLine());
                kar.MinetBurtu(burts);
               
            }

            if (kar.VaiIrMeginajumi())
            {
                Console.WriteLine("Vards ir atminets!");
            }
            else
            {
                Console.WriteLine("beidzas meginajumi!");
                Console.WriteLine("Pareizais atminejums bija - " + kar.Vards());
            }
          
            //FizzBuzz();

            Console.ReadLine();

        }

        static void FizzBuzz()
        {
            Console.WriteLine("Ievadi sakuma vērtību - ");
            int Sskaitlis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi beigu vērtību - ");
            int Bskaitlis = Convert.ToInt32(Console.ReadLine());

            for (int i = Sskaitlis; i <= Bskaitlis; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    
                }
                else if (i % 3 ==0)
                    {
                    Console.WriteLine("Fizz");
                    
                }
                                    
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
  
    }
}

