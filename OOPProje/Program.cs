// See https://aka.ms/new-console-template for more information

using OOPProje.Classes;
using OOPProje.Classes.Abstract2;
using OOPProje.Classes.Abstracts;
using OOPProje.Classes.Constructors;
using OOPProje.Classes.Contructors2;
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
an.adi ="çiçek";
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


Bmw bmw= new Bmw();
bmw.markaModelYaz("Bmw", "X5");


Porsche p = new Porsche();
p.markaModelYaz("Porsche", "Carrera");

p.havadaUcuyor("Porsche");
m.cokHizliGidiyor("Mercedes");
m.denizdeYuzuyor("Mercedes");
bmw.cokHizliGidiyor("Bmw");
bmw.havadaUcuyor("Bmw");
bmw.denizdeYuzuyor("Bmw");

Console.WriteLine("---");

Matematik mat = new Matematik();
//1. yöntem
int gelenDeger = mat.Topla(5, 5);
Console.WriteLine("Toplam: " + gelenDeger);

//2. yöntem
Console.WriteLine("Toplam2 : " + mat.Topla(15,15));

Console.WriteLine("Çıkar: " + mat.Cikar(45, 25));

Console.WriteLine("Yaşınız: " + i.yasiniz(2001));

Console.WriteLine("------");

int gelenYas = i.yasiniz(2001);
Console.WriteLine("Yaşınız: " + i.yasiniz(2001));
Console.WriteLine(i.yasHesap(gelenYas));

//Calisan calisan = new Calisan();

GenelMudur gm = new GenelMudur();
Mudur mud =  new Mudur();
Programci prog = new Programci();
Stajyer staj = new Stajyer();

double toplamMaas = 0.0;
toplamMaas += gm.maasinizNedir();
toplamMaas += mud.maasinizNedir();
toplamMaas += prog.maasinizNedir();
toplamMaas += staj.maasinizNedir();
Console.WriteLine("Toplam maaş: " + toplamMaas);

Console.WriteLine("------");

CarPorsche pr= new CarPorsche();
CarMercedes mr= new CarMercedes();
CarBmw bm = new CarBmw();

double toplamLitre = 0.0;
toplamLitre += pr.litreNedir();
toplamLitre += mr.litreNedir();
toplamLitre += bm.litreNedir();
Console.WriteLine("Harcanan toplam benzin: " + toplamLitre);

Console.WriteLine("------");


new Insan("hakan", "yilmaz"); //constructor nesne
//Insan i2 = new Insan("hakan", "yılmaz");
new Insan("metin", "yılmaz", 33, 3.14, true);



Goz goz = new Goz("mavi ");
Kulak kulak = new Kulak("geniş ");
Burun burun = new Burun("hokka ");
Kafa kafa = new Kafa(goz, kulak , burun);
YeniInsan yeni = new YeniInsan(kafa, "mel ", "isb ");
yeni.ekranaYaz();

Console.WriteLine("------");


Marka marka = new Marka("Bmw ");
Model model = new Model("X5 ");
KapiSayisi kapisayisi = new KapiSayisi(4);
PencereSayisi penceresayisi = new PencereSayisi(4);
Kasasi kasa = new Kasasi(marka, model, kapisayisi, penceresayisi, " sedan ");
YeniAraba yeniaraba = new YeniAraba(kasa, 2000000.0);
yeniaraba.ekranaYazdir();

