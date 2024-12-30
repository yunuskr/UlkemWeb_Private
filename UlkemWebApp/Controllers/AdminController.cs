using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UlkemWebApp.Models;

namespace UlkemWebApp.Controllers;

public class AdminController : Controller
{
    private readonly ILogger<AdminController> _logger;

    public AdminController(ILogger<AdminController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Dashboard()
        {
            return View();
        }

    public IActionResult CicekListesi()
    {
        return View();
    }

    public IActionResult Siparisler()
    {
        return View();
    }   
}
