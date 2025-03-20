using Ejercicio02.Models;
using ENT;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio02.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var fechaActual = DateTime.Now;

            ViewData["Saludo"] = fechaActual.Hour > 20? "Buenas noches" : fechaActual.Hour > 12? "Buenas tardes" : "Buenos días";

            ViewBag.FechaActual = fechaActual;

            return View();
        }

        public IActionResult ListadoPersonas()
        {
            List<clsPersona> listadoDePersonas = DAL.clsListadoPersonasDAL.obtenerPersonas();

            return View(listadoDePersonas);
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
}
