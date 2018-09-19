using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena3
{
    public class Uzdevums
    {


        public static void Uzdevums1()
        {
            Console.Write("Kādai valstij vēlies uzzinat galvaspilsētu? ");
            string Valsts = Console.ReadLine().ToLower();


            switch (Valsts)
            {

                case "igaunija":
                    Console.Write("Tallina");
                    break;
                case "somija":
                    Console.Write("Helsinki");
                    break;
                case "ukraina":
                    Console.Write("Kijeva");
                    break;
                case "zviedrija":
                    Console.Write("Stokholma");
                    break;
                case "krievija":
                    Console.Write("Maskava");
                    break;
                default:
                    Console.Write("Nezinu tadu valsti");
                    break;
            }



        }
        public static void Uzdevums2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Uzdevums3()
        {
            Console.Write("Kāds ir tavs dzimšanas gads?   ");
            int Gads = Convert.ToInt32(Console.ReadLine());

            for (int i = Gads; i <= DateTime.Now.Year; i++)

            {
                Console.WriteLine(i);
            }
        }

        public static void Uzdevums4()
        {
            Console.Write("Cik reizes kapinasim kvadrātā?   ");
            int Skaits = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Skaits; i++)

            {
                int j = i * i;
                Console.WriteLine(j);
            }
        }
        public static void Uzdevums17()

        {
            Console.Write("Cik skaitlus vadīsi? ");
            int Reizes = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            int summa = 0;

            while (count <= Reizes)
            {
                Console.WriteLine("Ievadi savu skaitli - ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                summa += skaitlis;

                count++;
            }
            Console.WriteLine("summa ir " + summa);
            int videja = summa / (count - 1);
            Console.WriteLine("Videja ir " + videja);

        }

        public static void Uzdevums18()
        {
            Console.Write("Ievadi skaitli - ");
            int Skaitlis = Convert.ToInt32(Console.ReadLine());
            int count = 1;

            while (count <= Skaitlis) 
            {
                for (int i = 1; i < Skaitlis; i++)
                {
                    Console.Write("*");
                }
                                
                Console.WriteLine("*");
                count++;

            }

        }
        public static void Uzdevums19()
        {
            Console.Write("Ievadi skaitli - ");
            int Skaitlis = Convert.ToInt32(Console.ReadLine());           

            for (int i = 1; i <= Skaitlis; i++)
            {
                for (int j=1; j<i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(i);
            }
        }

        public static void Uzdevums20()
        {
            Console.Write("Ievadi skaitli - ");
            int Skaitlis = Convert.ToInt32(Console.ReadLine());
            int Rindas = (2 * Skaitlis) - 1;
            int Puse = Rindas / 2;
            
            for(int r=1; r<=Skaitlis; r++)
            {
                //tuksumus
                for (int a = 1; a <= Skaitlis - r; a++)
                {

                    Console.Write(" ");
                }
              //zvaigznes
                    for (int z=1; z<=2*r - 1; z++)
                    {
                        Console.Write("*");
                    }
                 
                Console.WriteLine();

            }

            for (int r=Skaitlis-1; r >=1; r--)
            {
                //tuksumus
                for (int a = 1; a <= Skaitlis - r; a++)
                {

                    Console.Write(" ");
                }
                //zvaigznes
                for (int z = 1; z <= 2 * r - 1; z++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }

            /*for (int p = Skaitlis - 1; p >= 1; p--)
            {
                for (int r = 1; r <= Skaitlis - p; r++)
                {
                    Console.Write(" ");
                    for (int t = 1; t <= 2 * r - 1; t++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            */


            // 2*N-1
        }
        public static void WhilePiemers()
        {
            // Gribam dabt skaitlus tik ilgi kamer ievada ievada -1

            int sk = 0;
            int summa = 0;
            while (sk != -1)
            {
                Console.Write("Skaitam skaitļus. Ievadi skaitli vai -1, lai beigtu fuknciju - ");
                sk = Convert.ToInt32(Console.ReadLine());
                if (sk != -1)
                {
                    summa += sk;
                }
                
            }
            Console.WriteLine(summa);

            int summa2 = 0;
            //for(;;) -- cikls kas stradas muzigi
            while (true)
            {
                Console.Write("Ievadi skaitlus - ");
                int sk2 = Convert.ToInt32(Console.ReadLine());
                if (sk2 == -1)
                {
                    break;
                }
                else
                {
                    summa2 += sk2;
                }
            }
            Console.WriteLine(summa2);
        }
    }

}





        

