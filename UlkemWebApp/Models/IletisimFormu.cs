using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UlkemWebApp.Models;
namespace UlkemWebApp.Models;

// İletişim Formu (Contact Form)
public class IletisimFormu
{
    public int Id { get; set; } // Form ID
    public string AdSoyad { get; set; } // Gönderen adı
    public string Email { get; set; } // Gönderen e-posta
    public string Mesaj { get; set; } // Mesaj içeriği
    public DateTime GonderimTarihi { get; set; } // Gönderim tarihi
}