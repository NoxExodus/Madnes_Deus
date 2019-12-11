using System;

namespace Практическая_работа___3
{
    class Program
    {
        static void Main(string[] args)
        {
            double symm = 1, result = 0, pro = 1;
            Console.WriteLine("Введите кол-во элементов суммы");
            double x = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; symm<=Math.Exp(x); i++)
            {
                pro = pro * i;
                result = result + Math.Pow(x, i) / pro;
                symm = symm + result;
            }
            Console.WriteLine("Значение суммы = " + symm);
        }
    }
}
