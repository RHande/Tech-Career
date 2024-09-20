using System.Collections.Immutable;
using System.Diagnostics;

namespace StockManagement.ConsoleUI.Data;

public class CategoryData
{
    private List<Category> categories = new List<Category>()
    {
        new Category(1, "Kıyafet", "Giyim ürünleri"),
        new Category(2, "Aksesuar", "Kıyafet tamamlayıcıları"),
        new Category(3, "Teknoloji", "Elektronik ürünler"),
        new Category(4, "Ev Eşyası", "Ev dekorasyon ürünleri"),
        new Category(5, "Spor Malzemeleri", "Spor yaparken kullanılan ürünler")
    };
    
    public List<Category> GetAll()
    {
        return categories;
    }
    
    public Category GetById(int id)
    {
        Category? category = categories.SingleOrDefault(c => c.Id == id);
        return category ?? throw new Exception("Ürün bulunamadı.");
    }
    
    public Category Add(Category category)
    {
        categories.Add(category);
        return category;
    }
    
    
}