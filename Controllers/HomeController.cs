﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP08.Models;

namespace TP08.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Series = BDSeries.ListarSeries();
        return View();
    }
    public List<Actores> ListarActoresAJAX(int IdS)
    {
        ViewBag.ListaActores = BDSeries.ListarActores(IdS);
        return ViewBag.ListaActores;
    }
    public List<Temporadas> ListarTemporadasAJAX(int IdS)
    {
        ViewBag.ListaTemporadas = BDSeries.ListarTemporadasAJAX(IdS);
        return ViewBag.ListaActores;
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
