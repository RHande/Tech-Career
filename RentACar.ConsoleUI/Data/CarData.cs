using RentACar.ConsoleUI.Models.Dtos;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;


using RentACar.ConsoleUI.Models;
namespace RentACar.ConsoleUI.Data;


public class CarData
{
    private List<Car> cars = new List<Car>()
    {
        new Car(1, 1, 1, 1, "Kiralandı", 10000, 2020, "34AC4567", "Audi", "Q2", 2000),
        new Car(2, 2, 2, 2, "Müsait", 30000, 2022, "34AC4569", "Mercedes", "C180", 4000),
        new Car(3, 3, 3, 3, "Kiralandı", 50000, 2021, "34AC4570", "BMW", "X5", 6000),
        new Car(4, 4, 4, 4, "Müsait", 70000, 2020, "34AC4571", "Ford", "Focus", 8000),
        new Car(5, 5, 5, 5, "Bakımda", 90000, 2022, "34AC4572", "Toyota", "Corolla", 10000),
        new Car(6, 6, 6, 6, "Kiralandı", 110000, 2021, "34AC4573", "Renault", "Clio", 12000),
        new Car(7, 7, 7, 7, "Müsait", 130000, 2020, "34AC4574", "Peugeot", "208", 14000),
    };
   
    //GetById, GetAll, Update, Delete, Add metodları olmalıdır.
   
    public Car GetById(int id)
    {
        Car? car = cars.SingleOrDefault(c => c.Id == id);
        return car ?? throw new Exception("Araba bulunamadı.");
    }
    
    public List<Car> GetAll()
    {
        return cars;
    }
    
    public Car Add(Car car)
    {
        cars.Add(car);
        return car;
    }
    
    public Car Update(Car car)
    {
        Car? carToUpdate = cars.SingleOrDefault(c => c.Id == car.Id); 
        if (carToUpdate is not null) 
        { 
            cars.Remove(carToUpdate); 
            cars.Add(new Car(
                car.Id, 
                car.ColorId, 
                car.FuelId, 
                car.TransmissionId, 
                car.CarState, 
                car.Kilometer, 
                car.ModelYear, 
                car.Plate, 
                car.BrandName, 
                car.ModelName, 
                car.DailyPrice
            )); 
        }
        return car;
    }
    
    public Car Delete(int id)
    {
        Car? car = cars.SingleOrDefault(c => c.Id == id);
        if (car is not null)
        {
            cars.Remove(car);
        }
        return car;
    }

    public List<CarDetailDto> GetAllDetails(List<Color> colors, List<Fuel> fuels, List<Transmission> transmissions)
    {
        List<CarDetailDto> details =
            cars.Join(colors, cr => cr.ColorId, cl => cl.Id, (car, color) => new { car, color })
                .Join(fuels, cc => cc.car.FuelId, fl => fl.Id, (cc, fuel) => new { cc.car, cc.color, fuel })
                .Join(transmissions, cf => cf.car.TransmissionId, tr => tr.Id, 
                    (cf, transmission) => new CarDetailDto(
                        Id: cf.car.Id,
                        BrandName: cf.car.BrandName,
                        ModelName: cf.car.ModelName,
                        ColorName: cf.color.Name,
                        FuelName: cf.fuel.Name,
                        TransmissionName: transmission.Name,
                        DailyPrice: cf.car.DailyPrice,
                        CarState: cf.car.CarState,
                        Kilometer: cf.car.Kilometer,
                        ModelYear: cf.car.ModelYear,
                        Plate: cf.car.Plate
                    )
                ).ToList();

        return details;
    }
    
};