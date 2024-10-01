// See https://aka.ms/new-console-template for more information

using Company.Models;

BaseEmployee yazilimci = new ProgrammerEmployee()
{
    FirstName = "Ahmet",
    LastName = "Yılmaz",
    Age = 25,
    Salary = 5000,
    ProgrammingLanguages = new string[] {"C#", "Java", "Python"}
};

BaseEmployee yonetici = new ManagerEmployee()
{
    FirstName = "Mehmet",
    LastName = "Yılmaz",
    Age = 35,
    Salary = 10000,
    TeamCount = 10
};

yazilimci.BilgiVer();
yonetici.BilgiVer();

yazilimci.ProgDilleri();
yonetici.ProgDilleri();

yazilimci.ZamYap(10);
yonetici.ZamYap(20);