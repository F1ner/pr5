using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr5
{
    internal class Program
    { //Задание 6
        //Создайте приложение, которое выводит сумму, вычитание, умножение и деление двух параметров входных данных.
        //static void Main()
        //{
        //    Console.Write("x=");
        //    int x = int.Parse(Console.ReadLine());
        //    Console.Write("y=");
        //    int y = int.Parse(Console.ReadLine());
        //    int a = Add(x, y);
        //    Console.WriteLine($"x+y={a}");
        //    int b = Dif(x, y);
        //    Console.WriteLine($"x-y={b}");
        //    int c = Mult(x, y);
        //    Console.WriteLine($"x*y={c}");
        //    double d = Div(x, y);
        //    Console.WriteLine($"x/y={d}");
        //    Console.ReadKey();
        //}
        //public static int Add(int x, int y)
        //{
        //    return x + y;
        //}
        //public static int Dif(int x, int y)
        //{
        //    return x - y;
        //}
        //public static int Mult(int x, int y)
        //{
        //    return x * y;
        //}
        //public static double Div(int x, int y)
        //{
        //    return (double)x / y;
        //}
        //Домашнеее задание:
        //1. Нахождение максимальной величины из двух целых переменных a, b.(минимальное из 4 чиселa a,b,c,d)
        //public static void Main()
        //{
        //    Console.Write("a=");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.Write("b=");
        //    int b = int.Parse(Console.ReadLine());
        //    Console.Write("c=");
        //    int c = int.Parse(Console.ReadLine());
        //    Console.Write("d=");
        //    int d = int.Parse(Console.ReadLine());
        //    int min = Min(Min(Min(a, b),c),d);
        //    Console.WriteLine($"Наименьшее число-{min}");
        //    Console.ReadKey();
        //}
        //public static int Min(int a,int b)
        //{
        //    if (a < b)
        //        return a;
        //    else
        //        return b;
        //}
        //2. Вычислить среднее арифметическое трех действительных чисел.
        //public static void Main()
        //{
        //    Console.Write("a=");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.Write("b=");
        //    int b = int.Parse(Console.ReadLine());
        //    Console.Write("c=");
        //    int c = int.Parse(Console.ReadLine());
        //    int sum = Average(Average(a, b), c);
        //    int average = sum / 3;
        //    Console.WriteLine($"Среднее арифметическое-{average}");
        //    Console.ReadKey();
        //}
        //public static int Average(int a, int b)
        //{
        //    return a + b;
        //}
        //3. Составьте таблицу значений функции y = 4x² + 5x - 10 на отрезке [-9; 9] с шагом h = 3.
        static void Main(string[]args)
        {
            Task();
            Console.ReadKey();
        }
        public static void Task()
        {
            for(int x=-9;x<=9;x=x+3)
            {
                Console.WriteLine($"x={x}\t\t y={4 * Math.Pow(x, 2) + 5 * x - 10}");
            }
        }

    }
}
