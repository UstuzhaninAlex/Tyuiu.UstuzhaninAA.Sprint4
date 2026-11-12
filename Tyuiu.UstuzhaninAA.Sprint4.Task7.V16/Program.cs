using System;
using Tyuiu.UstuzhaninAA.Sprint4.Task7.V16.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint4.Task7.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int rows = 5;
            int cols = 3;
            string str = "382976421897948";

            Console.Title = "Спринт #4 | Выполнил: Устюжанин А. А. | Задание #7";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Устюжанин Алексей Андреевич | ИСПб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"382976421897948\". Преобразуйте её  *");
            Console.WriteLine("* в матрицу 5 на 3 и подсчитайте произведение четных чисел.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Исходная строка: {str}");
            Console.WriteLine($"Размерность матрицы: {rows}x{cols}");

            // Вывод матрицы
            Console.WriteLine("\nПреобразованная матрица:");
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Вызов метода из библиотеки
            int res = ds.Calculate(rows, cols, str);

            Console.WriteLine($"Произведение четных элементов матрицы = {res}");

            Console.ReadKey();
        }
    }
}
