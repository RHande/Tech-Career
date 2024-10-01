// See https://aka.ms/new-console-template for more information

using Polymorphsym;
using Polymorphsym.Models;

//CreditCardPayment creditCardPayment = new CreditCardPayment()
BasePayment creditCardPayment = new CreditCardPayment()//Bu şekilde de çalışır çünkü CreditCardPayment BasePayment sınıfından türetilmiştir.
    //Hepsi bir ödeme yöntemidir.
{
    Amount = 1000,
    CardNumber = "1234 5678 9012 3456",
    CVV = "123",
    ExpiryDate = "12/25",
    FullName = "Ahmet Yılmaz"
};


// if(creditCardPayment.GetType() == typeof(CreditCardPayment))
// {
//     Console.WriteLine("Bu bir kredi kartı ödemesidir.");
// }else if(creditCardPayment.GetType() == typeof(PaypalPayment))
// {
//     Console.WriteLine("Bu bir paypal ödemesidir.");
// }else if(creditCardPayment.GetType() == typeof(IbanPayment))
// {
//     Console.WriteLine("Bu bir IBAN ödemesidir.");
// }
//
// creditCardPayment.Payment();

//Aşağıdaki gibi de yapılabiliyor:

if(creditCardPayment is CreditCardPayment)
{
    creditCardPayment = (CreditCardPayment)creditCardPayment;
    creditCardPayment.Payment();
}else if(creditCardPayment is PaypalPayment ibanPayment)//Yukarıdaki yazımla aynı anlama gelir.
{
    ibanPayment.Payment();
}else if(creditCardPayment is IbanPayment)
{
    creditCardPayment = (IbanPayment)creditCardPayment;
    creditCardPayment.Payment();
}

HesapMakinesi.Topla(10, 30, 90, 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000);



