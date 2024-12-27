using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UlkemWebApp.Models;
namespace UlkemWebApp.Models;


// Özel Günler ve Etkinlikler (Special Events)
public class OzelGun
{
    public int Id { get; set; } // Özel gün ID
    public string Ad { get; set; } // Özel gün adı
    public DateTime Tarih { get; set; } // Tarih
    public ICollection<Cicek> OnerilenCicekler { get; set; } // Bu özel gün için önerilen çiçekler
}