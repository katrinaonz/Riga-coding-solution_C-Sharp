using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena1_uzdevums
{
    class Program
    {
        static void Main(string[] args)
        {
            Gradi();
            Skatilis4();
            Skatilis3();
            SkaitluSumma();
            VardaIzvade(); 


        }
        static void Gradi()
        {
            Console.Write("Uzdevums nr. 4. Noradi Celsija gradus - ");
            int celsiji = Convert.ToInt32(Console.ReadLine());

            int kelvini = celsiji + 273;

            float farenheiti = 1.8F * celsiji + 32;

            Console.WriteLine(" K " + kelvini + " F " + farenheiti);

        }


        static void Skatilis4()
        {
            Console.Write("Uzdevums - trīs skaitlu reizinājums - ");
            Console.Write("Ievadi pirmo skaitli - ");
            int pirskaitlis = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi otro skaitli - ");
            int otrskaitlis = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi tresais skaitli - ");
            int tresskaitlis = Convert.ToInt32(Console.ReadLine());

            int reiz = pirskaitlis * otrskaitlis * tresskaitlis;

            Console.WriteLine("Reizinājums ir " + reiz);
        }
        static void Skatilis3()
        {
            Console.Write("Uzdevums - darbības ar diviem skaitļiem - ");
            
            Console.Write("Uzdevums nr.3. Ievadi pirmo skaitli - ");
            int pirskaitlis = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi otro skaitli - ");
            int otrskaitlis = Convert.ToInt32(Console.ReadLine());

            int sum = pirskaitlis + otrskaitlis;
            int starp = pirskaitlis - otrskaitlis;
            int reiz = pirskaitlis * otrskaitlis;
            int dal = pirskaitlis / otrskaitlis;
            int ddal = pirskaitlis % otrskaitlis;

            Console.WriteLine("Summa ir " + sum + " ; Starpība ir " + starp + " ; Reizinājums ir " + reiz + " ; Dalījums ir " + dal + " ; Skaitļa daļa " + ddal );
        }

        static void SkaitluSumma()
        {
            Console.Write("Uzdevums - divu skaitlu summa - ");
            Console.Write("Ievadi pirmo skaitli - ");
            int Pskaitlis = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi otro skaitli - ");
            int Oskaitlis = Convert.ToInt32(Console.ReadLine());

            int total = Pskaitlis + Oskaitlis;

            Console.WriteLine("Šo skaitlu summa ir - " + total);
        }

        static void VardaIzvade()
        {
            Console.Write("Uzdevums - Iepazišanās - ");
            Console.Write("Uzdevums nr.1 Ievadi vardu - "); 
            string vards = Console.ReadLine(); 

            Console.Write("Ievadi uzvardu - "); 
            string uzvards = Console.ReadLine();

            Console.Write("Ievadi vecumu - ");
            int vecums = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Tevi sauc " + vards + " " + uzvards + " un esi gan vecs - " + vecums); 
            Console.ReadLine();
        }
       
    }
    }

