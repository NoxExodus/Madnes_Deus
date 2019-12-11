using System;

namespace Практическа_работа_7
{
    class Program
    {

        static void Main(string[] args)
        {

            //ЭТО 6 ЗАДАНИЕ!!!
            Console.WriteLine("Введите размерность массива NxN");
            int N = Convert.ToInt32(Console.ReadLine());
            int k = N + 2, x, left, right, up, down, upleft, upright, downleft, downright;
            int[,] dimass = new int[k, k];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    dimass[i, j] = 0;
                }
            }
            var rnd = new Random();
             for (int i = 0; i < k-2; i++)
             {
                 for (int j = 0; j < k-2; j++)
                 {
                     dimass[i+1, j+1] = rnd.Next(1, 1000);
                 }
             }
            Console.WriteLine("Матрица");
            for (int i = 0; i < k-2; i++)
            {
                for (int j = 0; j < k-2; j++)
                {
                    Console.Write(dimass[i+1, j+1] + ",");
                }
                Console.WriteLine("\t");
            }
            int max = dimass[0, 0];
            for (int i = 0; i < k-2; i++)
            {
                for (int j = 0; j < k-2; j++)
                {
                    x = dimass[i+1, j+1];
                    left = dimass[i + 1, j];
                    right = dimass[i + 1, j + 2];
                    up = dimass[i, j + 1];
                    down = dimass[i + 2, j + 1];
                    upleft = dimass[i, j];
                    upright = dimass[i, j + 2];
                    downleft = dimass[i + 2, j];
                    downright = dimass[i + 2, j + 2];
                    if ((x<left)&&(x <up) && (x <down) && (x <right) && (x <upleft) && (x <upright) && (x <downleft) && (x <downright))
                    {
                        if(x>=max)
                        {
                            max = x;
                        }
                    }
                }
            }
            Console.WriteLine("Самый большой локальный минимум = " + max);
        }
    }
}
