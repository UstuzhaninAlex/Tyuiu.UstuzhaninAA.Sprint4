using System;
using Tyuiu.UstuzhaninAA.Sprint4.Task2.V19.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint4.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнил: Устюжанин А. А. | Задание 2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Устюжанин Алексей Андреевич | ИСПб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов, заполненный        *");
            Console.WriteLine("* случайными числами в диапазоне от 4 до 9. Подсчитать сумму нечетных     *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len = 14;
            int[] numsArray = new int[len];

            // Заполнение массива случайными числами в диапазоне от 4 до 9
            
            for (int i = 0; i < len; i++)
            {
                numsArray[i] = rnd.Next(4, 10);
            }

            // Вывод сгенерированного массива
            Console.Write("Сгенерированный массив: { ");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.Write(numsArray[i] + (i < numsArray.Length - 1 ? ", " : ""));
            }
            Console.WriteLine(" }");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine($"Сумма нечетных элементов массива = {res}");

            Console.ReadKey();
        }
    }
}
