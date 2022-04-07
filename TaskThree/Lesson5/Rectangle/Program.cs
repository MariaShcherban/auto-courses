using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rectangle sides");
            double side1, side2;
            if (Helper.readSide(out side1) && Helper.readSide(out side2))
            {
                if ((side1 > 0) && (side2 > 0))
                {
                    Rectangle rectangle = new Rectangle(side1, side2);
                    Console.WriteLine($"Rectangle area = {rectangle.AreaCalculator()}");
                    Console.WriteLine($"Rectangle perimeter = {rectangle.PerimeterCalculator()}");
                }
                else
                    Console.WriteLine("Rectangle sides must be > 0");
            }
            else
                Console.WriteLine("Rectangle side must be a number");
        }
    }
}