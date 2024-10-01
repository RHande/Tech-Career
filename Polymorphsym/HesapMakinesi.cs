namespace Polymorphsym;

public class HesapMakinesi
{
    public static void Topla(int sayi1, int sayi2)
    {
        Console.WriteLine($"{sayi1} + {sayi2} = {sayi1 + sayi2}");
    }
    //Birden fazla kez aynı farklı parametreli aynı metot oluşturulabilir. Static polimorfizm örneğidir.
    public static void Topla(int sayi1, int sayi2, int sayi3)
    {
        Console.WriteLine($"{sayi1} + {sayi2} + {sayi3} = {sayi1 + sayi2 + sayi3}");
    }
    
    public static void Topla(params int [] sayilar)
    {
        int toplam = 0;
        Array.ForEach(sayilar, sayi => toplam += sayi);
        Console.WriteLine($"Toplam: {toplam}");
    }
    //Aynısını listeler ile de yapabiliriz:
    public static void Topla(List<int> sayilar)
    {
        int toplam = 0;
        sayilar.ForEach(sayi => toplam += sayi);
        Console.WriteLine($"Toplam: {toplam}");
    }
    
}