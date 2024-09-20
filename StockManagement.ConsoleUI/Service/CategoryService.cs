using StockManagement.ConsoleUI.Data;

namespace StockManagement.ConsoleUI.Service;


public class CategoryService
{
    CategoryData categoryData = new CategoryData();


    public List<Category> GetAllCategories()
    {
        return categoryData.GetAll();
    }
    
    
    
    public void GetAll()
    {
        List<Category> categories = categoryData.GetAll();
        
        categories.ForEach(category => Console.WriteLine(category));
    }

    public void GetById(int id)
    {
        Category? category = categoryData.GetById(id);
        if (category is null)
        {
            Console.WriteLine("Aradığınız Id'ye ait ürün bulunamadı.");
        }
       
        Console.WriteLine(category);
    }
    
    public void Add(Category category)
    {
        categoryData.Add(category);
        Console.WriteLine("Kategori eklendi.");
    }
    
    
    
}