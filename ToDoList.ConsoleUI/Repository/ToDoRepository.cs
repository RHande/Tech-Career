using ToDoList.ConsoleUI.Models;

namespace ToDoList.ConsoleUI.Repository;

public sealed class ToDoRepository : BaseRepository, IToDoRepository
{
    public ToDo Add(ToDo item)
    {
        ToDos().Add(item);
        return item;
    }
    
    public ToDo? Delete(int id)
    {
        throw new NotImplementedException();
    }
    
    public List<ToDo> GetAll()
    {
        return ToDos();
    }
    
    public List<ToDo> GetAllByTitleContains(string title)
    {
        throw new NotImplementedException();
    }

    public ToDo? GetById(int id)
    {
        throw new NotImplementedException();
    }
    
    public ToDo? Update(ToDo item)
    {
        throw new NotImplementedException();
    }

}