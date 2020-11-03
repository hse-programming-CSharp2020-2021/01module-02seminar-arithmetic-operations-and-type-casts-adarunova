/*
 * Задача : 
 * Получить от пользователя четырехзначное натуральное число 
 * и напечатать его цифры в обратном порядке.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1234
 * -------test_2-------
 * 5669
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 4321
 * -------test_2-------
 * 9665
 * --------------------
 */

using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Число.
            int x;
            // Считываем целочисленное значение.
            x = int.Parse(Console.ReadLine());
            // Вычисление нового числа и его вывод.
            string reverseNumber = ReverseNumber(x).ToString();
            Console.WriteLine(reverseNumber.Length == 4 ? reverseNumber : reverseNumber.Length == 3 ? "0" + reverseNumber : reverseNumber.Length == 2 ? "00" + reverseNumber : "000" + reverseNumber);
        }

        // Метод разворачивания числа.
        static int ReverseNumber(int x)
        {
            // Массив цифр числа x.
            char[] digits = x.ToString().ToCharArray();
            // Разворачивание массива цифр числа x.
            Array.Reverse(digits);
            // Собирание числа из цифр и его возвращение из метода.
            return int.Parse(new string(digits));
        }
    }
}
