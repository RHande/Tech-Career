namespace Company.Models;

public class ProgrammerEmployee : BaseEmployee
{
    public int Salary { get; set; }
    public string[] ProgrammingLanguages { get; set; }
    
    
    public override void BilgiVer()
    {
        Console.WriteLine($"Adı: {FirstName}\nSoyadı: {LastName}\nYaşı: {Age}\nMaaşı: {Salary}\nPrgramlama Dilleri: {string.Join(", ", ProgrammingLanguages)}");
    }
    
    public override void ProgDilleri()
    {
        Console.WriteLine("Programlama dilleri: " + string.Join(", ", ProgrammingLanguages));
    }
    
    public override void ZamYap(int zamOrani)
    {
        Salary += Salary * zamOrani / 100;
        Console.WriteLine($"Yapılan %{zamOrani} zam ile birlikte yeni maaşı: {Salary}");
    }
}