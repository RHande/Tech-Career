using ToDoList.ConsoleUI.Models;

namespace ToDoList.ConsoleUI.Repository
{
    public interface IRepository<TEntity>
        where TEntity : Entity, new()
    {
        List<TEntity> GetAll();
        TEntity? GetById(int id);
        TEntity Add(TEntity item);
        TEntity? Update(TEntity item);
        TEntity? Delete(int id);
    }
}