using BL;
using DAL;
using Ejercicio03.Models;
using Ejercicio04.Models.VM;
using ENT;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio03.Controllers
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
            return View();
        }

        public IActionResult ListadoPersonas()
        {
            List<clsPersona> personas = clsListadoPersonasBL.obtenerPersonasBL();
            return View(personas);
        }

        public IActionResult ListadoDepartamentos()
        {
            List<clsDepartamento> departamentos = clsListadoDepartamentoBL.obtenerDepartamentosBL();
            return View(departamentos);
        }

        public IActionResult EditarPersonas()
        {
            clsPersona persona = clsListadoPersonasBL.obtenerPersonaRandomBL(); // Llamada al método estático

            clsEditarPersonaVM vm = new clsEditarPersonaVM(persona);

            return View(vm);
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
