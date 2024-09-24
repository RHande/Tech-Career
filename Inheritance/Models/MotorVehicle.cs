namespace Inheritance.Models;

public abstract class MotorVehicle : Vehicle //MotorVehicle inherits from Vehicle. Abstract new anahtar sözcüğü ile nesne üretmemizi engeller.
{//Bunu solid class olarak yani nesne üretilmeyecek, ortak özelliklerin kullanıldığı bir sınıf olarak düşünebiliriz.
    public int NumberOfDoors { get; set; }
    public string FuelType { get; set; }
    public int Kilometers { get; set; }
    public string UpdatedAt { get; set; }
}