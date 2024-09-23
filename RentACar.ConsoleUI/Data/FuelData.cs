namespace RentACar.ConsoleUI.Models;

public class FuelData
{
    private List<Fuel> fuels = new List<Fuel>()
    {
        new Fuel(1, "Benzin"),
        new Fuel(2, "Dizel"),
        new Fuel(3, "Hibrit"),
        new Fuel(4, "Elektrik")
    };

    public Fuel GetById(int id)
    {
        Fuel? fuel = fuels.SingleOrDefault(f => f.Id == id);
        return fuel ?? throw new Exception("Yakıt türü bulunamadı.");
    }
    
    public List<Fuel> GetAll()
    {
        return fuels;
    }
    
    public Fuel Add(Fuel fuel)
    {
        fuels.Add(fuel);
        return fuel;
    }
    
    public Fuel Update(Fuel fuel)
    {
        Fuel? fuelToUpdate = fuels.SingleOrDefault(f => f.Id == fuel.Id); 
        if (fuelToUpdate is not null) 
        { 
            fuels.Remove(fuelToUpdate); 
            fuels.Add(new Fuel(
                fuel.Id, 
                fuel.Name
            )); 
        }
        return fuel;
    }
    
    public Fuel Delete(int id)
    {
        Fuel? fuel = fuels.SingleOrDefault(f => f.Id == id);
        if (fuel is not null)
        {
            fuels.Remove(fuel);
        }
        return fuel;
    }
}