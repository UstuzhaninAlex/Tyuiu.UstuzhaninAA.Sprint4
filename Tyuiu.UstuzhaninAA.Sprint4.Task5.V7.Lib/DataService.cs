using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.UstuzhaninAA.Sprint4.Task5.V7.Lib
{
    public class DataService : ISprint4Task5V7
    {
        public int Calculate(int[,] matrix)
        {
            int countNegative = 0;

            // Определяем количество строк и столбцов матрицы
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Вложенными циклами перебираем каждый элемент двумерного массива
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Если текущий элемент строго меньше 0, увеличиваем счётчик
                    if (matrix[i, j] < 0)
                    {
                        countNegative++;
                    }
                }
            }

            return countNegative;
        }
    }
}
