using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UlkemWebApp.Models;
namespace UlkemWebApp.Models;

// Kampanyalar (Promotions)
public class Kampanya
{
    public int Id { get; set; } // Kampanya ID'si
    public string Ad { get; set; } // Kampanya adı
    public string Aciklama { get; set; } // Kampanya açıklaması
    public decimal IndirimOrani { get; set; } // İndirim oranı
    public DateTime BaslangicTarihi { get; set; } // Başlangıç tarihi
    public DateTime BitisTarihi { get; set; } // Bitiş tarihi
    public ICollection<Cicek> IndirimliCicekler { get; set; } // Kampanya dahilindeki çiçekler
}