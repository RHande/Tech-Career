namespace Company.Models;

public class ManagerEmployee : BaseEmployee
{
    public int Salary { get; set; }
    public int TeamCount { get; set; }
    
    
    public override void BilgiVer()
    {
        Console.WriteLine($"Adı: {FirstName}\nSoyadı: {LastName}\nYaşı: {Age}\nMaaşı: {Salary}\nEkip Sayısı: {TeamCount}");
    }

    public override void ProgDilleri()
    {
        Console.WriteLine("Yönetici sınıfı için programlama dilleri bilgisi bulunmamaktadır.");
    }
    
    public override void ZamYap(int zamOrani)
    {
        Salary += Salary * zamOrani / 100;
        Console.WriteLine($"Yapılan %{zamOrani} zam ile birlikte yeni maaşı: {Salary}");
    }
}