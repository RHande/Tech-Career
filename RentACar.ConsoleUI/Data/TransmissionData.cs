namespace RentACar.ConsoleUI.Models;

public class TransmissionData
{
    private List<Transmission> transmissions = new List<Transmission>()
    {
        new Transmission(1, "Manuel"),
        new Transmission(2, "Otomatik")
    };
    
    public Transmission GetById(int id)
    {
        Transmission? transmission = transmissions.SingleOrDefault(t => t.Id == id);
        return transmission ?? throw new Exception("Vites türü bulunamadı.");
    }
    
    public List<Transmission> GetAll()
    {
        return transmissions;
    }
    
    public Transmission Add(Transmission transmission)
    { 
        transmissions.Add(transmission);
        return transmission;
    }

    public Transmission Update(Transmission transmission)
    {
        Transmission? transmissionToUpdate = transmissions.SingleOrDefault(t => t.Id == transmission.Id);
        if (transmissionToUpdate is not null)
        {
            transmissions.Remove(transmissionToUpdate);
            transmissions.Add(new Transmission(transmission.Id, transmission.Name));
        }

        return transmission;
    }
    
    public Transmission Delete(int id)
    {
        Transmission? transmission = transmissions.SingleOrDefault(t => t.Id == id);
        if (transmission is not null)
        {
            transmissions.Remove(transmission);
        }
        return transmission;
    }
}