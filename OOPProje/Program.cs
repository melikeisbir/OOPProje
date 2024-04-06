// See https://aka.ms/new-console-template for more information

using OOPProje.Classes;
using OOPProje.Classes.Abstract2;
using OOPProje.Classes.Abstract3;
using OOPProje.Classes.Abstracts;
using OOPProje.Classes.Collections;
using OOPProje.Classes.Constructor3;
using OOPProje.Classes.Constructors;
using OOPProje.Classes.Contructors2;
using OOPProje.Classes.Overrides;
using OOPProje.Classes.Solid.OdemeYontemiIyi;
using OOPProje.Classes.Solid.OdemeYontemiKotu;
using OOPProje.Classes.Solid.OpenClosedIyi;
using OOPProje.Classes.Solid.OpenClosedKotu;
using System.Collections;
using System.Diagnostics;

Console.WriteLine("Hello, World!");
//ClassIsmi nesneadi = new ClassIsmi();


Insan.boy = 180; //static değişken
//Insan.uyu();
Insan i = new Insan();
i.adi = "melike";
i.soyadi = "isbir";
i.yas = 23;
i.maas = 3.14;
i.cinsiyet = true;
i.uyu(i.adi, i.soyadi);
i.uyu("meli", "isbir");


Araba a = new Araba();
a.marka = "Mercedes";
a.model = "C-Serisi Estate";
a.adet = 5;
a.car("mercedes", "g-serisi");
a.car(a.marka, a.model);


Anne an = new Anne();
an.adi = "çiçek";
an.soyadi = "isb";
an.yas = 47;
an.maas = 3.14;
an.cinsiyet = true;
an.ekranaYaz(an.adi, an.soyadi);
an.oku(an.adi);
an.dinle(an.adi);
an.yaz(an.adi);

Baba b = new Baba();
b.adi = "reis";
b.soyadi = "isb";
b.yas = 54;
b.maas = 3.14;
b.cinsiyet = true;
b.ekranaYaz(b.adi, b.soyadi);
b.oku(b.adi);

Cocuk c = new Cocuk();
c.adi = "mel";
c.soyadi = "isb";
c.yas = 23;
c.maas = 3.14;
c.cinsiyet = true;
c.ekranaYaz("mel", "isb");

AkilliCocuk ak = new AkilliCocuk();
ak.adi = "Hakan";
ak.soyadi = "Yılmaz";
ak.sifat = "Akıllıdır";
ak.kids(ak.adi, ak.soyadi, ak.sifat);
ak.kulup(ak.adi);
ak.asker(ak.adi);
ak.ehliyet(ak.adi);


UsluCocuk us = new UsluCocuk();
us.adi = "Mehmet";
us.soyadi = "Yıldız";
us.sifat = "Usludur";
us.kids("Mehmet", "Yıldız", "Usludur");
us.asker(us.adi);
us.ehliyet(us.adi);

HiperaktifCocuk hp = new HiperaktifCocuk();
hp.kulup("huseyin");

Mercedes m = new Mercedes();
m.markaModelYaz("Mercedes", "XL");


Bmw bmw = new Bmw();
bmw.markaModelYaz("Bmw", "X5");


Porsche p = new Porsche();
p.markaModelYaz("Porsche", "Carrera");

p.havadaUcuyor("Porsche");
m.cokHizliGidiyor("Mercedes");
m.denizdeYuzuyor("Mercedes");
bmw.cokHizliGidiyor("Bmw");
bmw.havadaUcuyor("Bmw");
bmw.denizdeYuzuyor("Bmw");

Console.WriteLine("--------------------");

Matematik mat = new Matematik();
//1. yöntem
int gelenDeger = mat.Topla(5, 5);
Console.WriteLine("Toplam: " + gelenDeger);

//2. yöntem
Console.WriteLine("Toplam2 : " + mat.Topla(15, 15));

Console.WriteLine("Çıkar: " + mat.Cikar(45, 25));

Console.WriteLine("Yaşınız: " + i.yasiniz(2001));

Console.WriteLine("--------------------");

int gelenYas = i.yasiniz(2001);
Console.WriteLine("Yaşınız: " + i.yasiniz(2001));
Console.WriteLine(i.yasHesap(gelenYas));

//Calisan calisan = new Calisan();

GenelMudur gm = new GenelMudur();
gm.adi = "hakan";
gm.soyadi = "yılmaz";
gm.departman = "genel müdür";
Mudur mud = new Mudur();
mud.adi = "metin";
mud.soyadi = "yıldız";
mud.departman = "müdür";
Programci prog = new Programci();
prog.adi = "meli";
prog.soyadi = "sbr";
prog.departman = "yazılım";
Stajyer staj = new Stajyer();
staj.adi = "necati";
staj.soyadi = "ateş";
staj.departman = "arge";

double toplamMaas = 0.0;
toplamMaas += gm.maasinizNedir();
toplamMaas += mud.maasinizNedir();
toplamMaas += prog.maasinizNedir();
toplamMaas += staj.maasinizNedir();
Console.WriteLine("Toplam maaş: " + toplamMaas);

Console.WriteLine("--------------------");

CarPorsche pr = new CarPorsche();
pr.markasi = "porsche";
pr.modeli = "carrera";
CarMercedes mr = new CarMercedes();
pr.markasi = "porsche";
pr.modeli = "xl";
CarBmw bm = new CarBmw();
bm.markasi = "bmw";
bm.modeli = "x5";

double toplamLitre = 0.0;
toplamLitre += pr.litreNedir();
toplamLitre += mr.litreNedir();
toplamLitre += bm.litreNedir();
Console.WriteLine("Harcanan toplam benzin: " + toplamLitre);

Console.WriteLine("--------------------");


new Insan("hakan", "yilmaz"); //constructor nesne
//Insan i2 = new Insan("hakan", "yılmaz");
new Insan("metin", "yılmaz", 33, 3.14, true);



Goz goz = new Goz("mavi ");
Kulak kulak = new Kulak("geniş ");
Burun burun = new Burun("hokka ");
Kafa kafa = new Kafa(goz, kulak, burun);
YeniInsan yeni = new YeniInsan(kafa, "mel ", "isb ");
yeni.ekranaYaz();

Console.WriteLine("--------------------");


Marka marka = new Marka("Bmw ");
Model model = new Model("X5 ");
KapiSayisi kapisayisi = new KapiSayisi(4);
PencereSayisi penceresayisi = new PencereSayisi(4);
Kasasi kasa = new Kasasi(marka, model, kapisayisi, penceresayisi, " sedan ");
YeniAraba yeniaraba = new YeniAraba(kasa, 2000000.0);
yeniaraba.ekranaYazdir();


Console.WriteLine("--------------------");


Cilek ck = new Cilek();
Kivi kv = new Kivi();
Muz mz = new Muz();
Incir nc = new Incir();

double toplamtutar = 0.0;
toplamtutar += ck.kasatutari();
toplamtutar += kv.kasatutari();
toplamtutar += mz.kasatutari();
toplamtutar += nc.kasatutari();
Console.WriteLine("Toplam kasa tutarı: " + toplamtutar);



Console.WriteLine("--------------------");

Kitap kitap = new Kitap(" ders kitabı");
Defter defter = new Defter(" küçük");
Kalem kalem = new Kalem(" çizim kalemi");
Silgi silgi = new Silgi(2);
Dosya dosyatipi = new Dosya(kitap, defter, kalem, silgi, " gözlü dosya ");
YeniCanta yenicanta = new YeniCanta(dosyatipi, 500.0);
yenicanta.bunuyazdir();



Console.WriteLine("--------------------");

for (int j = 0; j < 10; j++)
{
    Console.WriteLine("Merhaba Dünya");
}


Console.WriteLine("--------------------");

//Aynı türden verileri bir isim altında saklmamızı sağlar.

//1. yöntem
string[] gunler = new string[7];
gunler[0] = "pzt";
gunler[1] = "salı";
gunler[2] = "çrş";
gunler[3] = "prş";
gunler[4] = "cuma";
gunler[5] = "cmt";
gunler[6] = "pzr";

for (int k = 0; k < gunler.Length; k++)
{
    Console.WriteLine(gunler[k]);
}


Console.WriteLine("--------------------");


//2. yöntem
int[] sayilar = { 3, 4, 6, 7, 9, 11, 12, 22, 33, 44, 55, 77, 99, 100, 105 };
int toplam = 0;
for (int z = 0; z < sayilar.Length; z++)
{
    toplam = toplam + sayilar[z];
    // toplam += sayilar[z];
}
Console.WriteLine("Sayıların toplamı: " + toplam);


Console.WriteLine("--------------------");


Calisan[] calisanlar = { gm, mud, prog, staj };
double toplamMaas2 = 0;
for (int o = 0; o < calisanlar.Length; o++)
{
    toplamMaas2 += calisanlar[o].maasinizNedir();
    Console.WriteLine("Çalışanın adı: " + calisanlar[o].adi + " soyadı: " + calisanlar[o].soyadi + " departmanı: " + calisanlar[o].departman);
}
Console.WriteLine("Toplam maaş: " + toplamMaas2);

//foreach(Calisan ca in calisanlar)
//{
//    Console.WriteLine(ca);
//}


Console.WriteLine("--------------------");


Arabalar[] arabalar = { pr, mr, bm };
double toplamBenzin = 0;
for (int x = 0; x < arabalar.Length; x++)
{
    toplamBenzin += arabalar[x].litreNedir();
    Console.WriteLine("Arabanın markası: " + arabalar[x].markasi + " model: " + arabalar[x].modeli + " benzin: " + arabalar[x].litreNedir());
}
Console.WriteLine("Toplam benzin: " + toplamBenzin);


Console.WriteLine("--------------------");


string[] renkler = { "sarı", "kırmızı", "yeşil", "mavi", "beyaz" };
foreach (string r in renkler)
{
    Console.WriteLine(r);
}


Console.WriteLine("--------------------");


//generic liste
List<string> liste = new List<string>();
liste.Add("melike");
liste.Add("hakan");
liste.Add("mehmet");
liste.Add("hüseyin");
liste.Add("mert");
liste.Insert(0, "mert"); //en üste taşır

List<int> sayilar2 = new List<int>();
sayilar2.Add(33);
sayilar2.Add(44);

if (liste.Contains("berna"))
{
    Console.WriteLine("ilgili kişi listede var");
}
else
{
    Console.WriteLine("ilgili kişi listede yok");
}
Console.WriteLine("listede: " + liste.Count + " kişi var");

foreach (object ob in liste)
{
    Console.WriteLine(ob);
}

liste.Remove("melike");
liste.RemoveAt(0); //ilk sıradaki elemanı çıkar
Console.WriteLine("listede kalan kişi: " + liste.Count + " kişi var");
liste.Clear();


Console.WriteLine("--------------------");


List<Personel> personelListesi = new List<Personel>();
Personel p1 = new Personel("hakan", "yılmaz", 15000.0);
Personel p2 = new Personel("metin", "yıldız", 20000.0);
personelListesi.Add(p1);
personelListesi.Add(p2);
personelListesi.Add(new Personel("Ali", "Kaya", 30000.0));


Console.WriteLine("--------------------");



foreach (Personel personel in personelListesi)
{
    Console.WriteLine("Personelin adı: " + personel.Adi + " soyadı: " + personel.Soyadi + " maaşı: " + personel.Maas);
    toplamMaas += personel.Maas;
}
Console.WriteLine("Personellerin toplam maaşı: " + toplamMaas + " TL'dir");


Console.WriteLine("--------------------");


List<Arabalar> arabaListesi = new List<Arabalar>();
arabaListesi.Add(bm);
arabaListesi.Add(mr);
arabaListesi.Add(pr);

foreach (Arabalar ab in arabaListesi)
{
    Console.WriteLine("Arabanın markası: " + ab.markasi + " modeli: " + ab.modeli + " harcanan benzin: " + ab.litreNedir());
}



Console.WriteLine("--------------------");


DbLog dbLog = new DbLog();
XmlLog xmlLog = new XmlLog();
Logger logger = new Logger(dbLog, xmlLog);
logger.LogKayit(LogType.Xml, "303 nolu hata kodu oluştu");

Console.WriteLine("--------------------");


DbLogIyi dbLogIyi = new DbLogIyi();
XmlLogIyi xmlLogIyi = new XmlLogIyi();
TextLogIyi textLogIyi = new TextLogIyi();
LoggerIyi loggerIyi = new LoggerIyi(textLogIyi);
string gelenMesaj = loggerIyi.LogKayit("303 nolu hata kodu oluştu");
Console.WriteLine(gelenMesaj);


Console.WriteLine("--------------------");


KrediKarti krediKarti = new KrediKarti();
MailOrder mailOrder = new MailOrder();
OdemeIslemi odemeIslemi = new OdemeIslemi(krediKarti, mailOrder);
odemeIslemi.OdemeYap(OdemeType.MailOrder, 100);


Console.WriteLine("--------------------");


KrediKartiIyi krediKartiIyi = new KrediKartiIyi();
MailOrderIyi mailOrderIyi = new MailOrderIyi();
IyzicoOdemeIyi iyzicoOdemeIyi = new IyzicoOdemeIyi();
OdemeIslemiIyi odemeIslemiIyi = new OdemeIslemiIyi(iyzicoOdemeIyi);
string message = odemeIslemiIyi.OdemeYap(300);
Console.WriteLine(message);


Console.WriteLine("--------------------");


Child child = new Child();
child.Yaz();