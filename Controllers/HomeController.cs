using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PegawaiMVC.Models;
using PegawaiMVC.Data;

namespace PegawaiMVC.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var jumlahLaki = _context.Pegawais.Count(p => p.JenisKelamin == "Laki-laki");
        var jumlahPerempuan = _context.Pegawais.Count(p => p.JenisKelamin == "Perempuan");

        ViewBag.JumlahLaki = jumlahLaki;
        ViewBag.JumlahPerempuan = jumlahPerempuan;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
