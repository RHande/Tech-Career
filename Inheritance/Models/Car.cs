namespace Inheritance.Models;

public sealed class Car : MotorVehicle//Sealed keyword prevents inheritance. Yani mirası engeller, son mirasçı olduğunu anlamamızı sağlar ve bu yapacağımız işlemi hızlandırır.
{

    public override string ToString()
    {
        return $"Id: {Id}\nNumber Of Doors: {NumberOfDoors}\nFuel Type: {FuelType}\nTransmission Type: {TransmissionType}\nColor: {Color}\nKilometers: {Kilometers}\nCreated At: {CreatedAt}\nUpdated At: {UpdatedAt}";
    }
}