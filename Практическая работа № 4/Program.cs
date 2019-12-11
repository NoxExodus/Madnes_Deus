using System;

namespace Практическая_работа_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            Console.WriteLine("Введите число");
            int m = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; x<m;i++)
            {
                x = Math.Pow(i, 2);
            }
            if (x == m)
            {
                Console.WriteLine("Возможно!");
            }
            else
            {
                Console.WriteLine("Невозможно!");
            }
        }
    }
}
