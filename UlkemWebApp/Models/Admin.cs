using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UlkemWebApp.Models;
namespace UlkemWebApp.Models;

public class Admin
{
    public int Id { get; set; } // Benzersiz ID
    public string Kullanıcı { get; set; } // Çiçek adı (Rose Colors vb.)
    public string Sifre { get; set; } // Çiçek kodu (RC001 vb.)
 
}
