using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UlkemWebApp.Models;
namespace UlkemWebApp.Models;

// Sipariş Kalemleri (Order Items)
public class SiparisUrunu
{
    public int Id { get; set; } // Benzersiz ID
    public int SiparisId { get; set; } // Sipariş ID
    public Siparis Siparis { get; set; } // Sipariş ile ilişki
    public int CicekId { get; set; } // Çiçek ID
    public Cicek Cicek { get; set; } // Çiçek ile ilişki
    public int Adet { get; set; } // Çiçek miktarı
    public decimal ToplamFiyat { get; set; } // Toplam fiyat
}