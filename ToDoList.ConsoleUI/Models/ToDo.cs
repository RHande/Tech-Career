namespace ToDoList.ConsoleUI.Models;

public sealed class ToDo : Entity
{

    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? StartDate { get; set; }
    public string Priority { get; set; }
    public int UserId { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Title: {Title}, Description: {Description}, IsCompleted: {IsCompleted}, CreatedDate: {CreatedDate}, EndDate: {EndDate}, StartDate: {StartDate}, Priority: {Priority}, UserId: {UserId}";
    }
}