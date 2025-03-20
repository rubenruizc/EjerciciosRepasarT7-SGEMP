using System.Diagnostics;
using Ejercicio01.Models;
using ENT;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio01.Controllers
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

            ViewData["Saludo"] = fechaActual.Hour > 20 ? "Buenas noches" : fechaActual.Hour > 12? "Buenas tardes" : "Buenos días";
            ViewBag.FechaActual = fechaActual;

            clsPersona persona = new clsPersona(1,"Rubén","Ruiz");

            return View(persona);
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
