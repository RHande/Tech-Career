using ToDoList.ConsoleUI.Models;

namespace ToDoList.ConsoleUI.Repository;

public interface IToDoRepository : IRepository<ToDo>
{
    List<ToDo> GetAllByTitleContains(string title); 
}