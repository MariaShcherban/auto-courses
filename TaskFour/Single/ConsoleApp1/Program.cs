using SingleInstance;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The fist hash = {SingleClass.GetInstance().GetHashCode()}");
            Console.WriteLine($"The second hash = {SingleClass.GetInstance().GetHashCode()}");
        }
    }
}
