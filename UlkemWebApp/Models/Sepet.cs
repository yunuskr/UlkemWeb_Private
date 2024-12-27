using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UlkemWebApp.Models;
namespace UlkemWebApp.Models;

// Sepet (Cart)
public class Sepet
{
    public int Id { get; set; } // Sepet ID
    public string MusteriId { get; set; } // Müşteri kimliği (oturum bazlı olabilir)
    public ICollection<SepetUrunu> SepetUrunleri { get; set; } // Sepetteki ürünler
}