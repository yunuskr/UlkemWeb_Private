using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UlkemWebApp.Models;
namespace UlkemWebApp.Models;

public class Cicek
{
    public int Id { get; set; } // Benzersiz ID
    public string Ad { get; set; } // Çiçek adı (Rose Colors vb.)
    public string Kod { get; set; } // Çiçek kodu (RC001 vb.)
    public string Aciklama { get; set; } // Çiçek açıklaması (anlamı vb.)
    public string FotografUrl { get; set; } // Fotoğraf adresi
    public decimal Fiyat { get; set; } // Çiçek fiyatı
    public int CicekTuruId { get; set; } // Çiçek türü ID
    
    public CicekTuru CicekTuru { get; set; } // Çiçek türü ile ilişki
    public ICollection<GonderimAmaci> GonderimAmaclari { get; set; } // Gönderim amacı ilişkisi
    public ICollection<KargoFiyati> CargoFiyatlari { get; set; } // Bölge bazlı kargo fiyatları
}
