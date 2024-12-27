// Yorumlar ve Puanlama (Reviews & Ratings)
using UlkemWebApp.Models;
namespace UlkemWebApp.Models;

public class Yorum
{
    public int Id { get; set; } // Yorum ID'si
    public int CicekId { get; set; } // Çiçek ID
    public Cicek Cicek { get; set; } // Çiçek ile ilişki
    public string MusteriAd { get; set; } // Yorum yapan müşteri adı
    public string Icerik { get; set; } // Yorum içeriği
    public int Puan { get; set; } // Puan (1-5)
    public DateTime YorumTarihi { get; set; } // Yorum tarihi
}
