using System;
using Tyuiu.UstuzhaninAA.Sprint4.Task4.V27.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint4.Task4.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Устюжанин А. А. | Задание #4";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Устюжанин Алексей Андреевич | ИСПб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 9. Найдите сумму нечетных   *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 5;
            int cols = 5;
            int[,] matrix = new int[rows, cols];

            // Ввод элементов матрицы с клавиатуры
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    while (true)
                    {
                        Console.Write($"Введите элемент [{i}, {j}] (от 1 до 9): ");
                        int value = Convert.ToInt32(Console.ReadLine());

                        if (value >= 1 && value <= 9)
                        {
                            matrix[i, j] = value;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка! Введите целое число в диапазоне от 1 до 9.");
                        }
                    }
                }
            }

            // Вывод заполненной матрицы в виде таблицы
            Console.WriteLine("\nВведенный массив 5x5:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Вызов метода из библиотеки классов
            int res = ds.Calculate(matrix);

            Console.WriteLine($"Сумма нечетных элементов массива = {res}");

            Console.ReadKey();
        }
    }
}
