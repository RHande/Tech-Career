namespace StockManagement.ConsoleUI;

public record Product(
    int Id,
    int CategoryId,
    string Name,
    decimal Price,
    int Stock
    );