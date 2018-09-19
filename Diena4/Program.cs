using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    class Program
    {
        static void Main(string[] args)
        {
            Objekts();
            Console.ReadLine();

        }
        static void Piemers ()
        {
            Auto auto1 = new Auto();
            auto1.MaxAtrums = 200;
            auto1.Krasa = "Melnā";
            auto1.Braukt();
            auto1.KrasaNoteiksana();

            Auto Auto2 = new Auto();
            Auto2.MaxAtrums = 150;
            Auto2.Krasa = "sarkans";
            Auto2.Braukt();
            Auto2.KrasaNoteiksana();
            
            kvadrats Kv2 = new kvadrats();
            Kv2.Krasa = "Zila";
            Kv2.MalasGarums = 5;
            Kv2.Perimetrs();
            Kv2.Laukums();
            Kv2.KKrasa();

            Console.ReadLine();
        }
        static void Taisnasturis()
        {
            Taisnsturis Ts = new Taisnsturis();
            Ts.MalasGarums1 = 5;
            Ts.MalasGarums2 = 6;
            Ts.Perimetrs();
            Ts.Laukums();
        }
        static void AplisStatic()
        {
            aplis Aplis2 = new aplis();
            Aplis2.Radiuss = 5;
            Aplis2.KrasasNosaukums = "Zils";
            Aplis2.Krasa();
            Aplis2.Perimetrs();
            Aplis2.Laukums();
        }
        static void TristurisStatic()
        {
            Tristuris Tristuris2 = new Tristuris();
            Tristuris2.MalasGarums1 = 5;
            Tristuris2.MalasGarums2 = 4;
            Tristuris2.MalasGarums3 = 7;
            Tristuris2.Perimetrs();
            Tristuris2.Laukums();
        }
        static void Objekts()
        {
            
            Telpa TelpaC = new Telpa();
            TelpaC.Numurs = 5;
            TelpaC.Stavs = 7;
            

            Skolens skolensC = new Skolens();
            skolensC.Vards = "Jānitis";
            skolensC.Uzvards = "Berzins";
            skolensC.Epasts = "JB@gmail.com";
            skolensC.DzGads = 1995;
            

            Skolotajs SkolotajsC = new Skolotajs();
            SkolotajsC.Vards = "Māra";
            SkolotajsC.Uzvards = "Vitola";
            SkolotajsC.Epasts = "MV@skola.com";
            

            Klase KlaseC = new Klase();
            KlaseC.KlaseString = "Matematika";
            KlaseC.SkolenuSk = 30;

            MacibuPrieksmets MPC = new MacibuPrieksmets();
            MPC.Nosaukums = "vesture";

            Vertejums VertejumsC = new Vertejums();
            VertejumsC.Atzime = 10;
            VertejumsC.VertejumsD();
            
                        
        }
    }
}
