// See https://aka.ms/new-console-template for more information


Cars car1 = new Cars();
car1.Marka = "BMW";
car1.Model = "M3";
car1.MotorGucu = 450;
car1.Renk = "Siyah";
car1.VitesTipi = "Otomatik";

Cars car2 = new Cars();
car2.Marka = "Mercedes";
car2.Model = "C180";
car2.MotorGucu = 200;
car2.Renk = "Beyaz";
car2.VitesTipi = "Manuel";

Cars car3 = new Cars();
car3.Marka = "Audi";
car3.Model = "A3";
car3.MotorGucu = 250;
car3.Renk = "Gri";
car3.VitesTipi = "Otomatik";

Cars car4 = new Cars()
{
    Marka = "Toyota",
    Model = "Corolla",
    MotorGucu = 150,
    Renk = "Beyaz",
    VitesTipi = "Otomatik"
};

car1.ekranaYazdir();
car2.ekranaYazdir();
car3.ekranaYazdir();
car4.ekranaYazdir();
Console.WriteLine("Car 5: ");



Cars car5 = new Cars("Renault", "Clio", 100, "Siyah", "Manuel");
Cars car6 = new Cars("Renault", "Clio", 100, "Siyah", "Manuel");
car5.ekranaYazdir();
Console.WriteLine(car5 == car6);//false çünkü referans tipleri karşılaştırıyoruz. Yani bellekteki adresleri (car5-car6) karşılaştırıyoruz. Bu yüzden false döner.
Console.WriteLine(car5.Marka == car6.Marka);//true çünkü değer tipleri karşılaştırıyoruz. Yani değerlerini karşılaştırıyoruz. Bu yüzden true döner.

CarManager carManager = new CarManager(car1);
carManager.Add();
carManager.Update();
carManager.Delete();

Console.WriteLine("ToString: ");
Console.WriteLine(car1);//ToString metodu override edildiği için bu şekilde yazdırabiliriz.
//Çıktı olarak aşağıdaki gibi bir çıktı alırız.
//Aracın Markası: BMW
//Aracın Modeli: M3
//Aracın Motor Gücü: 450
//Aracın Rengi: Siyah
//Aracın Vites Tipi: Otomatik


Evler ev1 = new Evler();
ev1.Kat = 3;
ev1.ApartmanAdi = "Güneş Apartmanı";
ev1.KiralikUcreti = 2000;
ev1.OdaSayisi = 3;
ev1.SalonSayisi = 1;


ev1.ekranaYazdir();


class Cars
    {

        public Cars()//Constructor - Yapıcı Metot
        {
            Console.WriteLine("Yapıcı Metot Çalıştı");
        }
        
        public Cars(string marka, string model, int motorGucu, string renk, string vitesTipi)
        {
            this.Marka = marka;
            this.Model = model;
            this.MotorGucu = motorGucu;
            this.Renk = renk;
            this.VitesTipi = vitesTipi;
        }
        
        public string Marka;//public ekledik çünkü dışarıdan erişim sağlamak istiyoruz
        public string Model;
        public int MotorGucu;
        public string Renk;
        public string VitesTipi;
        
        public void ekranaYazdir()
        {
            Console.WriteLine($"Aracın Markası: {Marka}");
            Console.WriteLine($"Aracın Modeli: {Model}");
            Console.WriteLine($"Aracın Motor Gücü: {MotorGucu}");
            Console.WriteLine($"Aracın Rengi: {Renk}");
            Console.WriteLine($"Aracın Vites Tipi: {VitesTipi}");
        }

        public override string ToString()
        {
            return $"Aracın Markası: {Marka}\nAracın Modeli: {Model}\nAracın Motor Gücü: {MotorGucu}\nAracın Rengi: {Renk}\nAracın Vites Tipi: {VitesTipi}";
        }
    }



//Ev => Kaçıncı kat, Apartman adı, Kiralık ücreti, Oda sayısı, Salon sayısı
class Evler
{
    public int Kat;
    public string ApartmanAdi;
    public int KiralikUcreti;
    public int OdaSayisi;
    public int SalonSayisi;

    public void ekranaYazdir()
    {
        Console.WriteLine($"Evin Kat: {Kat}");
        Console.WriteLine($"Apartman Adı: {ApartmanAdi}");
        Console.WriteLine($"Kira Ücreti: {KiralikUcreti}");
        Console.WriteLine($"Oda Sayısı: {OdaSayisi}");
        Console.WriteLine($"Salon Sayısı: {SalonSayisi}");
    }
}

class CarManager
{
    Cars car;
    public CarManager(Cars car)//Bu class'taki tüm işlemleri car nesnesi üzerinden yapacağımız için constructor oluşturduk.
    {
        this.car = car;
    }
    
    
    public void Add()//Yukarıya eklediğimiz car nesnesi üzerinden işlem yapacağımız için parametre almıyoruz.
    {
        if (car.MotorGucu<100)
        {
            Console.WriteLine("Motor gücü 100'den küçük olamaz.");
        }
        
        if(car.Marka.Length<2 || string.IsNullOrWhiteSpace(car.Marka))
        {
            Console.WriteLine("Marka 2 karakterden küçük olamaz.");
        }
        
        Console.WriteLine("***************");
        Console.WriteLine("Araba Eklendi: ");
        car.ekranaYazdir();
        Console.WriteLine("***************");
    }

    public void Update()//Yukarıya eklediğimiz car nesnesi üzerinden işlem yapacağımız için parametre almıyoruz.
    {
        Console.WriteLine("***************");
        Console.WriteLine("Araba Güncellendi: ");
        car.ekranaYazdir();
        Console.WriteLine("***************");
    }

    public void Delete()//Yukarıya eklediğimiz car nesnesi üzerinden işlem yapacağımız için parametre almıyoruz.
    {
        Console.WriteLine("***************");
        Console.WriteLine("Araba Silindi: ");
        car.ekranaYazdir();
        Console.WriteLine("***************");
        
        
    }
    }








