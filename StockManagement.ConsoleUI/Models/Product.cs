namespace StockManagement.ConsoleUI;

public sealed class Product : Entity<Guid>
{
    public Product()
    {
        
    }
    public Product (Guid id, string name, decimal price, int stock, int categoryId)
    {
        Id = id;
        CategoryId = categoryId;
        Name = name;
        Price = price;
        Stock = stock;
    }
    public int CategoryId { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Name { get; set; }
}