using System.Collections.Immutable;
using System.Diagnostics;

namespace StockManagement.ConsoleUI.Data;

public sealed class CategoryData : BaseRepository, ICategoryRepository
{
    public List<Category> GetAll()
    {
        return base.Categories();
    }

    public Category? GetById(int id)
    {
        throw new NotImplementedException();
    }
    

    public Category Add(Category category)
    {
        throw new NotImplementedException();
    }

    public Category Update(Category category)
    {
        throw new NotImplementedException();
    }

    public Category Delete(int id)
    {
        throw new NotImplementedException();
    }
    
}