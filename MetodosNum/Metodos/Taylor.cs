using System;

namespace MetodosNum.Models.Metodos
{
    public class Taylor
    {
        public double Calcular(double x, int n)
        {
            double suma = 0;

            for (int i = 0; i <= n; i++)
            {
                suma += Math.Pow(x, i) / Factorial(i);
            }

            return suma;
        }

        private double Factorial(int n)
        {
            double f = 1;
            for (int i = 1; i <= n; i++)
                f *= i;

            return f;
        }
    }
}