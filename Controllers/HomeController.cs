using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnePiece.Data;
using OnePiece.Models;
using Microsoft.EntityFrameworkCore;
using OnePiece.ViewModels;

namespace OnePiece.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

        //Injeção de dependência
    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        HomeVM home = new()
        {
            Personagens = _context.Personagens.ToList(),
            Tripulacoes = _context.Tripulacoes.ToList()
        };
        return View(home);
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