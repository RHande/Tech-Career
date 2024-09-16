namespace StockManagement.ConsoleUI;

public record Product(
    int Id,
    string Name,
    decimal Price,
    int Stock
    );