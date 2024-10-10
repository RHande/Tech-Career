namespace StockManagement.ConsoleUI.Data;

public abstract class BaseRepository
{
    private List<Category> categories = new List<Category>()
    {
        new Category(1, "Kıyafet", "Giyim kategorisi"), 
        new Category(2, "Aksesuar", "Aksesuar kategorisi"), 
        new Category(3, "Elektronik", "Elektronik kategorisi"), 
        new Category(4, "Ev Eşyası", "Ev eşyası kategorisi"), 
        new Category(5, "Spor Malzemeleri", "Spor malzemeleri kategorisi")
    };
    
    private List<Product> products = new List<Product>()//Private yazdık çünkü direkt erişim olmasın, sadece metodlarla erişilebilsin.
    {
        
    };

    public List<Category> Categories() => categories;
    public List<Product> Products() => products;
}