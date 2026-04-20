using System;

namespace MetodosNum.Models.Metodos
{
    public class Cramer
    {
        // Determinante 2x2
        private double Det2x2(double[,] m)
        {
            return m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0];
        }

        public double[] Calcular(double[,] A, double[] B)
        {
            double detA = Det2x2(A);

            if (detA == 0)
                throw new Exception("El sistema no tiene solución única");

            // Matriz para X
            double[,] Ax = new double[,]
            {
                { B[0], A[0,1] },
                { B[1], A[1,1] }
            };

            // Matriz para Y
            double[,] Ay = new double[,]
            {
                { A[0,0], B[0] },
                { A[1,0], B[1] }
            };

            double x = Det2x2(Ax) / detA;
            double y = Det2x2(Ay) / detA;

            return new double[] { x, y };
        }
    }
}
