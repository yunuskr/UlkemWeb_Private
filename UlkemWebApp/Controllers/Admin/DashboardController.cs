namespace UlkemWebApp.Controllers;
using Microsoft.AspNetCore.Mvc;

[Route("Admin")]
public class DashboardController : Controller
{
    [Route("")]
    [Route("Index")]
    public IActionResult Index()
    {
        return View(); // Views/Admin/Dashboard/Index.cshtml
    }
}
