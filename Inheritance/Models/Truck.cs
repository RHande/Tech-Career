namespace Inheritance.Models;

public sealed class Truck : MotorVehicle
{
    public bool Dorse { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}\n Number Of Doors: {NumberOfDoors}\nFuel Type: {FuelType}\nTransmission Type: {TransmissionType}\nColor: {Color}\nKilometers: {Kilometers}\nDorsal: {Dorse}";
    }
}