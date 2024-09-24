using ToDoList.ConsoleUI.Models;


namespace ToDoList.ConsoleUI.Repository;

public sealed class UserRepository : BaseRepository, IUserRepository
{
    public User Add(User item)
    {
        Users().Add(item);
        return item;
    }
    
    public User? Delete(int id)
    {
        throw new NotImplementedException();
    }
    
    public List<User> GetAll()
    {
        return Users();
    }
    
    public User? GetById(int id)
    {
        throw new NotImplementedException();
    }
    
    public User? Update(User item)
    {
        throw new NotImplementedException();
    }
}
