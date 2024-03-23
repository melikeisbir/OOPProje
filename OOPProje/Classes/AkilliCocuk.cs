using OOPProje.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes
{
    public class AkilliCocuk : Cocuk, IOzellik3, IOzellik4
    {
        public void asker(string adi)
        {
            Console.WriteLine(adi + " askere gidiyor");
        }

        public void ehliyet(string adi)
        {
            Console.WriteLine(adi + " ehliyet alıyor");
        }

        public void kulup(string adi)
        {
            Console.WriteLine(adi + " kulübe gidiyor");
        }
    }
}
