using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Constructor3
{
    public class Dosya
    {
        public string dosyatipi;
        public Kitap kitap;
        public Silgi silgi;
        public Defter defter;
        public Kalem kalem;
        
        public Dosya(Kitap kitap, Defter defter, Kalem kalem, Silgi silgi, string dosyatipi)
        {
            this.kitap = kitap;
            this.silgi = silgi;
            this.defter = defter;
            this.kalem = kalem;
            this.dosyatipi = dosyatipi;
        }
    }
}
