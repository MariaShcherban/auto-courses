using System;

namespace ProjectOne
{
    class Program
    {
        public bool EnterNumber(out double number)
        {
            Console.WriteLine("Input number and press 'Enter'");
            return double.TryParse(Console.ReadLine(), out number);
        }

        static void Main(string[] args)
        {
            double x, y, z, result;
            Program program = new Program();

            if (program.EnterNumber(out x) && program.EnterNumber(out y) && program.EnterNumber(out z))
            {
                result = (x + y) * (Math.Pow(z, 2) + 1);
                Console.WriteLine($"First expression result is: {result}");

                if (y > 0)
                {
                    result = (x % z - 1) * Math.Sqrt(y);
                    Console.WriteLine($"Second expression result is: {result}");
                }
                else
                    Console.WriteLine("y must be > 0 to evaluate the second expression");

                if (z > 0)
                {
                    result = (x * y + y * z) / Math.Pow(z, 3);
                    Console.WriteLine($"Third expression result is: {result}");
                }
                else
                    Console.WriteLine("z must be > 0 to evaluate the third expression");
            }
            else
                Console.WriteLine("Only numbers are allowed");
        }
    }
}
