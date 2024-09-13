// See https://aka.ms/new-console-template for more information


//Kullanıcının sisteme giriş yapması isteniyor.
//User -> FirstName, LastName, FullName, UserName, Email, Password

//FirstName ve LastName minimum 2 haneli olmalıdır.
//Password minimum 6 haneli olmalıdır.
//Email @gmail.com ile bitmelidir.

using Encapsulation;

User user = new User()
{
    FirstName = "Ali",
    LastName = "Veli",
    UserName = "aliveli",
    Email = "aliveli@gmail.com",
    Password = "123456"
};

Console.WriteLine(user);


//Kitap -> Başlığı, Açıklaması, Yazar Adı, Yazar Soyadı, Yayinevi, Basım Yılı
//Yazar tam adı ve (Yayınevi, Basım Yılı) şeklinde yazdırılacak.

Kitap kitap = new Kitap()
{
    Baslik = "Suç ve Ceza",
    Aciklama = "Dostoyevski'nin en iyi romanı",
    YazarAdi = "Dostoyevski",
    YazarSoyadi = "Fyodor",
    Yayinevi = "İş Bankası",
    BasimYili = 1866
};

Console.WriteLine(kitap);