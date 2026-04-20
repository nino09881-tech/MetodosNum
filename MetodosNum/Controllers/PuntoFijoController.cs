using Microsoft.AspNetCore.Mvc;
using MetodosNum.Models.Metodos;
using System;

namespace MetodosNum.Controllers
{
    public class PuntoFijoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double x0, double tol)
        {
            var metodo = new PuntoFijo();

            // g(x) = e^(-x)
            Func<double, double> g = x => Math.Exp(-x);

            double resultado = metodo.Calcular(g, x0, tol, 100);

            ViewBag.Resultado = $"Raíz aproximada: {resultado}";

            return View();
        }
    }
}