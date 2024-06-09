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

    public IActionResult Index(Dictionary<string, Paquete> paquete, Paquete paquete1)
    {
        ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
        ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
        ViewBag.ListaAereos = ORTWorld.ListaAereos;
        ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;

        if (ORTWorld.Paquetes == null)
        {
        ViewBag.DiccionarioPaquetes = new Dictionary<string, Paquete>();
        }
        else
        {
        ViewBag.DiccionarioPaquetes = ORTWorld.Paquetes;
        }
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
        if (Hotel < 1 || Aereo < 1 || Excursiones < 1 || Destinos < 1 || Hotel > ORTWorld.ListaHoteles.Count || Aereo > ORTWorld.ListaAereos.Count || Excursiones > ORTWorld.ListaExcursiones.Count || Destinos > ORTWorld.ListaDestinos.Count)
        {
            return RedirectToAction("SelectPaquete");
        }
        else
        {
            
            Paquete paquete1 = new Paquete(ORTWorld.ListaHoteles[Hotel - 1], ORTWorld.ListaAereos[Aereo - 1], ORTWorld.ListaExcursiones[Excursiones - 1]);
            string destinoSeleccionado = ORTWorld.ListaDestinos[Destinos - 1];
            ORTWorld.IngresarPaquete(destinoSeleccionado, paquete1);
            return RedirectToAction("Index");
        }



    }
}
