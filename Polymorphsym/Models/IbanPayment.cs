namespace Polymorphsym.Models;

public class IbanPayment : BasePayment
{
    public string IbanNo { get; set; }
    public string FullName { get; set; }
    
    
    public override void Payment()
    {
        Console.WriteLine($"{FullName} adına ait {IbanNo} IBAN numaralı hesaba {Amount} TL tutarında ödeme yapıldı.");
    }
}