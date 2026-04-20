using System;

namespace MetodosNum.Models.Metodos
{
    public class Inversa
    {
        public double[] Calcular(double[,] A, double[] B)
        {
            double det = A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0];

            if (det == 0)
                throw new Exception("La matriz no tiene inversa");

            // Matriz inversa 2x2
            double[,] inv = new double[,]
            {
                {  A[1,1] / det, -A[0,1] / det },
                { -A[1,0] / det,  A[0,0] / det }
            };

            // Multiplicar A⁻¹ * B
            double x = inv[0, 0] * B[0] + inv[0, 1] * B[1];
            double y = inv[1, 0] * B[0] + inv[1, 1] * B[1];

            return new double[] { x, y };
        }
    }
}