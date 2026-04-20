using System;

namespace MetodosNum.Models.Metodos
{
    public class EliminacionGaussiana
    {
        // Sistema 2x2
        public double[] Calcular(double[,] A, double[] B)
        {
            int n = 2;

            // Matriz aumentada [A|B]
            double[,] M = new double[n, n + 1];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    M[i, j] = A[i, j];

                M[i, n] = B[i];
            }

            // 🔻 Eliminación hacia adelante
            for (int i = 0; i < n - 1; i++)
            {
                if (M[i, i] == 0)
                    throw new Exception("Pivote cero, no se puede continuar");

                for (int k = i + 1; k < n; k++)
                {
                    double factor = M[k, i] / M[i, i];

                    for (int j = i; j < n + 1; j++)
                        M[k, j] -= factor * M[i, j];
                }
            }

            // 🔺 Sustitución hacia atrás
            double[] x = new double[n];

            for (int i = n - 1; i >= 0; i--)
            {
                double suma = M[i, n];

                for (int j = i + 1; j < n; j++)
                    suma -= M[i, j] * x[j];

                x[i] = suma / M[i, i];
            }

            return x;
        }
    }
}