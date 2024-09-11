// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");

String[] sehirler = { "Ankara", "İstanbul", "İzmir", "Kocaeli", "Sakarya" };
Console.WriteLine(sehirler[0]);
Console.WriteLine(sehirler[1]);
Console.WriteLine(sehirler[2]);
Console.WriteLine(sehirler[3]);
Console.WriteLine(sehirler[4]);

// Dizinin elemanlarını ekrana yazdıralım.
for (int i = 0; i < sehirler.Length; i++)
{
    Console.WriteLine(sehirler[i]);
}

// Dizinin elemanlarını ekrana yazdıralım. (Foreach)
foreach (var sehir in sehirler)
{
    Console.WriteLine(sehir);
}

//Ülkeler adında bir dizi oluşturup içine 5 tane eleman ekleyelim.
//2. Elemanı gösterelim.
//2. Indexteki elemanı gösterelim.
//for döngüsü ile tüm elemanları ekrana yazdıralım.
//foreach döngüsü ile tüm elemanları ekrana yazdıralım.

Console.WriteLine("************");
String[] ulkeler = { "Türkiye", "Almanya", "Fransa", "İtalya", "İspanya" };
Console.WriteLine(ulkeler[1]);
Console.WriteLine(ulkeler[2]);
Console.WriteLine(ulkeler.GetValue(2));

Console.WriteLine("************");
for (int i = 0; i < ulkeler.Length; i++)
{
    Console.WriteLine(ulkeler[i]);
}

Console.WriteLine("************");
foreach (var ulke in ulkeler)
{
    Console.WriteLine(ulke);
}

//Dizi elemanlarını sıralama
int[] numbers = { 9, 3, 5, 11, 2, 1, 4, 3, 7, 88, 100 };
Array.Sort(numbers);
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

//Dizi elemanlarını tersten sıralama
Array.Reverse(numbers);
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("************");
//Yukarıdaki numbers dizisinden 4'ten büyük olanları ekran çıktısı olarak verelim.
foreach (var number in numbers)
{
    if (number > 4)
    {
        Console.WriteLine(number);
    }
}

//lambda yapısı ile 4'ten büyük olanları yazdıralım.
/*
 var result = Array.FindAll(numbers, x => x > 4);//var yerine int[] de yazabiliriz.
foreach (var number in result)
{
    Console.WriteLine(number);
}
*/


//Şu şekilde de yazabiliriz:
int[] result = Array.FindAll(numbers, x => x > 4);//numbers dizisinden 4'ten büyük olanları result dizisine atar.
Array.ForEach(result, x => Console.WriteLine(x));//result dizisindeki elemanları yazdırır.
//İstersem bunları yazdırmadan result içindeki elemanları kullanabilirim. Bu durumda Array.ForEach(result, x => Console.WriteLine(x)); satırını silmem gerekir.
//Bu yaklaşım daha profesyonel bir yaklaşımdır.
/*
 Bunu şu şekilde de kısa yazabilirim:
    Array.ForEach(Array.FindAll(numbers, x => x > 4), x => Console.WriteLine(x));
 Sadece son satırını şöyle yazabilirim:
    Array.ForEach(result, x=> {
    if(x>4) 
    Console.WriteLine(x);
    });
 */

//Şehirler adında bir dizi oluşturunuz.
//İstanbul, Malatya, Ankara, Eskişehir, Nevşehir, Erzurum
//Bu şehirlerin içinde 'a' harfi olanları ekrana yazdırınız.

String[] sehirler2 = { "İstanbul", "Malatya", "Ankara", "Eskişehir", "Nevşehir", "Erzurum" };
foreach (var sehir in sehirler2)
{
    if (sehir.Contains("a", StringComparison.InvariantCultureIgnoreCase))//Büyük küçük harf duyarlılığı olmadan arama yapar.
    {
        Console.WriteLine(sehir);
    }
}

string[] aHarfiOlanlar = Array.FindAll(sehirler2, x => x.Contains("a"));
Array.ForEach(aHarfiOlanlar, x => Console.WriteLine(x));

//Yukarıdaki işlemi tek satırda yapabiliriz.
Array.ForEach(Array.FindAll(aHarfiOlanlar, x => x.Contains("a")), x => Console.WriteLine(x));



int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] tekSayilar = Array.FindAll(sayilar, x => x % 2 != 0);
int[] ciftSayilar = Array.FindAll(sayilar, x => x % 2 == 0);
Array.ForEach(tekSayilar, x => Console.WriteLine(x));
Array.ForEach(ciftSayilar, x => Console.WriteLine(x));

Console.Write("Çift Sayılar: ");
Array.ForEach(Array.FindAll(sayilar, x => x%2==0), x => Console.Write(x));
Console.WriteLine();
Console.Write("Tek Sayılar: ");
Array.ForEach(Array.FindAll(sayilar, x => x%2!=0), x => Console.Write(x));
Console.WriteLine();

//Dizinin elemanlarını ekrana yazdıralım. (While)
Console.WriteLine("While Döngüsü: ");
int a = 0;
while (a < sayilar.Length)
{
    Console.WriteLine(sayilar[a]);
    a++;
}

//Dizinin elemanlarını ekrana yazdıralım. (Do While)
Console.WriteLine("Do While Döngüsü: ");
int b = 0;
do
{
    Console.WriteLine(sayilar[b]);
    b++;
} while (b < sayilar.Length);



//Ödev
Console.WriteLine("Bakiyeniz 35000 TL'dir");
string[] urunler = { "Bilgisayar", "Telefon", "Klavye" };
int[] fiyatlar = { 10000, 5000, 1500 };
int bakiye = 35000, toplamFiyat = 0;
   
Console.WriteLine("Alabileceğiniz ürünler ve fiyatları aşağıdaki gibidir:");
   for (int i = 0; i < urunler.Length; i++)
       Console.WriteLine($"{urunler[i]} : {fiyatlar[i]}");
   
   for (int i = 0; i < urunler.Length; i++)
   {
       Console.Write($"{urunler[i]} adedini giriniz: ");
       int urunAdet = Convert.ToInt32(Console.ReadLine());
       toplamFiyat += urunAdet * fiyatlar[i];
   }
   
   if (toplamFiyat > 35000)
       Console.WriteLine("Yetersiz Bakiye");
   else
   {
       int indirimliFiyat = toplamFiyat > 30000 ? toplamFiyat * 70 / 100 :
                            toplamFiyat > 20000 ? toplamFiyat * 80 / 100 : toplamFiyat;
       Console.WriteLine($"İndirimli Fiyat: {indirimliFiyat}");
       Console.WriteLine($"İndirimsiz Fiyat: {toplamFiyat}");
   }


/*
Console.Write("Bakiyeniz 35000 TL'dir");
string[] urunler = { "Bilgisayar", "Telefon", "Klavye"};
int[] fiyatlar = { 10000, 5000, 1500 };
int bakiye = 35000;
int urunAdet = 0;
int toplamFiyat = 0;
int indirimliFiyat = 0;
int indirimsizFiyat = 0;
Console.WriteLine("Alabileceğiniz ürünler ve fiyatları aşağıdaki gibidir:");
Array.ForEach(urunler, x => Console.WriteLine($"{x} : {fiyatlar[Array.IndexOf(urunler, x)]}"));
Console.WriteLine();
Array.ForEach(urunler, x =>
{
    Console.Write($"{urunler[Array.IndexOf(urunler, x)]} adedini giriniz: ");
    urunAdet = Convert.ToInt32(Console.ReadLine());
    toplamFiyat += urunAdet * fiyatlar[Array.IndexOf(urunler, x)];

});
if (toplamFiyat > 20000 && toplamFiyat < 30000)
{
    indirimliFiyat = toplamFiyat - (toplamFiyat * 20 / 100);
    indirimsizFiyat = toplamFiyat;
    Console.WriteLine($"İndirimli Fiyat: {indirimliFiyat}");
    Console.WriteLine($"İndirimsiz Fiyat: {indirimsizFiyat}");
}
else if (toplamFiyat > 30000 && toplamFiyat < 35000)
{
    indirimliFiyat = toplamFiyat - (toplamFiyat * 30 / 100);
    indirimsizFiyat = toplamFiyat;
    Console.WriteLine($"İndirimli Fiyat: {indirimliFiyat}");
    Console.WriteLine($"İndirimsiz Fiyat: {indirimsizFiyat}");
}
else if (toplamFiyat > 35000)
{
    Console.WriteLine("Yetersiz Bakiye");
}
else
{
    Console.WriteLine($"İndirimli Fiyat: {toplamFiyat}");
    Console.WriteLine($"İndirimsiz Fiyat: {toplamFiyat}");
}
*/





 