namespace Polymorphsym.Models;

public class PaypalPayment : BasePayment
{
    public string Email { get; set; }
    
    
    
    public override void Payment()
    {
        Console.WriteLine($"{Email} hesabından {Amount} TL tutarında ödeme yapıldı.");
    }
}