using System;

namespace ProjectOne
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, diagonalLength;

            Console.WriteLine("Please enter 3 dimensions of a Parallelepiped one by one and press Enter after each dimension");
            if (double.TryParse(Console.ReadLine(), out a))
            {
                if (double.TryParse(Console.ReadLine(), out b))
                {
                    if (double.TryParse(Console.ReadLine(), out c))
                    {
                        if (a > 0 && b > 0 && c > 0)
                        { 
                        diagonalLength = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2));
                        Console.WriteLine($"Parallelepiped diagonal length is:  {diagonalLength}");
                        }
                        else
                        {
                            Console.WriteLine("All 3 dimensions must be > 0");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"The third dimension is not a number");
                    }
                }
                else
                {
                    Console.WriteLine($"The second dimension is not a number");
                }
            }
            else
            {
                Console.WriteLine($"The first dimension is not a number");
            }
        }
    }
}
