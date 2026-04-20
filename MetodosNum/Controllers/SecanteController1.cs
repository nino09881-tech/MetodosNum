using Microsoft.AspNetCore.Mvc;
using MetodosNum.Models.Metodos;
using System;

namespace MetodosNum.Controllers
{
    public class SecanteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double x0, double x1, double tol)
        {
            var metodo = new Secante();

            // Ejemplo: f(x) = e^-x - x
            Func<double, double> f = x => Math.Exp(-x) - x;

            double resultado = metodo.Calcular(f, x0, x1, tol, 100);

            ViewBag.Resultado = $"Raíz aproximada: {resultado}";

            return View();
        }
    }
}