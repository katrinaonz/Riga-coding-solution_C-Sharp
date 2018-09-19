using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{

    
    public class Auto

    {

        public string Krasa;

        public int MaxAtrums;

        public void Braukt()
        {
            Console.WriteLine("Auto Brauc! MaxAtrums = " + MaxAtrums);
        }

        public void KrasaNoteiksana()
        {
            Console.WriteLine("Auto ir " + Krasa + "krāsā!");
        }
    }
    
    
    
    

}
