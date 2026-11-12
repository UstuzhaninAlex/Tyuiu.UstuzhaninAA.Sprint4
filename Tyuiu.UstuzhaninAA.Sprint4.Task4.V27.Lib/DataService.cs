using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.UstuzhaninAA.Sprint4.Task4.V27.Lib
{
    public class DataService : ISprint4Task4V27
    {
        public int Calculate(int[,] matrix)
        {
            int sumOdd = 0;

            // Получаем размеры количество строк и столбцов
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Вложенные циклы для каждого элемента матрицы
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Проверяем элемент на нечётность
                    if (matrix[i, j] % 2 != 0)
                    {
                        sumOdd += matrix[i, j]; // Накапливаем сумму нечётных чисел
                    }
                }
            }

            return sumOdd;
        }
    }
}
