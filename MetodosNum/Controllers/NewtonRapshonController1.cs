using Microsoft.AspNetCore.Mvc;
using MetodosNum.Models.Metodos;
using System;

namespace MetodosNum.Controllers
{
    public class NewtonRaphsonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double x0, double tol)
        {
            var metodo = new NewtonRaphson();

            // f(x) = e^-x - x
            Func<double, double> f = x => Math.Exp(-x) - x;

            // f'(x) = -e^-x - 1
            Func<double, double> df = x => -Math.Exp(-x) - 1;

            double resultado = metodo.Calcular(f, df, x0, tol, 100);

            ViewBag.Resultado = $"Raíz aproximada: {resultado}";

            return View();
        }
    }
}