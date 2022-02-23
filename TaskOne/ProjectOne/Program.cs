using System;

namespace ProjectOne
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, result;

            Console.WriteLine("Please enter 3 numbers one by one and press Enter after every number");
            if (double.TryParse(Console.ReadLine(), out x)) 
            {
                if (double.TryParse(Console.ReadLine(), out y))
                {
                    if (double.TryParse(Console.ReadLine(), out z))
                    {
                        result = (x + y) * (Math.Pow(z, 2) + 1);
                        Console.WriteLine($"First expression result is: {result}");

                        if (y > 0)
                        {
                            result = (x % z - 1) * Math.Sqrt(y);
                            Console.WriteLine($"Second expression result is: {result}");
                        }
                        else
                        {
                            Console.WriteLine("y must be > 0 to evaluate the second expression");
                        }

                        if (z > 0)
                        {
                            result = (x * y + y * z) / Math.Pow(z, 3);
                            Console.WriteLine($"Third expression result is: {result}");
                        }
                        else
                        {
                            Console.WriteLine("z must be > 0 to evaluate the third expression");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"The third input is not a number");
                    }
                }
                else
                {
                    Console.WriteLine($"The second input is not a number");
                }
            } 
            else
            {
                Console.WriteLine($"The first input is not a number");
            }
        }
    }
}
