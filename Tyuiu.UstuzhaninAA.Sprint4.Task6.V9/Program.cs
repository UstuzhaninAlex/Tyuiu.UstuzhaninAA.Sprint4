using System;
using Tyuiu.UstuzhaninAA.Sprint4.Task6.V9.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint4.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            // Исходный массив строковых данных
            string[] colors = { "Красный", "Оранжевый", "Желтый", "Зеленый", "Синий", "Индиго", "Фиолетовый" };

            Console.Title = "Спринт #4 | Выполнил: Устюжанин А. А. | Задание #6";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Устюжанин Алексей Андреевич | ИСПб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Красный\", \"Оранжевый\", \"Желтый\",    *");
            Console.WriteLine("* \"Зеленый\", \"Синий\", \"Индиго\", \"Фиолетовый\"]. Используя класс    *");
            Console.WriteLine("* Array подсчитайте количество элементов, длина которых меньше 7.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine($"[{i}] = {colors[i]} (длина: {colors[i].Length})");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Вызов метода из библиотеки
            int res = ds.Calculate(colors);

            Console.WriteLine($"Количество элементов с длиной меньше 7 = {res}");

            Console.ReadKey();
        }
    }
}
