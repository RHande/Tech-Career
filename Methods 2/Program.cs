// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Console.WriteLine(topla(25, 35, 55, 102));

int topla(params int[] sayilar)
{
    int toplam = 0;
    foreach (var sayi in sayilar)
    {
        toplam += sayi;
    }
    return toplam;
}

//Params keyword'ünü kullanarak çarpma işlemi yapınız.

Console.WriteLine(carpma(2, 3, 4, 5));

int carpma(params int[] sayilar)
{
    int carpim = 1;
    foreach (var sayi in sayilar)
    {
        carpim *= sayi;
    }
    return carpim;
}

//Params keyword'ünü kullanarak çıkarma işlemi yapınız.

Console.WriteLine(cikarma(100, 20, 80, 15));

int cikarma(params int [] rakamlar)
{
    int fark = rakamlar[0];
    for (int i = 1; i < rakamlar.Length; i++)
    {
        fark -= rakamlar[i];
    }
    return fark;//100-20-80-15 = -15 olarak çıkar. Yani sırayla çıkarma işlemi yapar.
}


// Params keyword'ünü kullanarak bölme işlemi yapınız.

Console.WriteLine(bolme(100, 2));

double bolme(params int[] sayilar)
{
    int bolum = sayilar[0];
    for (int i = 1; i < sayilar.Length; i++)
    {
        if (sayilar[i] == 0)
        {
            Console.WriteLine("Error: Division by zero");
            return double.NaN;
        }
        bolum /= sayilar[i];
    }
    return bolum;
}


Print(5, 3);
//Permutasyon ve Kombinasyon hesaplamalarını yapınız.
void Print(int sayi1, int sayi2)
{
    double permutasyon = Permutasyon(sayi1, sayi2);
    double kombinasyon = Kombinasyon(sayi1, sayi2);
    Ekran(sayi1, sayi2, permutasyon, kombinasyon);
}

void Ekran(int sayi1, int sayi2, double permutasyon, double kombinasyon)
{
    Console.WriteLine($"1. Sayı : {sayi1}");
    Console.WriteLine($"2. Sayı : {sayi2}");
    Console.WriteLine($"Permutasyon => P({sayi1},{sayi2}) : {permutasyon}");
    Console.WriteLine($"Kombinasyon => C({sayi1},{sayi2}) : {kombinasyon}");
}

double Permutasyon(int n, int r)
{
    return Faktoriyel(n) / Faktoriyel(n-r);
}

double Kombinasyon(int n, int r)
{
    return Faktoriyel(n) / (Faktoriyel(n - r) * Faktoriyel(r));
}

double Faktoriyel(int n)
{
    double result = 1;

    for (int i = 1; i<=n; i++)
    {
        result = result *i;
    }
    return result;
}



//Bölme işlemi yapınız. Bölüm ve kalanı geri döndürünüz.

int bolumSonuc;
int kalanSonuc;
Bolme(100, 3, out bolumSonuc, out kalanSonuc);
void Bolme(int bolunen, int bolen, out int bolum, out int kalan)
{
    bolum = bolunen / bolen;
    kalan = bolunen % bolen;
}
Console.WriteLine($"100/3 bölüm: {bolumSonuc} kalan: {kalanSonuc}");



string buyuk;
string kucuk;
Donustur("MerHaBa", out buyuk, out kucuk);
void Donustur(string metin, out string buyuk, out string kucuk)
{
    buyuk = metin.ToUpper();
    kucuk = metin.ToLower();
}
Console.WriteLine($"Büyük Harfli: {buyuk} Küçük Harfli: {kucuk}");


