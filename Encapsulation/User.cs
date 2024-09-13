using System.Security.AccessControl;

namespace Encapsulation;

public class User//internal olduğunda sadece aynı namespace içerisinde erişilebilir.
{
    private string firstname;
    private string email;
    private string fullname;


    public string FirstName
    {
        get => firstname;
        //Şu lekilde de yazabiliriz:
        /*get
        //{
        //    return firstname;
        }*/
        
        set 
        {
            if (value.Length >= 2)
            {
                firstname = value;
            }
            else
            {
                throw new Exception("FirstName minimum 2 haneli olmalıdır.");
            }
        }
        
    }
    public string LastName { get; init; }//init ile değeri değiştirilemez hale getirilir.

   public string FullName
{
    get => $"{FirstName} {LastName}";
    private set => fullname = value;//private set ile sadece bu sınıf içerisinde set edilebilir.
}
    public string UserName { get; set; }

    public string Email
    {
        get => email;
        
        set 
        {
            if (value.EndsWith("@gmail.com"))
            {
                email = value;
            }
            else
            {
                throw new Exception("Email @gmail.com ile bitmelidir.");
            }
        }
        
    }
    public string Password { get; set; }
    
    public override string ToString()
    {
        return $"FirstName: {FirstName}\nLastName: {LastName}\nFullName: {FullName}\nUserName: {UserName}\nEmail: {Email}\nPassword: {Password}";
    }
    
    
}

