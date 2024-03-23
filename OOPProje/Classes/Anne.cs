using OOPProje.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes
{
    //anne class'ı insan class'ından türemiştir 
    public class Anne : Insan, IOzellik, IOzellik2
    {
        public void dinle(string adi)
        {
            Console.WriteLine(adi + " dinliyor");
        }

        public void oku(string adi)
        {
            Console.WriteLine(adi + " okuyor");
        }

        public void yaz(string adi)
        {
            Console.WriteLine(adi + " yazıyor");
        }
    }
}
