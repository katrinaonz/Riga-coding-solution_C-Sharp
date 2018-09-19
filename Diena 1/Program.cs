using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string izvTeksts = teksts();
            izvTeksts = izvTeksts + " " + skaitlis();
            Console.WriteLine(izvTeksts);
            bezrezultata();
            Console.ReadLine();
        }
        static void bezrezultata()
        {
            Console.WriteLine("Izsaukt fukciju");
        }
        static string teksts()
        {
            return "Hello world";
        }
    
    static int skaitlis()
        {
            return 5;              
        }

    }
}
