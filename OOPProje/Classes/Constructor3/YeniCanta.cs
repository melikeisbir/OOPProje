using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Constructor3
{
    public class YeniCanta
    {
        public Dosya dosyatipi;
        public double fiyat;

        public YeniCanta(Dosya dosyatipi, double fiyat)
        {
            this.dosyatipi = dosyatipi;
            this.fiyat = fiyat;
        }

        public void bunuyazdir()
        {
            Console.WriteLine("Kitabın türü:" + dosyatipi.kitap.kitap + " defterin boyutu:" + dosyatipi.defter.defter +
                              " kalem tipi:" + dosyatipi.kalem.kalem + " silgi sayısı:" + dosyatipi.silgi.silgi +
                              " dosya tipi:" + dosyatipi.dosyatipi +
                              " çanta fiyatı:" + fiyat );
        }
    }
}
