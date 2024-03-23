using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes
{
    public class Insan
    {//scope
        //access modifiers dataType değişken adı
        public string adi = null;
        public string soyadi;
        //tam sayısal
        public int yas = 0;
        public double maas = 0.0;
        //true ya da false
        public bool cinsiyet = false;

        //metotlar fiiller
        //geriye değer döndüren, geriye değer döndürmeyen
        public void uyu(string isim, string soyisim)
        {
            Console.WriteLine(isim + " " + soyisim + " uyuyor....");
        }
        public void ekranaYaz(string isim , string soyisim)
        {
            Console.WriteLine("kişinin adı " + " " + adi + " " + "kişinin soyadı " + " " + soyadi);
        }

    }
}