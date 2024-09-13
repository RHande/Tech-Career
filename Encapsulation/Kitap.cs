namespace Encapsulation;

public class Kitap
{
    
    
    public string Baslik { get; set; }
    public string Aciklama { get; set; }
    public string YazarAdi { get; set; }
    public string YazarSoyadi { get; set; }
    public string YazarTamAdı => $"{YazarAdi} {YazarSoyadi}";//Bu da yine sadece okuma izni verir.
    public string Yayinevi { get; set; }
    public int BasimYili { get; set; }

    public string BasimYiliYayinevi => $"{BasimYili} - {Yayinevi}";
    
    public override string ToString()
    {
        return $"Kitap Adı: {Baslik}\nKitap Açıklaması: {Aciklama}\nYazar Adı: {YazarAdi}\nYazar Soyadı: {YazarSoyadi}\nYazarın Tam Adı: {YazarTamAdı}\nYayınevi: {Yayinevi}\nBasım Yılı: {BasimYili}\nBasım Yılı ve Yayınevi: {BasimYiliYayinevi}";
    }
}


