using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Piemers();
            //Vecums();
            //Salidzinam();
            //Menesi();
            //Aprekini();
            //Minskaitli();
            Gradi();
            Console.ReadLine();
        }

        static void Gradi()
        {
            Console.Write("Ievadi gradus - ");
            int Skaitlis = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Ievadi kādā tie ir mērvienībā - ");
            string Mervieniba = Console.ReadLine();

            Console.Write("Kādā mērvienībā gribi pārvēst K, C vai F?  ");
            string Parvertiba = Console.ReadLine();

            if (Mervieniba == "C" && Parvertiba == "K")
            {
                int Kelvins = Skaitlis + 273;
                Console.Write("Jaunie Kelvini ir " + Kelvins);
            }
            else if (Mervieniba == "C" && Parvertiba == "F")
            {
                float Farei = 1.8F * Skaitlis + 32;

                Console.Write("Jaunie Fareinheiti ir " + Farei);
            }
            else if (Mervieniba == "F" && Parvertiba == "C")
            {
                int Celsijs = ((Skaitlis - 32) * 5) / 9;

                Console.Write("Jaunie Celsiji ir " + Celsijs);
            }
            else if (Mervieniba == "F" && Parvertiba == "K")
            {
                int Kelvins2 = (((Skaitlis - 32) * 5) / 9) + 273;

                Console.Write("Jaunie Kelvini ir " + Kelvins2);
            }
            else if (Mervieniba == "K" && Parvertiba == "C")
            {
                int Celsijs2 = Skaitlis - 273;

                Console.Write("Jaunie Celsiji ir " + Celsijs2);
            }
            else
            {
                float Farei2 = 1.8F * (Skaitlis - 273) + 32;
                Console.Write("Jaunie Fareinheiti ir " + Farei2);
            }
        }

        static void Minskaitli()
        {
            Console.Write("Ievadi pirmo veselo skaitli -     ");
            int Pirmais = Convert.ToInt32(Console.ReadLine());

            Console.Write("norādi darbību - +, -, * vai /?     ");
            string Darbiba = Console.ReadLine().ToLower();

            Console.Write("Ievadi otro veselo skaitli -     ");
            int Otrais = Convert.ToInt32(Console.ReadLine());
            
            if (Darbiba == "+")
            {
                int sum = Pirmais + Otrais;
                Console.WriteLine("Summa ir - " + sum);
            }

            else if (Darbiba == "-")
            {
                int star = Pirmais - Otrais;
                Console.WriteLine("Starpiba ir - " + star);
            }

            else if (Darbiba == "*")
            {
                int reiz = Pirmais * Otrais;
                Console.WriteLine("Reizinajums ir - " + reiz);
            }
            else
            {
                float dal = (float)Pirmais / Otrais;
                Console.WriteLine("Dalijums ir - " + dal);
            }

        }


        static void Aprekini()
        {
            Console.Write("Ievadi attalumu metros - ");
            int Att = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi pilnas stundas - ");
            int Stu = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi pilnas minutes - ");
            int Min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi sekundes - ");
            int Sec = Convert.ToInt32(Console.ReadLine());

            int SSec = Stu * 60 * 60;
            int MSec = Min * 60;
            int JSec = SSec + MSec + Sec;

            Console.WriteLine("Pilnais laiks sekundes ir - " + JSec);

            int Atrums = Att / JSec;

            Console.WriteLine("Atrums ir " + Atrums + " m/s");

            int KmAtrums = ((Att / 1000) / (JSec / 3600));
            Console.WriteLine("Atrums ir " + KmAtrums + " km/h");

            int Kmattalums = Att / 1000;
            Console.WriteLine("Attalums ir " + Kmattalums + " km");

            float Judzes = Kmattalums * 0.621371F;
            Console.WriteLine("Judzes attalums ir " + Judzes);
        }

        static void Menesi()
        {
            Console.Write("Ievadi menesa pirmos 3 burtus - ");
            string Men = Console.ReadLine().ToUpper(); 

            if (Men == "FEB")
            {
                Console.Write("Februaris 28");
            }
            else if (Men == "APR" || Men == "JUN"|| Men == "SEP"|| Men == "NOV")
            {
                Console.Write("30 dienas");
            }

            else
            {
                Console.Write("31 diena");
            }
        }


        static void Vecums()
        {
            Console.Write("ievadi vecumu");
            int skaitlisO = Convert.ToInt32(Console.ReadLine());
            if (skaitlisO > 18)
            {
                Console.Write("tu esi pilngadigs");
            }
            else if (skaitlisO == 18)
            {
                Console.Write("Tu esi pilngadigs");
            }
            else
            {
                Console.Write("nenessi pilgadigs");
            }
        }

        static void Salidzinam()
        {
            Console.Write("Ievadi pirmo skaitli - ");
            int SkaitlisV = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi otro skaitli - ");
            int SkaitlisD = Convert.ToInt32(Console.ReadLine());

            if (SkaitlisV == SkaitlisD)
            {
                Console.Write("abi vienadi");
            }
            else if (SkaitlisV > SkaitlisD)
            {
                Console.Write("Pirmais skaitlis lielaks");
            }
            else
            {
                Console.Write("Otrais lielāks");
            }
        }

        static void Piemers()
        {
            int skaitlis = AtgriezSkaitli(); 
            if (skaitlis > 10)
            {
                Console.Write("skaitlis ir lielaks par 10");
            }
            else if (skaitlis == 10)
            {
                Console.Write("Skaitlis vienads ar 10");
            }
            else if (skaitlis == 11)
            {
                Console.Write("skaitlis vienads ar 11"); 
            }

            else
            {
                Console.Write("Skaitlis ir mazaks par 10");
            }

        }

        static int AtgriezSkaitli()
        {
            return 5;
        }


    }
}
