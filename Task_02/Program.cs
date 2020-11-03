/*
 * Задача : 
 * Ввести натуральное трехзначное число Р. 
 * Найти наибольшее целое число, которое можно получить, переставляя цифры числа Р.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 208
 * -------test_2-------
 * 159
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 820
 * -------test_2-------
 * 951
 * --------------------
 */

using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int p;
            // Ввод целочисленного значения.
            p = int.Parse(Console.ReadLine());
            // Подсчёт и вывод результата.
            Console.WriteLine(MaxPermutation(p));
        }

        // Метод нахождения максимального числа из цифр числа x.
        static int MaxPermutation(int x)
        {
            // Цифры числа.
            int firstDigit = x / 100,
                secondDigit = x / 10 % 10,
                thirdDigit = x % 10;
            // Максимальная цифра в числе.
            int maxDigit = Math.Max(Math.Max(firstDigit, secondDigit), thirdDigit);
            // Минимальная цифра в числе.
            int minDigit = Math.Min(Math.Min(firstDigit, secondDigit), thirdDigit);
            // Сумма всех цифр.
            int sumOfDigits = firstDigit + secondDigit + thirdDigit;
            // Максимальное число из цифр числа x. 
            int max = maxDigit * 100 + (sumOfDigits - minDigit - maxDigit) * 10 + minDigit;
            return max;
        }
    }
}
