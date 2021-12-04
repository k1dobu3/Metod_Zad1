using System;

namespace Metod_Zad1
{
    class Program
    {
        static void Perimetr(int a, int b, int c)
        {
            int Per = a + b + c;
            Console.WriteLine($"Периметр тругла равен = {Per}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника:");
            Perimetr(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));           
        
        }

    }
}
