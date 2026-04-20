using System;

namespace MetodosNum.Models.Metodos
{
    public class GaussJordan
    {
        // Resuelve sistema 2x2
        public double[] Calcular(double[,] A, double[] B)
        {
            int n = 2;

            // Matriz aumentada
            double[,] M = new double[n, n + 1];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    M[i, j] = A[i, j];

                M[i, n] = B[i];
            }

            // Gauss-Jordan
            for (int i = 0; i < n; i++)
            {
                double pivote = M[i, i];

                if (pivote == 0)
                    throw new Exception("No se puede resolver (pivote 0)");

                // Hacer pivote = 1
                for (int j = 0; j < n + 1; j++)
                    M[i, j] /= pivote;

                // Hacer ceros en otras filas
                for (int k = 0; k < n; k++)
                {
                    if (k != i)
                    {
                        double factor = M[k, i];
                        for (int j = 0; j < n + 1; j++)
                            M[k, j] -= factor * M[i, j];
                    }
                }
            }

            return new double[] { M[0, 2], M[1, 2] };
        }
    }
}