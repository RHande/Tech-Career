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


StockUpdate();

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


void TotalProductPriceSum()
{
    PrintAyitac("Ürünlerin Toplam Fiyatı");
    
    decimal total = 0;
    foreach (Product product in products)
    {
        total += product.Price;
    }
    
    Console.WriteLine($"Ürünlerin toplam fiyatı: {total}");
}

TotalProductPriceSum();



void GetAllPriceRange(decimal min, decimal max)
{
    PrintAyitac("Fiyat Aralığına Göre Ürünler");
    
    foreach (Product product in products)
    {
        if (product.Price>min && product.Price<max)
        {
            Console.WriteLine(product);
        }
    }
}

GetAllPriceRange(1000, 20000);//output: Beymen Ceket, Karaca Vazo, Kervan Ayna, Adidas Futbol Topu, Delta Yoga Matı

void GetPriceRangeData(out decimal min, out decimal max)
{
    Console.Write("Lütfen minimum fiyatı giriniz: ");
    min = Convert.ToDecimal(Console.ReadLine());
    
    Console.Write("Lütfen maximum fiyatı giriniz: ");
    max = Convert.ToDecimal(Console.ReadLine());
}

void GetAllProductsByPriceFiltered()
{
    decimal min;
    decimal max;
    GetPriceRangeData(out min, out max);
    GetAllPriceRange(min, max);
}

GetAllProductsByPriceFiltered();


void GetAllProductNameContains(string text)
{
    PrintAyitac("Ürün İsmi İçeren Ürünler");
    foreach (Product product in products)
    {
        if (product.Name.Contains(text, StringComparison.InvariantCultureIgnoreCase))
        {
            Console.WriteLine(product);
        }
    }
}
void GetProductNameContainsData()
{
    Console.Write("Lütfen aramak istediğiniz ürünü yazınız: ");
    string text = Console.ReadLine();
    GetAllProductNameContains(text);
}
GetProductNameContainsData();

void Delete()
{
    bool isPresent = false;
    PrintAyitac("Silme İşlemi");
    Console.Write("Lütfen silmek istediğiniz ürünün Id'sini giriniz: ");
    int id = Convert.ToInt32(Console.ReadLine());
    
    foreach(Product product in products)
    {
        if(product.Id != id)
        {
            isPresent = false;
        }else
        {
            isPresent = true;
            products.Remove(product);
            Console.WriteLine($"Id'si {id} olan ürün silindi.");
            break;
        }
    }
    
    if (!isPresent)
    {
        Console.WriteLine($"Aradığınız id'ye ({id}) ait ürün bulunamadı");
    }

    foreach (Product item in products)
    {
        Console.WriteLine(item);
    }
}

Delete();

//Kullanıcıdan id ve stok değerlerini alınız.
//Eğer stokta varsa, ürün kaç adet isteniyorsa o kadar satılsın
//Kullanıcı ürünü aldıktan sonra stok miktarı güncellensin ve 0'a düşüyorsa ürün silinsin

//Diyelim ki kullanıcı 50 ürün almak istiyor ama stokta 40 tane var.
//Bu durumda "Alabileceğiniz max miktar 40" şeklinde bir uyarı verilsin.
//Eğer stokta 0 varsa, "Üzgünüz, bu ürün stoklarımızda bulunmamaktadır" şeklinde bir uyarı verilsin.

void StockUpdate()
{
    GetAllProducts();
    PrintAyitac("Lütfen güncellemek istediğiniz veriyi yazınız.");

    Console.Write("Lütfen ürün Id'sini giriniz: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.Write("Lütfen almak istediğiniz ürün miktarını giriniz: ");
    int stock = Convert.ToInt32(Console.ReadLine());

    Product product = null;

    foreach (Product p in products)
    {
        if (p.Id == id)
        {
            product = p;
            break;
        }
    }

    if (stock > product.Stock)
    {
        Console.WriteLine($"Alabileceğiniz max miktar {product.Stock}");
        return;
    }

    int newStock = product.Stock - stock;
    Product updatedProduct = new Product(product.Id, product.Name, product.Price, newStock);

    if (newStock == 0)
    {
        products.Remove(product);
        Console.WriteLine("Ürün stoklarımızda bulunmamaktadır.");
        return;
    }
    
    
    string productName = product.Name;
    int adetSayisi = stock;
    decimal toplamFiyat = product.Price * stock;
    Console.WriteLine($"{productName} adlı üründen {adetSayisi} adet alındı. Toplam fiyat: {toplamFiyat}");

    int productIndex = products.IndexOf(product);
    products.Remove(product);
    products.Insert(productIndex, updatedProduct);
  
    GetAllProducts();
}
