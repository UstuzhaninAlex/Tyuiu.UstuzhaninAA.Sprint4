using System;
using Tyuiu.UstuzhaninAA.Sprint4.Task0.V25.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint4.Task0.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            // Инициализация массива
            int[] numsArray = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };

            Console.Title = "Спринт #4 | Выполнил: Устюжанин А. А. | Задание 0";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Устюжанин Алексей Андреевич | ИСПб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями. Подсчитать сумму четных элементов массива.     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Массив: { ");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.Write(numsArray[i] + (i < numsArray.Length - 1 ? ", " : ""));
            }
            Console.WriteLine(" }");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.GetSumEvenArrEl(numsArray);

            Console.WriteLine($"Сумма четных элементов массива = {res}");

            Console.ReadKey();
        }
    }
}
