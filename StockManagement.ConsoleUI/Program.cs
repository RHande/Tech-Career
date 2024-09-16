// See https://aka.ms/new-console-template for more information


//Bir ürünler listesi oluşturulacak
//Bir kategori listesi oluşturulacak

//Bütün ürünleri listeleyen kod yazılacak
//Bütün kategorileri listeleyen kod yazılacak

//Kullanıcıdan kategori verilerini alıp listeye ekleyen
//Kural olarak daha önceden kullanıcının girmiş olduğu Id değerine ait veri varsa ekran çıktısı olarak Id alanı benzersiz olmalıdır(Id).
//Listeyi ekran çıktısı olarak isteyen kod yazılacak

//Ürünlerin fiyat toplamını gösteren kod yazılacak
//Kullanıcıdan iki değer alıp, bunların min max arasındaki ürünleri listeleyen kod yazılacak
//Bu iki değer arasındaki ürünlerin stok verilerini gösteren kod yazılacak

//Ürünler listesinde bir isim parametresi alarak, ürün isimlerinden uyuşanları listeleyen kod yazılacak

//Product Details ekranı oluşturulacak
//ProductName, ProductPrice, ProductStock, CategoryName
//Bu ekranda ürün detaylarını gösteren kod yazılacak


using StockManagement.ConsoleUI;

List<Product> products = new List<Product>()
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

List<Category> categories = new List<Category>()
{
    new Category(1, "Kıyafet", "Giyim ürünleri"),
    new Category(2, "Aksesuar", "Kıyafet tamamlayıcıları"),
    new Category(3, "Teknoloji", "Elektronik ürünler"),
    new Category(4, "Ev Eşyası", "Ev dekorasyon ürünleri"),
    new Category(5, "Spor Malzemeleri", "Spor yaparken kullanılan ürünler")
};


void GetAllCategories()
{
    PrintAyitac("Bütün Kategoriler: ");
    foreach (Category category in categories)
    {
        Console.WriteLine(category);
    }
}

void GetAllProducts()
{
    PrintAyitac("Bütün Ürünler: ");
    foreach (Product product in products)
    {
        Console.WriteLine(product);
    }
}

void PrintAyitac(string title)
{
    Console.WriteLine("************************");
    Console.WriteLine(title);
}
GetAllCategories();
GetAllProducts();

void AddProductAndGetAll()
{
    PrintAyitac("Ürün Ekle ve Listele");
    
    Console.Write("Lütfen ürün Id'sini giriniz: ");
    int id = Convert.ToInt32(Console.ReadLine());
    
    bool isUnique = true;
    foreach (Product product in products)
    {
        if (product.Id == id)
        {
            isUnique = false;
            break;
        }
    }
    if(!isUnique)
    {
        Console.WriteLine("Bu Id'ye ait ürün zaten var.");
        return;
    }
    
    Console.Write("Lütfen ürün adını giriniz: ");
    string name = Console.ReadLine();
    
    Console.Write("Lütfen ürün fiyatını giriniz: ");
    decimal price = Convert.ToDecimal(Console.ReadLine());
    
    Console.Write("Lütfen ürün stok miktarını giriniz: ");
    int stock = Convert.ToInt32(Console.ReadLine());
    
    Product createdProduct = new Product(id, name, price, stock);
    
    products.Add(createdProduct);
    
    foreach(Product product in products)
    {
        Console.WriteLine(product);
    }
}

AddProductAndGetAll();







