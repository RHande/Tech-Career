// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;
using Inheritance.Models;


Car car = new Car()
{
    Id = 1,
    NumberOfDoors = 4,
    FuelType = "Gasoline",
    TransmissionType = "Automatic",
    Color = "Red",
    Kilometers = 10000,
    CreatedAt = DateTime.Now.ToString(),
    UpdatedAt = null
};

Console.WriteLine(car);

