namespace UlkemWebApp.Models;

// Bölgelere Göre Kargo Fiyatları (Cargo Prices per Region)
public class KargoFiyati
{
    public int Id { get; set; } // Kargo fiyat ID'si
    public int CicekId { get; set; } // Çiçek ID
    public Cicek Cicek { get; set; } // Çiçek ile ilişki
    public int TeslimatBolgesiId { get; set; } // Teslimat bölgesi ID
    public TeslimatBolgesi TeslimatBolgesi { get; set; } // Teslimat bölgesi ile ilişki
    public decimal Fiyat { get; set; } // Bölgeye özel kargo fiyatı
}