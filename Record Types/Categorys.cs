namespace Record_Types;

public record Categories (int Id, string Name, string Description)
{
    public override string ToString() => $"Id: {Id}, Name: {Name}, Description: {Description}";
}

