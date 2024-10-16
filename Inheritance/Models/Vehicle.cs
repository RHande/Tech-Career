using System.Runtime.InteropServices.JavaScript;

namespace Inheritance.Models;

public abstract class Vehicle
{
    public int Id { get; set; }
    public string TransmissionType { get; set; }
    public string Color { get; set; }
    public string CreatedAt { get; set; }
}