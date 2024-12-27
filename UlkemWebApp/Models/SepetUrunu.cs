using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UlkemWebApp.Models;
namespace UlkemWebApp.Models;

// Sepet Ürünleri (Cart Items)
public class SepetUrunu
{
    public int Id { get; set; } // Benzersiz ID
    public int SepetId { get; set; } // Sepet ID
    public Sepet Sepet { get; set; } // Sepet ile ilişki
    public int CicekId { get; set; } // Çiçek ID
    public Cicek Cicek { get; set; } // Çiçek ile ilişki
    public int Adet { get; set; } // Çiçek miktarı
    public decimal ToplamFiyat { get; set; } // Toplam fiyat
}