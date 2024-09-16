// See https://aka.ms/new-console-template for more information

using Record_Types;

/*
Products product = new Products
{
    Name = "Laptop",
    Price = 1000,
    Stock = 10,
    Description = "A laptop for developers"
};

Console.WriteLine(product);
*/
Categories category = new Categories(1, "Electronics", "Electronic Devices");
Console.WriteLine(category);    //Id: 1, Name: Electronics, Description: Electronic Devices


Products product = new Products("Laptop", 1000, 10, "A laptop for developers", category);
Console.WriteLine(product);   //Name: Laptop, Price: 1000, Stock: 10, Description: A laptop for developers

Products [] products = new Products[]
{
    new Products("Laptop", 1000, 10, "A laptop for developers", category),
    new Products("Mouse", 50, 100, "A mouse for developers", category),
    new Products("Keyboard", 150, 50, "A keyboard for developers", category)
};

foreach (var item in products)
{
    Console.WriteLine(item);
}

//Şöyle de yazılabiliyor:
/*
 Products [] products = new Products[] {product, new Products("Mouse", 50, 100, "A mouse for developers", category)};
Array.ForEach(products, x=>
{
    Console.WriteLine(x);
});
*/