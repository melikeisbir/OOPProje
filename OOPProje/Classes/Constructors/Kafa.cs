using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Constructors
{
    public class Kafa
    {
        //composition, bir class baska bir class tipindeki değişkeni kullanabilir
        public Goz goz;
        public Kulak kulak;
        public Burun burun;
        public Kafa(Goz goz, Kulak kulak, Burun burun)
        {
            this.goz = goz;
            this.kulak = kulak;
            this.burun = burun;
        }
    }
}
