namespace Company.Models;

public abstract class BaseEmployee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    
    public abstract void BilgiVer();
    
    public abstract void ProgDilleri();
    
    public abstract void ZamYap(int zamOrani);
}