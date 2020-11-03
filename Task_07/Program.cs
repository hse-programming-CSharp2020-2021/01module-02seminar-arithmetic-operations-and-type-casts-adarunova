/*
 * Задача : 
 * Написать программу с использованием двух методов. Первый метод возвращает дробную и целую часть числа. 
 * Второй метод возвращает квадрат и корень из числа. В основной программе пользователь вводит дробное число. 
 * Программа должна вычислить, если это возможно, значение корня, квадрата числа, выделить целую и дробную 
 * часть из числа. Выводить и вводить с точностью до 2-х знаков после запятой.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 10,12
 * -------test_2-------
 * -5,5
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 3,18
 * 102,41
 * 10
 * 12
 * -------test_2-------
 * 27,5
 * -5
 * -5
 * --------------------
 */

using System;
using System.Globalization;

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Смена локали на "ru-RU". 
            CultureInfo.CurrentUICulture = new CultureInfo("ru-RU");
            double x;
            // Считываем вещественную переменную.
            x = double.Parse(Console.ReadLine());
            // Целая и дробная часть числа.
            int integer, fraction;
            // Получаем целую и дробную части числа.
            GetIntAndFract(x, out integer, out fraction);
            // Корень и квадрат числа.
            double sqrt, sqr;
            // Получаем корень и квадрат числа.
            GetSqrtAndSqr(x, out sqrt, out sqr);
            // Вывод результата.
            if (sqrt != -1)
                Console.WriteLine($"{sqrt:f2}");
            Console.WriteLine($"{sqr:f2}");
            Console.WriteLine(integer);
            Console.WriteLine(fraction);
        }

        // Метод, вычисляющий целую и дробную часть числа.
        static void GetIntAndFract(double x, out int integer, out int fraction)
        {
            // Целая чать.
            integer = (int)x;
            // Дробная чать.
            fraction = (int)Math.Round(Math.Pow(10, x.ToString().Length - integer.ToString().Length - 1) * (x - integer));
        }

        // Метод, вычисляющий корень и квадрат числа.
        static void GetSqrtAndSqr(double x, out double sqrt, out double sqr)
        {
            // Корень числа.
            sqrt = x >= 0 ? Math.Sqrt(x) : -1;
            // Квадрат числа.
            sqr = x * x;
        }
    }
}
