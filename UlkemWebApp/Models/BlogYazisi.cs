using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UlkemWebApp.Models;
// Blog Yazıları (Blog Posts)
namespace UlkemWebApp.Models;

public class BlogYazisi
{
    public int Id { get; set; } // Blog yazısı ID
    public string Baslik { get; set; } // Blog başlığı
    public string Icerik { get; set; } // Blog içeriği
    public string FotografUrl { get; set; } // Blog görseli
    public DateTime YayimTarihi { get; set; } // Yayın tarihi
    public ICollection<Yorum> Yorumlar { get; set; } // Blog yazısına yapılan yorumlar
}
