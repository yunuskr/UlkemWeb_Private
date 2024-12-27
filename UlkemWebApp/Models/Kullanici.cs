using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UlkemWebApp.Models;
namespace UlkemWebApp.Models;

// Kullanıcılar (Users)
public class Kullanici
{
    public int Id { get; set; } // Kullanıcı ID
    public string KullaniciAdi { get; set; } // Kullanıcı adı
    public string Email { get; set; } // E-posta adresi
    public string Sifre { get; set; } // Şifre
    public ICollection<Siparis> Siparisler { get; set; } // Kullanıcının siparişleri
    public Sepet Sepet { get; set; } // Kullanıcının sepeti
}