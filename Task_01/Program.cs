/*
 * Задача : 
 * Ввести значение x и вывести значение полинома: F(x) = 12x^4 + 9x^3 - 3x^2 + 2x – 4. 
 * С точностью до 2-х знаков после запятой. 
 * !!! Не применять возведение в степень. !!!
 * Использовать минимальное количество операций умножения. 
 * (Алгоритм быстрого возведения в степень : https://e-maxx.ru/algo/binary_pow)
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1
 * -------test_2-------
 * 0
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 16,00
 * -------test_2-------
 * -4,00
 * --------------------
 * 
 * Тестирование будет проводиться на машинах с английской локалью, где в качестве разделителя в 
 * вещественных числах используется точка. Чтобы выводилась запятая надо принудительно сменить локаль на русскую.
 */

using Microsoft.Win32;
using System;
using System.Globalization;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Смена локали на "ru-RU". 
            CultureInfo.CurrentUICulture = new CultureInfo("ru-RU");
            // Переменная.
            double x;
            // Ввод переменной. 
            x = double.Parse(Console.ReadLine());
            // Вычисление и вывод значения полинома.
            Console.WriteLine($"{GetPolinomValue(x):f2}");
        }

        // Метод вычисления значения полинома.
        static double GetPolinomValue(double x)
        {
            return 12 * QuickPow(x, 4) + 9 * QuickPow(x, 3) - 3 * QuickPow(x, 2) + 2 * x - 4;
        }

        // Метод быстрого возведения числа x в степень pow.
        static double QuickPow(double x, int pow)
        {
            if (pow == 1)
                return x;
            else if (pow % 2 == 0)
            {
                double y = QuickPow(x, pow / 2);
                return y * y;
            }
            else
                return x * QuickPow(x, pow - 1);
        }
    }
}