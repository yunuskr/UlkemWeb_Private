using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UlkemWebApp.Models;
namespace UlkemWebApp.Models;

// Siparişler (Orders)
public class Siparis
{
    public int Id { get; set; } // Sipariş ID
    public string MusteriAd { get; set; } // Müşteri adı
    public string MusteriTelefon { get; set; } // Müşteri telefon numarası
    public string MusteriAdres { get; set; } // Teslimat adresi
    public DateTime SiparisTarihi { get; set; } // Sipariş tarihi
    public ICollection<SiparisUrunu> SiparisUrunleri { get; set; } // Siparişteki ürünler
}