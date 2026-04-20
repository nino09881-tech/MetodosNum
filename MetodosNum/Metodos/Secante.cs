using System;

namespace MetodosNum.Models.Metodos
{
    public class Secante
    {
        public double Calcular(Func<double, double> f, double x0, double x1, double tol, int maxIter)
        {
            double x2 = x1;

            for (int i = 0; i < maxIter; i++)
            {
                double fx0 = f(x0);
                double fx1 = f(x1);

                if (fx1 - fx0 == 0)
                    throw new Exception("División por cero en la secante");

                x2 = x1 - fx1 * (x1 - x0) / (fx1 - fx0);

                if (Math.Abs(x2 - x1) < tol)
                    return x2;

                x0 = x1;
                x1 = x2;
            }

            return x2;
        }
    }
}
