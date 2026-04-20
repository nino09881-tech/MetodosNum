using Microsoft.AspNetCore.Mvc;
using MetodosNum.Models.Metodos;

namespace MetodosNum.Controllers
{
    public class TaylorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double x, int n)
        {
            var metodo = new Taylor();

            double resultado = metodo.Calcular(x, n);

            ViewBag.Resultado = $"Aproximación: {resultado}";

            return View();
        }
    }
}