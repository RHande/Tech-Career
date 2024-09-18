using StockManagement.ConsoleUI.Data;

namespace StockManagement.ConsoleUI.Service;

public class ProductService
{
    ProductData productData = new ProductData();

    public void GetAll()
    {
        List<Product> products = productData.GetAll();
        
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
    }
    
    public void GetById(int id)
    {
        Product? product = productData.GetById(id);
        if (product is null)
        {
            Console.WriteLine("Aradığınız Id'ye ait ürün bulunamadı.");
        }
        else
        { 
            Console.WriteLine(product);
        }
    }
}