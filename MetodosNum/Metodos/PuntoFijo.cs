using System;

namespace MetodosNum.Models.Metodos
{
    public class PuntoFijo
    {
        public double Calcular(Func<double, double> g, double x0, double tol, int maxIter)
        {
            double x1 = x0;

            for (int i = 0; i < maxIter; i++)
            {
                x1 = g(x0);

                if (Math.Abs(x1 - x0) < tol)
                    return x1;

                x0 = x1;
            }

            return x1;
        }
    }
}