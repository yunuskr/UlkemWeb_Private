using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UlkemWebApp.Models;
// Blog Yazıları (Blog Posts)
namespace UlkemWebApp.Models;

public class AdminLogin
{
    public int Id { get; set; } // Blog yazısı ID
    public string Kullanici { get; set; } // Blog başlığı
    public string Sifre { get; set; } // Blog içeriği
}
