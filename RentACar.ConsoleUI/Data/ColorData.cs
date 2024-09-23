namespace RentACar.ConsoleUI.Models;

public class ColorData
{
    //GetById, GetAll, Update, Delete, Add metodları olmalıdır.
    private List<Color> colors = new List<Color>()
    {
        new Color(1, "Siyah"),
        new Color(2, "Beyaz"),
        new Color(3, "Gri"),
        new Color(4, "Kırmızı"),
        new Color(5, "Mavi"),
        new Color(6, "Yeşil"),
        new Color(7, "Sarı"),
        new Color(8, "Turuncu"),
        new Color(9, "Mor"),
        new Color(10, "Pembe"),
    };

    public Color GetById(int id)
    {
        Color? color = colors.SingleOrDefault(c => c.Id == id);
        return color ?? throw new Exception("Renk bulunamadı.");
    }
    
    public List<Color> GetAll()
    {
        return colors;
    }
    
    public Color Add(Color color)
    {
        colors.Add(color);
        return color;
    }
    
    public Color Update(Color color)
    {
        Color? colorToUpdate = colors.SingleOrDefault(c => c.Id == color.Id); 
        if (colorToUpdate is not null) 
        { 
            colors.Remove(colorToUpdate); 
            colors.Add(new Color(
                color.Id, 
                color.Name
            )); 
        }
        return color;
    }
    
    public Color Delete(int id)
    {
        Color? color = colors.SingleOrDefault(c => c.Id == id);
        if (color is not null)
        {
            colors.Remove(color);
        }
        return color;
    }
}