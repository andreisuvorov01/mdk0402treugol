using System;

namespace treugolnik_mdk0402
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите 1 сторону");
            Int32 a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите 2 сторону");
            Int32 b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите 3 сторону");
            Int32 c = Convert.ToInt32(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Треугольник возможен");
            }
            else
                Console.WriteLine("Треугольник невозможен");
        }
    }
}
