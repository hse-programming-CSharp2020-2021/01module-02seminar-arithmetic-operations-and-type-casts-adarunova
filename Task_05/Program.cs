/*
 * Задача : 
 * Получить от пользователя три вещественных числа и проверить для них неравенство треугольника. 
 * Если оно выполняется, то вычислить площадь этого треугольника. 
 * !!! Оператор if не применять. !!!
 * Точность вывода три знака после запятой.
 * 
 * Если неравенство треугольника не выполняется, то вывести сообщение : "not a triangle"
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 5,3
 * 13
 * 6,123
 * -------test_2-------
 * 3
 * 2
 * 4
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * not a triangle
 * -------test_2-------
 * 2,905
 * --------------------
 *	
 */

using System;
using System.Globalization;

namespace Task_05
{
    class Program
    {
        const string notTriangleMessage = "not a triangle";

        static void Main(string[] args)
        {
            // Смена локали на "ru-RU". 
            CultureInfo.CurrentUICulture = new CultureInfo("ru-RU");
            // Стороны треугольника.
            double a, b, c;
            // Считываем стороны треугольника.
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            // Результат.
            string result = a + b <= c || a + c <= b || b + c <= a ? notTriangleMessage : Sqare(a, b, c).ToString("F3", CultureInfo.GetCultureInfo("ru-RU"));
            Console.WriteLine(result);
        }

        // Метод вычисления алощади треугольника.
        static double Sqare(double a, double b, double c)
        {
            // Полуперимитер.
            double p = (a + b + c) / 2;
            // Возвращаем площадь.
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
