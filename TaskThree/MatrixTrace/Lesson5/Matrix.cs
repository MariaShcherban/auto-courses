using System;

namespace Lesson5
{
    public class Matrix
    {
        private const int maxMatrixElement = 50;

        public bool readDimension(out int number) => int.TryParse(Console.ReadLine(), out number);

        public int[, ] GenerateMatrix(int m, int n)
        {
            int[, ] matrix = new int[m, n];
            Random rnd = new Random();
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    matrix[i, j] = rnd.Next(maxMatrixElement);
            return matrix;
        }

        public void PrintMatrix(int[, ] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j]} ");
                Console.WriteLine();
            }
        }

        public int GetTraceOfSquareMatrix(int[, ] matrix)
        {
            int trace = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                trace += matrix[i, i];
            return trace;
        }

        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            int n, m;

            Console.WriteLine("Enter matrix dimensions");
            if (matrix.readDimension(out m) && matrix.readDimension(out n))
            {
                int[,] array = matrix.GenerateMatrix(m, n);
                Console.WriteLine("Matrix was generated");
                matrix.PrintMatrix(array);
                if (m == n)
                {
                    Console.WriteLine($"Matrix trace = {matrix.GetTraceOfSquareMatrix(array)}");
                }
                else
                    Console.WriteLine("Matrix must be square to calculate trace");
            }
            else
                Console.WriteLine("Matrix dimensions must be integer values");
        }
    }
}
