using ToDoList.ConsoleUI.Models;

namespace ToDoList.ConsoleUI.Repository;

public abstract class BaseRepository
{
    List<ToDo> toDos = new List<ToDo>();

    List<User> users = new List<User>();


    public List<User> Users()
    {
        return users;
    }
    
    public List<ToDo> ToDos()
    {
        return toDos;
    }
}
        
