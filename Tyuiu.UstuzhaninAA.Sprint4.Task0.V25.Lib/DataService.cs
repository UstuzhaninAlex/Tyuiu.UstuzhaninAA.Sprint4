using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.UstuzhaninAA.Sprint4.Task0.V25.Lib
{
    public class DataService : ISprint4Task0V25
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int sumEven = 0;

            // Используем стандартный цикл foreach для прохода по всем элементам массива
            foreach (int element in array)
            {
                // Проверяем делится ли элемент на 2 без остатка
                if (element % 2 == 0)
                {
                    sumEven += element; // Накапливаем сумму четных чисел
                }
            }

            return sumEven;
        }
    }
}
