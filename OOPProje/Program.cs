// See https://aka.ms/new-console-template for more information

using OOPProje.Classes;
using System.Diagnostics;

Console.WriteLine("Hello, World!");
//ClassIsmi nesneadi = new ClassIsmi();
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