using Microsoft.EntityFrameworkCore;

namespace UlkemWebApp.Models;
public class AppDbContext:DbContext
{
     public DbSet<BlogYazisi>? BlogYazisi { get; set; }  
    public DbSet<Cicek>?  Cicek { get; set; }
     public DbSet<CicekTuru>?  CicekTuru { get; set; }
     
     public DbSet<AdminLogin>? AdminGiris {get; set;}
     public DbSet<GonderimAmaci>?  GonderimAmaci { get; set; }
     public DbSet<Hakkimizda>?  Hakkimizda { get; set; }
     public DbSet<IletisimFormu>?  IletisimFormu { get; set; }
     public DbSet<Kampanya>?  Kampanya { get; set; }
     public DbSet<KargoFiyati>?  KargoFiyati { get; set; }
     public DbSet<Kullanici>?  Kullanici { get; set; }
     public DbSet<OzelGun>?  OzelGun { get; set; }
     public DbSet<Sepet>?  Sepet { get; set; }
     public DbSet<SepetUrunu>?  SepetUrunu { get; set; }
     public DbSet<Siparis>?  Siparis { get; set; }
     public DbSet<SiparisUrunu>?  SiparisUrunu { get; set; }
     public DbSet<TeslimatBolgesi>?  TeslimatBolgesi { get; set; }
     public DbSet<Yorum>?  Yorum { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
    "Server=94.73.170.63;Database=u6793934_dbA4F;User ID=u6793934_userA4F;Password=Harun151223Harun;TrustServerCertificate=True;"
);
    }

}