using System;

namespace ProjectOne
{
    class Program
    {
        public bool EnterDimension(out double dimension)
        {
            Console.WriteLine("Input dimension and press 'Enter'");
            return double.TryParse(Console.ReadLine(), out dimension);
        }

        static void Main(string[] args)
        {
            double a, b, c, diagonalLength;
            Program program = new Program();

            if (program.EnterDimension(out a) && program.EnterDimension(out b) && program.EnterDimension(out c))
            {
                if (a > 0 && b > 0 && c > 0)
                {
                    diagonalLength = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2));
                    Console.WriteLine($"Parallelepiped diagonal length is:  {diagonalLength}");
                }
                else
                    Console.WriteLine("All 3 dimensions must be > 0");
            }
            else
                Console.WriteLine("All dimensions must be numbers");
        }
    }
}
