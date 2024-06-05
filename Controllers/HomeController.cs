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

    public IActionResult Index(Dictionary<string, Paquete> paquete)
    {
        ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
        ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
        ViewBag.ListaAereos = ORTWorld.ListaAereos;
        ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
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

    public IActionResult GuardarPaquete(int Destinos, int Hotel, int Aereo, int Excursiones)
    {
        int HotelElegido = Hotel, ExcursionElegida = Excursiones, AereoElegido = Aereo;
        if (Hotel == 0 || Aereo == 0 || Excursiones == 0)
        {
            return View("SelectPaquete");
        }
        else
        {
            HotelElegido = Hotel;
            ExcursionElegida = Excursiones;
            AereoElegido = Aereo;
            Paquete paquete1 = new Paquete(ORTWorld.ListaHoteles[HotelElegido], ORTWorld.ListaAereos[AereoElegido], ORTWorld.ListaExcursiones[ExcursionElegida]);
            string destinoSeleccionado = ORTWorld.ListaDestinos[Destinos];
            ORTWorld.IngresarPaquete(destinoSeleccionado, paquete1);
            return View("Index");
        }



    }
}
