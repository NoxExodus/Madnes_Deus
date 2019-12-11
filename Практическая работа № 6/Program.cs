using System;

namespace Практическая_работа_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[x];
            var rnd = new Random();
            for (int i = 0; i < x; i++)
            {
               mass[i] = rnd.Next(1, 100);
            }
            Console.WriteLine("Массив до сортировки");
            foreach (int w in mass)
            {
                Console.WriteLine(w);
            }
            for (int i = 0; i < x - 1; i +=2)
            {
                        int y = 0;
                        y = mass[i];
                        mass[i] = mass[i + 1];
                        mass[i + 1] = y;
            }
            Console.WriteLine("Массив после сортировки");
            foreach (int w in mass)
            {
                Console.WriteLine(w);
            }
        }
    }
}
