using OOPProje.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes
{
    public class HiperaktifCocuk : Cocuk, IOzellik4
    {
        public void kulup(string adi)
        {
            Console.WriteLine(adi + " kulübe gidiyor");
        }
    }
}
