using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes
{
    public class Matematik
    {
        //2 tane parametre alan ve geriye int tipinde deger dönen adı topla olan bir metod tanımı
        public int Topla(int sayi1, int sayi2)
        {
            int sonuc = 0;
            sonuc = sayi1 + sayi2;
            //return sayi1 + sayi2;
            return sonuc;
        }
        public int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
