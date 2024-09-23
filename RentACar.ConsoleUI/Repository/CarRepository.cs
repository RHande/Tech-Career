using RentACar.ConsoleUI.Models;
using RentACar.ConsoleUI.Data;


namespace RentACar.ConsoleUI.Data;

public class CarRepository
{
    CarData carData = new CarData();
    ColorData colorData = new ColorData();
    FuelData fuelData = new FuelData();
    TransmissionData transmissionData = new TransmissionData();
    
    public void GetAll()
    {
        List<Car> cars = carData.GetAll();
        cars.ForEach(car => Console.WriteLine(car));
    }
    
    
    
    
}