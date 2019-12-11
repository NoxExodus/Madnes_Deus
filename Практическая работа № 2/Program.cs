using System;

namespace Практическая_работа___2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, symm, pro = 1,res = 0;
            Console.WriteLine("Введите число элементов суммы");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                pro = pro * i;
                symm = (1 + i) / pro;
                res = res + symm;
            }
            Console.WriteLine("Значение суммы равно = "+res);
        }
    }
}
