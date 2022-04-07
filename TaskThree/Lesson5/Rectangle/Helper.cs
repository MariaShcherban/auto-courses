using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle
{
    public class Helper
    {
        public static bool readSide(out double number) => double.TryParse(Console.ReadLine(), out number);
    }
}
