using System;

namespace Практическая_работа_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1979, pow = 0, row = 0, x1;
            Console.WriteLine("Начальное значение взял за 1");
            Console.WriteLine("Введите число А");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; row>=pow ; i++)
            {
                x1 = x + 1 / 3 * (a / Math.Pow(x, 2) - x);
                row = x1 - x;
                pow = x1 * x;
                x = x1;
            }
            Console.WriteLine("Значение равно = " + x);
        }
    }
}
