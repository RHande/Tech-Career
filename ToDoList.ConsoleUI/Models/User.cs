namespace ToDoList.ConsoleUI.Models;

public sealed class User : Entity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    
    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Surname: {Surname}, Age: {Age}, Email: {Email}, Password: {Password}";
    }
}