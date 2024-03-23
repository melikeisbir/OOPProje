using OOPProje.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes
{
    public class UsluCocuk : Cocuk, IOzellik3
    {
        public void asker(string adi)
        {
            Console.WriteLine(adi + " askere gidiyor");
        }

        public void ehliyet(string adi)
        {
            Console.WriteLine(adi + " ehliyet alıyor");
        }
    }
}
