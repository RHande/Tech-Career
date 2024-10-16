namespace StockManagement.ConsoleUI.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public record ProductDetailDto(
        Guid Id,
        string CategoryName,
        string Name,
        decimal Price,
        int Stock);