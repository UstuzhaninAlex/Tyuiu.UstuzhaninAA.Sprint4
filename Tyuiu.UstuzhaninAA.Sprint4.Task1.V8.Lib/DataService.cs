using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.UstuzhaninAA.Sprint4.Task1.V8.Lib
{
    public class DataService : ISprint4Task1V8
    {
        public int Calculate(int[] array)
        {
            int sumOdd = 0;

            // Проход циклом по всем элементам массива
            for (int i = 0; i < array.Length; i++)
            {
                // Проверяем элемент на нечетность
                if (array[i] % 2 != 0)
                {
                    sumOdd += array[i]; // Накапливаем сумму нечетных значений
                }
            }

            return sumOdd;
        }
    }
}
