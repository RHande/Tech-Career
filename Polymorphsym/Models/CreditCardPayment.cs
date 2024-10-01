namespace Polymorphsym.Models;

public class CreditCardPayment : BasePayment
{
    public string CardNumber { get; set; }
    public string CVV { get; set; }
    public string FullName { get; set; }
    public string ExpiryDate { get; set; }
    
    
    public override void Payment()
    {
        Console.WriteLine($"{FullName} adına ait {CardNumber} kart numaralı kredi kartı ile {Amount} TL tutarında ödeme yapıldı.");
    }
}