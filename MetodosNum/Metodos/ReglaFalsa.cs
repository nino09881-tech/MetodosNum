using System;

namespace MetodosNum.Models.Metodos
{
    public class ReglaFalsa
    {
        public double Calcular(Func<double, double> f, double a, double b, double tol, int maxIter)
        {
            double c = a;

            for (int i = 0; i < maxIter; i++)
            {
                c = b - (f(b) * (b - a)) / (f(b) - f(a));

                if (Math.Abs(f(c)) < tol)
                    return c;

                if (f(a) * f(c) < 0)
                    b = c;
                else
                    a = c;
            }

            return c;
        }
    }
}