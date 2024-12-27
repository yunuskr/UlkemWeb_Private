using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UlkemWebApp.Models;
namespace UlkemWebApp.Models;

// Hakkımızda (About Us)
public class Hakkimizda
{
    public int Id { get; set; } // Benzersiz ID
    public string Baslik { get; set; } // Başlık
    public string Icerik { get; set; } // İçerik
}