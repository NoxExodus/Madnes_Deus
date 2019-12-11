using System;

namespace Ветвление
{
    class Program
    {
     static int Work1(int x)
        {
            int y;
            if (x < -1)
            {
                y = 1 / x;
            }
            if (x >= -1 && x <= 4)
            {
                y = x * x;
            }
            else
            {
                y = 4;
            }
            Console.WriteLine("Значение функции равно = " + y);
            return y;
        }
        static int Work2(int x, int y)
        {
            if(x < 0 && y < 0)
            {
                x = Math.Abs(x);
                y = Math.Abs(y);
            }
            if(x < 0 || y < 0)
            {
                x /= 2;
                y /= 2;
            }
            if((x>0 && x<=2)&&(y > 0 && y <= 2))
            {
                x /= 10;
                y /= 10;
            }
            else
            {
                x = x;
                y = y;
            }
            Console.WriteLine("Значение x = " + x + "Значение y = " + y);
            return (x + y);
        }
        static void Work3(int r, int x, int y, int x0, int y0)
        {
            double s;
            s = Math.Sqrt((x * x) + (y * y));
            if (s > r)
            {
                Console.WriteLine("Точка не принадлежит окружности");
            }
            else
            {
                Console.WriteLine("Точка принадлежит окружности");
            }
        }
       
        static bool Work4(int x)
        {
            int x1 = 0, x2 = 0, x3 = 0, x4=0, symm;
            bool result = true;
            Console.WriteLine("Задача: квадрат заданного трехзначного числа равен кубу суммы цифр этого числа.");
            while (result)
            {
                Console.WriteLine("Введите число:");
                x = Convert.ToInt32(Console.ReadLine());
                if (x < 1000 && x >= 100)
                {
                    result = false;
                }
                else
                {
                    Console.WriteLine("Введите 3-х значное число!");
                }
            }
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        x1 = x / 100;
                        break;
                    case 1:
                        x2 = (x - (x1 * 100)) / 10;
                        break;
                    case 2:
                        x3 = (x - (x1 * 100 + x2 * 10));
                        break;
                }
            }
            symm = (x1 + x2 + x3)* (x1 + x2 + x3) * (x1 + x2 + x3);
            x = x * x;
            if (x==symm)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            Console.WriteLine("Квадрат заданного трехзначного числа равен кубу суммы цифр этого числа. Результат:" + result);
            result = true;
            Console.WriteLine("Задача: сумма двух первых цифр заданного четырехзначного числа равна сумме двух его последних цифр.");
            while (result)
            {
                Console.WriteLine("Введите число:");
                x = Convert.ToInt32(Console.ReadLine());
                if (x < 10000 && x >= 1000)
                {
                    result = false;
                }
                else
                {
                    Console.WriteLine("Введите 4-х значное число!");
                }
            }
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        x1 = x / 1000;
                        break;
                    case 1:
                        x2 = (x - (x1 * 1000)) / 100;
                        break;
                    case 2:
                        x3 = (x - (x1 * 1000 + x2 * 100)) / 10;
                        break;
                    case 3:
                        x4 = (x - (x1 * 1000 + x2 * 100 + x3 * 10));
                        break;
                }
            }
            symm = x1 + x2;
            x = x3 + x4;
            if (x == symm)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            Console.WriteLine("Сумма двух первых цифр заданного четырехзначного числа равна сумме двух его последних цифр. Результат:" + result);
            result = true;
            Console.WriteLine("Задача: среди цифр заданного трехзначного числа есть одинаковые.");
            while (result)
            {
                Console.WriteLine("Введите число:");
                x = Convert.ToInt32(Console.ReadLine());
                if (x < 1000 && x >= 100)
                {
                    result = false;
                }
                else
                {
                    Console.WriteLine("Введите 3-х значное число!");
                }
            }
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        x1 = x / 100;
                        break;
                    case 1:
                        x2 = (x - (x1 * 100)) / 10;
                        break;
                    case 2:
                        x3 = (x - (x1 * 100 + x2 * 10));
                        break;
                }
            }
            if (x1==x2 || x1==x3 || x2==x3)
            {
                result = true;
                Console.WriteLine("Cреди цифр заданного трехзначного числа есть одинаковые. Результат:" + result);
            }
            else
            {
                result = false;
                Console.WriteLine("Cреди цифр заданного трехзначного числа есть одинаковые. Результат:" + result);
            }
            result = true;
            Console.WriteLine("Задача: среди первых трех цифр из дробной части заданного положительного вещественного числа есть цифра 0.");
            return result;
        }
        static void Work5( int x, int y, int x2, int y2, int x3, int y3, int x4, int y4)
        {
           
            double paral, dlin, paral2, dlin2;
            dlin = Math.Sqrt(Math.Pow((x2 - x), 2) - Math.Pow((y2 - y), 2));
            dlin2 = Math.Sqrt(Math.Pow((x4 - x3), 2) - Math.Pow((y4 - y3), 2));
            paral = Math.Sqrt(Math.Pow((x3 - x), 2) - Math.Pow((y3 - y), 2));
            paral2 = Math.Sqrt(Math.Pow((x4 - x2), 2) - Math.Pow((y4 - y2), 2));
            if ((dlin==dlin2)&&(paral==paral2))
            {
                Console.WriteLine("Эт параллелограмм!");
            }
            else
            {
                Console.WriteLine("Эт не параллелограмм!");
            }
        }
        static void Main(string[] args)
        {
            bool content = true;
            int mission;
            while(content)
            {
                Console.WriteLine("Какую задачу хотите посмотреть?");
                mission = Convert.ToInt32(Console.ReadLine());
                switch (mission)
                {
                    case 1:
                        Console.WriteLine("Задание № 1");
                        Console.WriteLine("Введите значение x:");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Work1(x);
                        break;
                    case 2:
                        Console.WriteLine("Задание № 2");
                        Console.WriteLine("Введите значение x:");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите значение y:");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Work2(x, y);
                        break;
                    case 3:
                        Console.WriteLine("Задание № 3");
                        Console.WriteLine("Введите значение x:");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите значение y:");
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите значение x0:");
                        int x0 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите значение y0:");
                        int y0 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите значение радиуса:");
                        int r = Convert.ToInt32(Console.ReadLine());
                        Work3(x, y, x0, y0, r);
                        break;
                    case 4:
                        Console.WriteLine("Задание № 4");
                        x = 0;
                        Work4(x);
                        break;
                    case 5:
                        int x2, y2, x3, y3, x4, y4;
                        Console.WriteLine("Задание № 5");
                        Console.WriteLine("Введите значение 1 точки(x,y)");
                        x = Convert.ToInt32(Console.ReadLine());
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите значение 2 точки(x,y)");
                        x2 = Convert.ToInt32(Console.ReadLine());
                        y2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите значение 3 точки(x,y)");
                        x3 = Convert.ToInt32(Console.ReadLine());
                        y3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите значение 4 точки(x,y)");
                        x4 = Convert.ToInt32(Console.ReadLine());
                        y4 = Convert.ToInt32(Console.ReadLine());
                        Work5(x, y, x2, y2, x3, y3, x4, y4);
                        break;
                    default:
                        Console.WriteLine("Введите число от 1 до 5!");
                        break;
                }
            }
         
        }
    }
}
