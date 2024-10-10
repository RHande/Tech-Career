using StockManagement.ConsoleUI.Dtos;

namespace StockManagement.ConsoleUI.Data;

public interface IProductData : IRepository <Product, Guid>
{
    decimal TotalProductPriceSum();
    List<Product> GetAllPriceRange(decimal min, decimal max);
    List<Product> GetAllProductNameContains(string text);
    List<Product> GetAllProductsByStockRange(int min, int max);
    List<Product> GetAllProductsOrderByAscendingName();
    List<Product> GetAllProductsOrderByDescendingName();
    Product GetMostExpensiveProduct();
    Product GetCheapestProduct();
    List<ProductDetailDto> GetDetails(List<Category> categories);
    ProductDetailDto? GetDetailById(Guid id, List<Category> categories);

    List<string> GetAllProductNames();

}