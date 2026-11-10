using System;
using Tyuiu.UstuzhaninAA.Sprint4.Task1.V8.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint4.Task1.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Устюжанин А. А | Задание 1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Устюжанин Алексей Андреевич | ИСПб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 9.                          *");
            Console.WriteLine("* Подсчитать сумму нечетных элементов массива.                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Задаем размер массива
            int len = 12;
            int[] numsArray = new int[len];

            // Цикл для интерактивного ввода
            for (int i = 0; i < len; i++)
            {
                while (true)
                {
                    Console.Write($"Введите значение {i}-го элемента (от 2 до 9): ");
                    int value = Convert.ToInt32(Console.ReadLine());

                    // Проверка на вхождение элемента в допустимый диапазон
                    if (value >= 2 && value <= 9)
                    {
                        numsArray[i] = value;
                        break; // Выход из бесконечного цикла, если значение корректно
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Число должно быть строго в диапазоне от 2 до 9.");
                    }
                }
            }

            Console.WriteLine("\nВведенный массив элементов:");
            Console.Write("{ ");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.Write(numsArray[i] + (i < numsArray.Length - 1 ? ", " : ""));
            }
            Console.WriteLine(" }");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Вызов метода из библиотеки
            int res = ds.Calculate(numsArray);

            Console.WriteLine($"Сумма нечетных элементов массива = {res}");

            Console.ReadKey();
        }
    }
}
