using OOPProje.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes
{
    public class Mercedes : Araba, IOzellik6, IOzellik7
    {
        public void cokHizliGidiyor(string adi)
        {
            Console.WriteLine(adi + " çok hızlı gidiyor");
        }

        public void denizdeYuzuyor(string adi)
        {
            Console.WriteLine(adi + " denizde yüzüyor");
        }
    }
}
