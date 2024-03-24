using OOPProje.Classes.Constructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Contructors2
{
    public class Kasasi
    {
        public Marka marka;
        public Model model;
        public KapiSayisi kapi;
        public PencereSayisi pencere;
        public string kasaTipi;

        public Kasasi(Marka marka, Model model, KapiSayisi kapi, PencereSayisi pencere, string kasaTipi)
        {
            this.marka = marka;
            this.model = model;
            this.kapi = kapi;
            this.pencere = pencere;
            this.kasaTipi = kasaTipi;
        }
    }
}
