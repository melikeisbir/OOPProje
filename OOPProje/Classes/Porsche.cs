using OOPProje.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes
{
    public class Porsche : Araba, IOzellik5
    {
        public void havadaUcuyor(string adi)
        {
            Console.WriteLine(adi + " havada uçuyor");
        }
    }
}
