namespace StockManagement.ConsoleUI.Data;

public class ProductData()
{
    private List<Product> products = new List<Product>()//Private yazdık çünkü direkt erişim olmasın, sadece metodlarla erişilebilsin.
    {
        new Product(1, "Beymen Ceket", 15000, 250),
        new Product(2, "Prada Çanta", 60000, 10),
        new Product(3, "Hk Vision Drone", 400000, 25),
        new Product(4, "Dyson V15", 32000, 1000),
        new Product(5, "Karaca Vazo", 500, 1000),
        new Product(6, "Kervan Ayna", 1000, 50),
        new Product(7, "Adidas Futbol Topu", 3000, 1254),
        new Product(8, "Delta Yoga Matı", 2000, 531)
    };
    
    public Product Add(Product product)
    {
        products.Add(product);
        return product;
    }
    
    public decimal TotalProductPriceSum()
    {
        decimal total = products.Sum(p => p.Price);
        return total;
    }

    public List<Product> GetAllPriceRange(decimal min, decimal max)
    {
        List<Product> filteredProducts = new List<Product>();
        foreach (Product product in products)
        {
            if (product.Price >= min && product.Price <= max)
            {
                filteredProducts.Add(product);
            }
        }
        return filteredProducts;
    }

    public List<Product> GetAllProductNameContains(string text)
    {
        List<Product> containsProducts = new List<Product>();
        foreach (Product product in products)
        {
            if (product.Name.Contains(text, StringComparison.InvariantCultureIgnoreCase))
            {
                containsProducts.Add(product);
            }
        }
        return containsProducts;
    }
    
    public Product GetById(int id)
    {
        Product? product = null;
        foreach (Product p in products)
        {
            if (p.Id == id)
            {
                product = p;
                break;
            }
        }
        return product ?? throw new Exception("Ürün bulunamadı.");
        //return product;
    }

    public Product Delete(int id)
    {
        Product? product = GetById(id);
        if (product is not null)
        {
            products.Remove(product);
        }

        return product;
    }
    
    public List<Product> GetAll()
    {
        return products;
    }
    
}

