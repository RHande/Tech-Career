// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
string name = "Hande";
string soyad = "Özensel";
Console.WriteLine(name + " " + soyad);
Console.WriteLine($"My name is {name}");

//int: This is a type of data which for number.

int sayi1 = 10;
int sayi2 = 20;
Console.WriteLine(sayi1 + sayi2);

//Değişkenin önüne _ kullanırsak, bu değişken private'dır.

string tam = name + " " + soyad;
Console.WriteLine(tam);

//String interpolation:
Console.WriteLine($"{sayi1} ile {sayi2} sayısının toplamı {sayi1 + sayi2}'dur");

int difference = sayi1 - sayi2;
int multiply = sayi1 * sayi2;
int divide = sayi1 / sayi2;
Console.WriteLine($"{sayi1}-{sayi2} = {difference}");
Console.WriteLine($"{sayi1}*{sayi2} = {multiply}");
Console.WriteLine($"{sayi1}/{sayi2} = {divide}");


/*
 Console.WriteLine("Lütfen 1. Sayıyı giriniz.");
int sayi3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen 2. Sayıyı giriniz.");
int sayi4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sayi3 + sayi4);
*/

//Bu şekilde yazıp çalıştırdığımda 1. Sayıyı giriniz dediği yere sayı girdiğimizde kendi kendine istediğimiz hesaplamayı yapıyor.

/*
Console.WriteLine("İsim: ");
string isim = Console.ReadLine();
Console.WriteLine("Soyisim: ");
string Soyisim = Console.ReadLine();
Console.WriteLine("Yaş: ");
int yas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Merhaba {isim} {Soyisim}, yaşınız {yas}'dır.");
*/

//double: Ondalıklı sayılar için kullanılır.
double num1 = 22;
double num2 = 3.14;
Console.WriteLine(num1/num2);

//bool: True veya false değerler alır.
int a = 5;
int b = 6;
bool sonuc = a > b;
Console.WriteLine(sonuc);//False


Console.WriteLine(4>=6);
Console.WriteLine(3!=3);
Console.WriteLine(3==4);


Console.WriteLine((3<5 || 5!=6) && 3!=0);

sonuc = (3 < 5 || 5 != 6) && 3 != 0;
Console.WriteLine(sonuc.GetType());//boolean

//Ternary operatör:
/*
 Console.WriteLine("Lütfen yaşınızı giriniz.");
int age = Convert.ToInt32(Console.ReadLine());
string ehliyet = age >= 18 ? "Ehliyet alabilir." : "Ehliyet alamaz.";
Console.WriteLine(ehliyet);
*/

//Kullanıcıdan bir sayı değeri alıp, eğer sayı 10'dan büyük eşitse çıktı olarak sayı 10'dan büyük eşittir dönsün.
//Aksi duruumda sayı 10'dan küçüktür ekran yazısını istiyoruz.

/*
Console.WriteLine("Lütfen bir sayı değeri giriniz");
int num = Convert.ToInt32(Console.ReadLine());
string kontrol = num > 10 ? "Sayı 10'dan büyüktür" : num == 10 ? "Sayı 10'dur" : "Sayı 10'dan küçüktür";
Console.WriteLine(kontrol);
*/

//Karar Mekanizmaları
//if-else

/*
Console.WriteLine("Lütfen bir sayı değeri giriniz");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 10)
{
 Console.WriteLine("Sayı 10'dan büyüktür");
}
if (num < 10)
{
 Console.WriteLine("Sayı 10'dan küçüktür");
}else
Console.WriteLine("Sayı 10'a eşittir.");
*/

//bir kod bloğunun içine return eklersek, ilk doğru olan if'i çalıştırır ve diğerlerine bakmaz.
//Ya da yukarıdaki gibi if ile devam etmek yerine de else if şeklinde yazdığımızda ilk doğru olanı yazdırır.


Console.WriteLine("Lütfen bir sayı değeri giriniz");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 10)
{
 Console.WriteLine("Sayı 10'dan büyüktür");
}
else if (num < 10)
{
 Console.WriteLine("Sayı 10'dan küçüktür");
}else
 Console.WriteLine("Sayı 10'a eşittir.");


//Switch-Case

Console.Write("Lütfen 1'den 4'e kadar bir sayı değeri giriniz: ");
int mevsim = Convert.ToInt32(Console.ReadLine());
switch (mevsim)
{
 case 1:
 Console.WriteLine("İlkbahar");
 break;
 case 2:
 Console.WriteLine("Yaz");
 break;
 case 3:
 Console.WriteLine("Sonbahar");
 break;
 case 4:
 Console.WriteLine("Kış");
 break;
 default:
 Console.WriteLine("Hatalı giriş yaptınız.");
 break;
}

//Yukarıdaki switch-case yapısını aşağıdaki gibi de yazabiliriz.
int deger = mevsim;
string mevsimAdi = deger switch
{
    1 => "İlkbahar",
    2 => "Yaz",
    3 => "Sonbahar",
    4 => "Kış",
    _ => "Hatalı giriş yaptınız."
};
Console.WriteLine(mevsimAdi);




//Basit bir hesap makinesi yapalım.
//+,/,*,-,% ve üs aşma işlemlerini yapabileceğimiz bir hesap makinesi yapalım.

Console.WriteLine("Lütfen 1. Sayıyı giriniz: ");
int say1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen 2. Sayıyı giriniz: ");
int say2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
Console.WriteLine("1-Toplama\n2-Çıkarma\n3-Çarpma\n4-Bölme\n5-Mod Alma\n6-Üs Alma");
int secim = Convert.ToInt32(Console.ReadLine());
switch (secim)
{
    case 1:
        Console.WriteLine($"{say1} + {say2} = {say1 + say2}");
        break;
    case 2:
        Console.WriteLine($"{say1} - {sayi2} = {say1 - say2}");
        break;
    case 3:
        Console.WriteLine($"{say1} * {say2} = {say1 * say2}");
        break;
    case 4:
        Console.WriteLine($"{say1} / {say2} = {say1 / say2}");
        break;
    case 5:
        Console.WriteLine($"{say1} % {say2} = {say1 % say2}");
        break;
    case 6:
        Console.WriteLine($"{say1} ^ {say2} = {Math.Pow(say1, say2)}");
        break;
    default:
        Console.WriteLine("Hatalı giriş yaptınız.");
        break;
}

//Aynı işlemi if-else yapısı ile de yapabiliriz.
Console.WriteLine("Lütfen 1. Sayıyı giriniz: ");
int sayii1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen 2. Sayıyı giriniz: ");
int sayii2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
Console.WriteLine("1-Toplama\n2-Çıkarma\n3-Çarpma\n4-Bölme\n5-Mod Alma\n6-Üs Alma");
int secimm = Convert.ToInt32(Console.ReadLine());
if (secimm == 1)
{
    Console.WriteLine($"{sayii1} + {sayii2} = {sayii1 + sayii2}");
}
else if (secimm == 2)
{
    Console.WriteLine($"{sayii1} - {sayii2} = {sayii1 - sayii2}");
}
else if (secimm == 3)
{
    Console.WriteLine($"{sayii1} * {sayii2} = {sayii1 * sayii2}");
}
else if (secimm == 4 && sayii2 != 0)
{
    Console.WriteLine($"{sayii1} / {sayii2} = {sayii1 / sayii2}");
}
else if (secimm == 5)
{
    Console.WriteLine($"{sayii1} % {sayii2} = {sayii1 % sayii2}");
}
else if (secimm == 6)
{
    Console.WriteLine($"{sayii1} ^ {sayii2} = {Math.Pow(sayii1, sayii2)}");
}
else
{
    Console.WriteLine("Hatalı giriş yaptınız.");
}

//Aynı işlemi farklı switch-case yapısı ile de yapabiliriz.
Console.WriteLine("Lütfen 1. Sayıyı giriniz: ");
int sayiii1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen 2. Sayıyı giriniz: ");
int sayiii2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
Console.WriteLine("1-Toplama\n2-Çıkarma\n3-Çarpma\n4-Bölme\n5-Mod Alma\n6-Üs Alma");
int secimmm = Convert.ToInt32(Console.ReadLine());
string sonucc = secimmm switch
{
    1 => $"{sayiii1} + {sayiii2} = {sayiii1 + sayiii2}",
    2 => $"{sayiii1} - {sayiii2} = {sayiii1 - sayiii2}",
    3 => $"{sayiii1} * {sayiii2} = {sayiii1 * sayiii2}",
    4 => $"{sayiii1} / {sayiii2} = {sayiii1 / sayiii2}",
    5 => $"{sayiii1} % {sayiii2} = {sayiii1 % sayiii2}",
    6 => $"{sayiii1} ^ {sayiii2} = {Math.Pow(sayiii1, sayiii2)}",
    _ => "Hatalı giriş yaptınız."
};
Console.WriteLine(sonucc);