/*
 * Задача : 
 * Получить от пользователя вещественное значение – бюджет пользователя и целое число – процент бюджета, 
 * выделенный на компьютерные игры. Вычислить и вывести на экран сумму в долларах, 
 * выделенную на компьютерные игры. С точностью до 2-х знаков после запятой. 
 * !!!Использовать спецификаторы формата для валют.!!!
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1300
 * 10
 * -------test_2-------
 * 1000.50
 * 5
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * $130.00
 * -------test_2-------
 * $50.03
 * --------------------
 */

using System;
using System.Globalization;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Смена локали на "en-US". 
            CultureInfo.CurrentUICulture = new CultureInfo("en-US");
            double sum;
            int percent;
            // Считываем бюджет и процент на игры.
            sum = double.Parse(Console.ReadLine());
            percent = int.Parse(Console.ReadLine());
            // Бюджет на игры.
            double onComputerGames = sum / 100 * percent;
            // Выводим результат.
            Console.WriteLine(onComputerGames.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")));
        }
    }
}
