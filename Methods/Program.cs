// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//Metotlar

int[] sayilar2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int sonuc = sayilar2.Max();
Console.WriteLine(sonuc);

//Değer döndürmeyen metotlar

sayHello();//Metot çağrısı
void sayHello()//Metot tanımı
{
    Console.WriteLine("Hello Word!");
}


info("Hande", 32);
void info(string name, int age)
{
    Console.WriteLine($"Merhaba {name}, {age} yaşındasınız.");
}




//Değer döndüren metotlar
int topla(int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}
topla(25, 35);//Bu şekilde yazdığımızda değeri ekrana yazdırmaz. Çünkü değeri ekrana yazdırmak için bir değişkene atamamız gerekir.
int toplam = topla(25, 35);
Console.WriteLine(toplam);//60 - Bu şekilde yazdığımızda değeri ekrana yazdırır.


//Solid prensipleri - open closed principle
void printResult(int a, int b)
{
    int result = topla(a, b);
    ekranaYazdir(a,b,result);
}
printResult(3, 4);//Sonuç: 7

void ekranaYazdir(int sayi1, int sayi2, int result)
{
    Console.WriteLine($"{sayi1} + {sayi2} = {result}");
}
//Yukarıdaki kod bloğunda printResult metodu içerisinde topla ve ekranaYazdir metotları çağrılmıştır. Bu sayede printResult metodu içerisindeki işlemler değiştiğinde topla ve ekranaYazdir metotlarına dokunulmadan işlem gerçekleştirilebilir. Bu sayede open closed prensibi sağlanmış olur.

Console.WriteLine();

//Kullanıcıdan 3 tane sınav notu alınız. Bu sınav notunun ortalamasını ekrana yazdıran fonksiyonu yazınız.

int[] notlar = new int[3];
for (int i = 0; i < 3; i++)
{
    Console.Write($"{i + 1}. notu giriniz: ");
    notlar[i] = int.Parse(Console.ReadLine());
}

double ortalama (int[] notlar)
{
    int toplam = 0;
    foreach (var not in notlar)
    {
        toplam += not;
    }
    return toplam / notlar.Length;
}

void ortalamaYazdir(int[] notlar)
{
    double result = ortalama(notlar);
    yazdir(notlar, result);
}
ortalamaYazdir(notlar);

void yazdir(int[] notlar, double result)
{
    Console.WriteLine($"Not Ortalamanız: {result}");
}

/*
Console.WriteLine("1. notu giriniz: ");
int not1 = int.Parse(Console.ReadLine());
Console.WriteLine("2. notu giriniz: ");
int not2 = int.Parse(Console.ReadLine());
Console.WriteLine("3. notu giriniz: ");
int not3 = int.Parse(Console.ReadLine());

void point(int not1, int not2, int not3)
{
    double ortalama = (not1 + not2 + not3) / 3;
    ShowToAverage(not1,not2,not3,ortalama);
}

double ortlamaHesapla(int not1, int not2, int not3)
{    
    double ortalama = (not1 + not2 + not3) / 3;
    return ortalama;
}
point(not1, not2, not3);

void ShowToAverage(int not1, int not2, int not3, double ortalama)
{
    Console.WriteLine($"Girilen notlar: {not1}, {not2}, {not3}");
    Console.WriteLine($"Ortalama: {ortalama}");
}
*/



