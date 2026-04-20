using System;

namespace MetodosNum.Models.Metodos
{
    public class Montante
    {
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

            double pivoteAnterior = 1;

            for (int k = 0; k < n; k++)
            {
                double pivote = M[k, k];

                if (pivote == 0)
                    throw new Exception("Pivote cero, no se puede continuar");

                for (int i = 0; i < n; i++)
                {
                    if (i != k)
                    {
                        for (int j = 0; j < n + 1; j++)
                        {
                            if (j != k)
                            {
                                M[i, j] = (M[k, k] * M[i, j] - M[i, k] * M[k, j]) / pivoteAnterior;
                            }
                        }
                        M[i, k] = 0;
                    }
                }

                pivoteAnterior = pivote;
            }

            double x = M[0, 2] / M[0, 0];
            double y = M[1, 2] / M[1, 1];

            return new double[] { x, y };
        }
    }
}