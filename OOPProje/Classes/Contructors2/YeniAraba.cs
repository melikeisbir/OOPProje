using OOPProje.Classes.Constructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Contructors2
{
    public class YeniAraba
    {
        public Kasasi kasa;
        public double fiyat;

        public YeniAraba(Kasasi kasa, double fiyat)
        {
            this.kasa = kasa;
            this.fiyat = fiyat;
        }
        public void ekranaYazdir()
        {
            Console.WriteLine("Arabanın markası : " + kasa.marka.markasi + " modeli: " + kasa.model.modeli +
                                " kapı sayisi: " + kasa.kapi.kapiSayisi +
                                " pencere sayisi: " + kasa.pencere.pencereSayisi +
                                " kasası: " + kasa.kasaTipi +
                                " fiyatı: " + fiyat);
        }
    }
}