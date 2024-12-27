using UlkemWebApp.Models;
namespace UlkemWebApp.Models;


public class CicekTuru
{
    public int Id { get; set; } // Benzersiz ID
    public string Ad { get; set; } // Çiçek türü adı (Guller, Orkideler vb.)
    public ICollection<Cicek> Cicekler { get; set; } // Bu türe ait çiçekler
}
