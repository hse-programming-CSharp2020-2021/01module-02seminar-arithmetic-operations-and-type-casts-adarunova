/*
 * Задача : 
 * Введя значения коэффициентов А, В, С, вычислить корни квадратного уравнения. 
 * Корни выводит с точностью до 2-х знаков после запятой.
 * Учесть (как хотите) возможность появления комплексных корней.
 * !!! Оператор if не применять. !!!
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 5
 * 13
 * 6
 * -------test_2-------
 * 3
 * 2
 * 4
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * -0,60
 * -2,00
 * -------test_2-------
 * complex roots
 * --------------------
 * 
 * Корни выводятся в отдельных строках. Если нет вещественных вывести сообщение "complex roots"
 */

using System;
using System.Globalization;

namespace Task_03
{
    class Program
    {
        const string complexRootsMessage = "complex roots";
        static void Main(string[] args)
        {
            // Смена локали на "ru-RU". 
            CultureInfo.CurrentUICulture = new CultureInfo("ru-RU");
            // Коэффициенты.
            double a, b, c;
            // Считывем коэффициенты уравнения.
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            // Дискриминант уравнения.
            double discriminant = b * b - 4 * a * c;
            // Запись корней уравнения.
            string result = discriminant < 0 ? complexRootsMessage : discriminant == 0 ? $"{-b / (2 * a):f2}" : $"{(-b + Math.Sqrt(discriminant)) / (2 * a):f2}{Environment.NewLine}{(-b - Math.Sqrt(discriminant)) / (2 * a):f2}";
            Console.WriteLine(result);
        }
    }
}
