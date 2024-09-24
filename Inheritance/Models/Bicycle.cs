namespace Inheritance.Models;

public sealed class Bicycle : Vehicle
{
    public bool ShockAbsorber { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}\nTransmission Type: {TransmissionType}\nColor: {Color}\nShock Absorber: {ShockAbsorber}";
    }
}