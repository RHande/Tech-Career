// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
for (int i = 0; i < 100; i++)
{
    Console.WriteLine(i);
}

//1'den 20'ye kadar tüm sayıları ekrana yazdırınız.
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}


//1'den 20'ye kadar tüm sayıların toplamını ekrana yazdırınız.
int toplam = 0;
for (int i = 1; i <= 20; i++)
{
    toplam += i;
}
Console.WriteLine("Toplam: " + toplam);


//1'den 20'ye kadar olan tüm çift ve tek sayıları ekrana yazdırınız.
for (int i = 0; i <= 20; i+=2)
{
    Console.WriteLine("Çift sayı: " + i);
    Console.WriteLine("Tek sayı: " + (i + 1));
}

//Bunu yaparken if kullanarak yapabiliriz.
for (int i = 0; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine("Çift sayı: " + i);
    }
    else
    {
        Console.WriteLine("Tek sayı: " + i);
    }
}




Console.WriteLine("Lütfen bilgilerini gireceğiniz kişi sayısını giriniz: ");
int kisiSayisi = int.Parse(Console.ReadLine());
int yas = 0;
string isim = "";
string soyisim = "";

string [] kisiBilgileri = new string[kisiSayisi];
for (int i = 0; i < kisiSayisi; i++)
{
    Console.WriteLine((i +1) + ". Kişinin ismini giriniz: ");
    isim = Console.ReadLine();
    Console.WriteLine((i +1) + ". Kişinin soyismini giriniz: ");
    soyisim = Console.ReadLine();
    Console.WriteLine((i +1) + ". Kişinin yaşını giriniz: ");
    yas = int.Parse(Console.ReadLine());
    kisiBilgileri[i] = $"{i +1}. Kişinin Adı: {isim}, Soyadı: {soyisim}, Yaşı: {yas}";
}

foreach (var item in kisiBilgileri)
{
    Console.WriteLine(item);
}