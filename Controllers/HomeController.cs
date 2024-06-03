using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04.Models;

namespace TP04.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(Dictionary<string, Paquete> paquete, int Hotel, int Aereo, int Excursion)
    {
        ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
        ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
        ViewBag.ListaAereos = ORTWorld.ListaAereos;
        ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
        int HotelElegido = Hotel;
        int AereoElegido = Aereo;
        int ExcursionElegida = Excursion;

        Paquete paquete1 = new Paquete(ORTWorld.ListaHoteles[HotelElegido], ORTWorld.ListaAereos[AereoElegido], ORTWorld.ListaExcursiones[ExcursionElegida]);
        ViewBag.Diccionario = ORTWorld.Paquetes;
        return View();
    }

    public IActionResult SelectPaquete()
    {
        ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
        ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
        ViewBag.ListaAereos = ORTWorld.ListaAereos;
        ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
        return View();
    }
}
