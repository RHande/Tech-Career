namespace Record_Types;

public record Products (string Name, double Price, int Stock, string Description, Categories category) //istersem buraya kategori ekleyebilirim.
//Eklemediğim şekli: public record Products (string Name, double Price, int Stock, string Description)
//Ya da sadece kategori id'sini ekleyebilirim: public record Products (string Name, double Price, int Stock, string Description, int CategoryId)
{
    //Class'taki gibi ovverride etmeden önce parametreleri bloğun içinde eşitlememize gerek kalmaz.
    public override string ToString() => $"Name: {Name}, Price: {Price}, Stock: {Stock}, Description: {Description}, Category: {category.Name}";
}


/* Eğer yukarıdaki kodu kullanmak istemiyorsanız, aşağıdaki kodu kullanabilirsiniz. Bu durumda içine parametre yazmadan bu kodu kullanabilirsiniz.
{
    public string Name { get; init; }
    public double Price { get; init; }
    public int Stock { get; init; }
    public string Description { get; init; }
    
}
*/