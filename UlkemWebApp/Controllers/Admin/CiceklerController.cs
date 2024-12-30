namespace UlkemWebApp.Controllers.Admin;
using Microsoft.AspNetCore.Mvc;

[Route("Admin/[controller]")]
public class CiceklerController : Controller
{

    [Route("Index")]
    public IActionResult Index()
    {
        return View(); // Views/Admin/Cicekler/Index.cshtml
    }

    public IActionResult Ekle()
    {
        return View(); // Views/Admin/Cicekler/Ekle.cshtml
    }

    public IActionResult Guncelle(int id)
    {
        return View(); // Views/Admin/Cicekler/Guncelle.cshtml
    }

    public IActionResult Sil(int id)
    {
        // Çiçek silme işlemi
        return RedirectToAction("Index");
    }
}
