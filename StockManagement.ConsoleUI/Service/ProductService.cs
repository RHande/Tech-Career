using StockManagement.ConsoleUI.Data;
using StockManagement.ConsoleUI.Dtos;

namespace StockManagement.ConsoleUI.Service;

public class ProductService
{
    ProductData productData = new ProductData();
    
    CategoryService categoryService = new CategoryService();
    public void GetAll()
    {
        List<Product> products = productData.GetAll();
        
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
    }
    
    public void GetById(Guid id)
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

    public void TotalProductPriceSum()
    {
        decimal total = productData.TotalProductPriceSum();
        Console.WriteLine($"Ürünlerin toplam fiyatı: {total}");
    }
    
    public void GetAllPriceRange(decimal min, decimal max)
    {
        List<Product> filteredProducts = productData.GetAllPriceRange(min, max);
        foreach (Product product in filteredProducts)
        {
            Console.WriteLine(product);
        }
    }
    
    public void GetAllProductNameContains(string text)
    {
        List<Product> containsProducts = productData.GetAllProductNameContains(text);
        foreach (Product product in containsProducts)
        {
            Console.WriteLine(product);
        }
    }
    
    public void Delete(Guid id)
    {
        Product? product = productData.Delete(id);
        if (product is null)
        {
            Console.WriteLine($"Aradığınız Id'ye ({id}) ait ürün bulunamadı.");
            return;
        }
        
        Console.WriteLine("Ürün silindi.");
    }
    
    public void GetAllProductsByStockRange(int min, int max)
    {
        List<Product> products = productData.GetAllProductsByStockRange(min, max);
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
        
    }

    public void GetAllProductsOrderByAscendingName()
    {
        List<Product> products = productData.GetAllProductsOrderByAscendingName();
        products.ForEach(p => Console.WriteLine(p));
        
    }
    
    public void GetAllProductsOrderByDescendingName()
    {
        List<Product> products = productData.GetAllProductsOrderByDescendingName();
        products.ForEach(p => Console.WriteLine(p));
    }
    
    public void GetMostExpensiveProduct()//Böyle daha kolay oluyor.
    {
        Product? product = productData.GetMostExpensiveProduct();
        Console.WriteLine($"En pahalı ürün bilgileri: {product}");
    }
    
    //Take ile yazdığımızı bu şekilde çağırabiliriz.
    /* public void GetCheapestProducts()
    {
        List<Product> products = productData.GetCheapestProducts();
        products.ForEach(p => Console.WriteLine(p));
    } */
    public void GetCheapestProduct()
    {
        Product? product = productData.GetCheapestProduct();
        Console.WriteLine($"En ucuz ürün bilgileri: {product}");
    }

    public void GetDetails()
    {
        List<Category> categories = categoryService.GetAllCategories();
        List<ProductDetailDto> details = productData.GetDetails(categories);
        details.ForEach(p => Console.WriteLine(p));
    }
    
    public void GetDetailById(Guid id)
    {
        List<Category> categories = categoryService.GetAllCategories();
        ProductDetailDto? detail = productData.GetDetailById(id, categories);
        if (detail is null)
        {
            Console.WriteLine("Aradığınız Id'ye ait ürün bulunamadı.");
            return;
        }
        
        Console.WriteLine(detail);
    }
    
}