using Microsoft.AspNetCore.Mvc;
using MetodosNum.Models.Metodos;

namespace MetodosNum.Controllers
{
    public class MontanteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double a11, double a12, double a21, double a22,
                                   double b1, double b2)
        {
            double[,] A = new double[,]
            {
                { a11, a12 },
                { a21, a22 }
            };

            double[] B = new double[] { b1, b2 };

            var metodo = new Montante();
            double[] r = metodo.Calcular(A, B);

            ViewBag.Resultado = $"x = {r[0]}, y = {r[1]}";

            return View();
        }
    }
}
