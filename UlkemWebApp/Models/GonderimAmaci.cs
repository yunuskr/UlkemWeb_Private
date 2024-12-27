using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UlkemWebApp.Models;
namespace UlkemWebApp.Models;

// Gönderim Amaçları (Occasions)
public class GonderimAmaci
{
    public int Id { get; set; } // Benzersiz ID
    public string Ad { get; set; } // Gönderim amacı adı (Dogum Gunu, Sevgililer Gunu vb.)
    public ICollection<Cicek> Cicekler { get; set; } // Bu amaç için uygun çiçekler
}