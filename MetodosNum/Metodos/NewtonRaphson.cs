using System;

namespace MetodosNum.Models.Metodos
{
    public class NewtonRaphson
    {
        public double Calcular(Func<double, double> f, Func<double, double> df,
                               double x0, double tol, int maxIter)
        {
            double x1 = x0;

            for (int i = 0; i < maxIter; i++)
            {
                double fx = f(x0);
                double dfx = df(x0);

                if (dfx == 0)
                    throw new Exception("La derivada es cero");

                x1 = x0 - fx / dfx;

                if (Math.Abs(x1 - x0) < tol)
                    return x1;

                x0 = x1;
            }

            return x1;
        }
    }
}