using MetodosNum.Metodos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static MetodosNum.Metodos.Biseccion;

namespace MetodosNum.Controllers
{
    public class BiseccionController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

      
        [HttpPost]
        [HttpPost]
        public ActionResult Index(double a, double b)
        {
            List<Iteracion> tabla = new List<Iteracion>();

            double xl = a;
            double xu = b;
            double xr = 0;
            double xr_ant = 0;
            double error = 100;
            double tol = 0.001;

            Func<double, double> f = x => Math.Pow(x, 3) - x - 1;

            if (f(xl) * f(xu) > 0)
            {
                ViewBag.Error = "No hay raíz en ese intervalo";
                return View();
            }

            int iter = 1;

            while (error > tol && iter <= 20)
            {
                xr = (xl + xu) / 2;

                if (iter > 1)
                    error = Math.Abs((xr - xr_ant) / xr) * 100;

                double fxr = f(xr);

                tabla.Add(new Iteracion
                {
                    Iter = iter,
                    Xl = xl,
                    Xu = xu,
                    Xr = xr,
                    Fx = fxr,
                    Error = iter == 1 ? 0 : error
                });

                if (f(xl) * fxr < 0)
                    xu = xr;
                else
                    xl = xr;

                xr_ant = xr;
                iter++;
            }

            ViewBag.Tabla = tabla;
            ViewBag.Resultado = xr;

            return View();
        }

    }
}
