using Microsoft.AspNetCore.Mvc;
using MetodosNum.Models.Metodos;
using System;

namespace MetodosNum.Controllers
{
    public class ReglaFalsaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double a, double b, double tol)
        {
            var metodo = new ReglaFalsa();

            // Ejemplo: f(x) = e^-x - x
            Func<double, double> f = x => Math.Exp(-x) - x;

            double resultado = metodo.Calcular(f, a, b, tol, 100);

            ViewBag.Resultado = $"Raíz aproximada: {resultado}";

            return View();
        }
    }
}