using System.Collections.Immutable;
using System.Diagnostics;
using StockManagement.ConsoleUI.Dtos;

namespace StockManagement.ConsoleUI.Data;

public class ProductData()
{
    private List<Product> products = new List<Product>()//Private yazdık çünkü direkt erişim olmasın, sadece metodlarla erişilebilsin.
    {
        new Product(1, 1, "Beymen Ceket", 15000, 250),
        new Product(2, 2, "Prada Çanta", 60000, 10),
        new Product(3, 3,"Hk Vision Drone", 400000, 25),
        new Product(4, 3,"Dyson V15", 32000, 1000),
        new Product(5, 4,"Karaca Vazo", 500, 1000),
        new Product(6, 4,"Kervan Ayna", 1000, 50),
        new Product(7,5,"Adidas Futbol Topu", 3000, 1254),
        new Product(8, 5,"Delta Yoga Matı", 2000, 531)
    };
    
    // List<Category> categories = new List<Category>()
    // {
    //     new Category(1, "Kıyafet", "Giyim ürünleri"),
    //     new Category(2, "Aksesuar", "Kıyafet tamamlayıcıları"),
    //     new Category(3, "Teknoloji", "Elektronik ürünler"),
    //     new Category(4, "Ev Eşyası", "Ev dekorasyon ürünleri"),
    //     new Category(5, "Spor Malzemeleri", "Spor yaparken kullanılan ürünler")
    // };
    
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
        //1. Yöntem:
        /*List<Product> filteredProducts = new List<Product>();
        foreach (Product product in products)
        {
            if (product.Price >= min && product.Price <= max)
            {
                filteredProducts.Add(product);
            }
        }
        return filteredProducts;
        */
        var filteredProducts = products.Where(p => p.Price >= min && p.Price <= max).ToList();
        //Where metodu, şartı sağlayan elemanları getirir. Aslında bir filtreleme işlemi yapar.
        return filteredProducts;
    }

    public List<Product> GetAllProductNameContains(string text)
    {
        //1. Yöntem:
        /*
        List<Product> containsProducts = new List<Product>();
        foreach (Product product in products)
        {
            if (product.Name.Contains(text, StringComparison.InvariantCultureIgnoreCase))
            {
                containsProducts.Add(product);
            }
        }
        return containsProducts;
        */
        //FindAll metodu, şartı sağlayan elemanları getirir. Aslında bir filtreleme işlemi yapar.
        //Bu method, List sınıfında bulunan bir methoddur.
        //Birden fazla eleman döneceği zamanlarda kullanılır.
        var containsProducts = products.FindAll(p => p.Name.Contains(text, StringComparison.InvariantCultureIgnoreCase));
        return containsProducts;
    }
    //**FindAll metodu, Where metodu ile aynı işi yapar. Farklarından biri, FindAll metodu List sınıfında bulunurken, Where metodu IEnumerable sınıfında bulunur.
    //FindAll methodu daha performanslıdır. Çünkü Where metodu, IEnumerable sınıfında bulunduğu için,IEnumerable sınıfının tüm metotlarını çalıştırır.
    
    public Product GetById(int id)
    {
        //1. Yöntem:
        /*
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
        */
        //FirstOrDefault metodu, şartı sağlayan ilk elemanı getirir. Aslında bir filtreleme işlemi yapar.
        //FirstOrDefault metodu, First metodu ile aynı işi yapar. Farklarından biri, First metodu eleman bulamazsa hata verirken, FirstOrDefault metodu eleman bulamazsa null döner.
        //SingleOrDefault metodu, şartı sağlayan tek bir elemanı getirir. Aslında bir filtreleme işlemi yapar.
        //FirstOrDefault ile SingleOrDefault arasındaki fark, FirstOrDefault metodu birden fazla eleman dönebilirken (ilk elemanı döner), SingleOrDefault metodu sadece bir eleman dönebilir ve unique bir değer arar.
        //Elimizde tekil bir değer olacağından eminsek SingleOrDefault kullanılır.
        Product? product = products.SingleOrDefault(p => p.Id == id);
        return product ?? throw new Exception("Ürün bulunamadı.");
        /*
        Product? product = products.where(p => p.Id == id).SingleOrDefault();
        return product ?? throw new Exception("Ürün bulunamadı.");
        
        Product? product = products.FirstOrDefault(p => p.Id == id);
        return product ?? throw new Exception("Ürün bulunamadı.");
         */
    }

    public Product Delete(int id)
    {
        //1. Yöntem:
        /*
        Product? product = GetById(id);
        if (product is not null)
        {
            products.Remove(product);
        }
        return product;
        */
        Product? product = products.SingleOrDefault(p => p.Id == id);
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

    public List<Product> GetAllProductsByStockRange(int min, int max)
    {
        //var filteredStocks = products.Where(p => p.Stock >= min && p.Stock <= max).ToList();
        //FindAll: List sınıfında bulunan bir methoddur. Birden fazla eleman döneceği zamanlarda kullanılır.
        var filteredStocks = products.FindAll(p => p.Stock >= min && p.Stock <= max);
        return filteredStocks;
    }
    
    public List<Product> GetAllProductsOrderByAscendingName()
    {
        List<Product> orderedProducts = products.OrderBy(p => p.Name).ToList();
        return orderedProducts;
    }
    
    public List<Product> GetAllProductsOrderByDescendingName()
    {
        List<Product> orderedProducts = products.OrderByDescending(p => p.Name).ToList();
        return orderedProducts;
    }
    
    
   
   public Product GetMostExpensiveProduct() //Bu daha kullanışlı bence.
   {
    return products.OrderByDescending(p => p.Price).FirstOrDefault(); 
   }//LastOrDefault metodu da kullanılabilir. Sıralamayı da ona göre yapmamız gerekir.
   
    //Take ile de bu şekilde yapılabilir ve o zaman list kullanmamız gerekir.
    /* public List<Product> GetCheapestProducts()
    {
        List<Product> orderedProducts = products.OrderBy(p => p.Price).Take(1).ToList();
        return orderedProducts;
    }
    */
    public Product GetCheapestProduct()
    {
        return products.OrderBy(p => p.Price).FirstOrDefault();
        //Ya da: return products.OrderByDescending(p => p.Price).LastOrDefault();
    }


    public List<ProductDetailDto> GetDetails(List<Category> categories)
    {
        List<ProductDetailDto> details =
        products.Join(categories, p => p.CategoryId, c => c.Id, (product, category) => new ProductDetailDto(
            Id: product.Id,
            Name: product.Name,
            CategoryName: category.Name,
            Price: product.Price,
            Stock: product.Stock
        )).ToList();
        return details;
     //Join metodu, iki tabloyu birleştirir. İki tablodan da belirli bir şarta göre elemanları getirir.
    }
    
    public ProductDetailDto? GetDetailById(int id, List<Category> categories)
    {
        var result = from p in products
            where p.Id == id 
            join c in categories on p.CategoryId equals c.Id
            select new ProductDetailDto(
                Id: p.Id,
                Name: p.Name,
                CategoryName: c.Name,
                Price: p.Price,
                Stock: p.Stock
            );
        return result.FirstOrDefault();
    }
    
}

