using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UlkemWebApp.Models;
namespace UlkemWebApp.Models;

// Teslimat Bölgeleri (Delivery Regions)
public class TeslimatBolgesi
{
    
    public int Id { get; set; } // Bölge ID
    public string BolgeAdi { get; set; } // Bölge adı (Örneğin, "Istanbul Avrupa", "Pendik")
    public decimal TeslimatUcreti { get; set; } // Bölgeye teslimat ücreti
    public ICollection<KargoFiyati> CargoFiyatlari { get; set; } // Bu bölgedeki çiçeklerin kargo fiyatları
}