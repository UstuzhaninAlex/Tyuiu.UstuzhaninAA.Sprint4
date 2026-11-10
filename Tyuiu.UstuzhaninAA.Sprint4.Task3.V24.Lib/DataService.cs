using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.UstuzhaninAA.Sprint4.Task3.V24.Lib
{
    public class DataService : ISprint4Task3V24
    {
        public int Calculate(int[,] matrix)
        {
            // Получаем количество строк в двумерном массиве
            int rows = matrix.GetLength(0);

            // За индекс второго столбца принимаем 1
            int targetColumn = 1;

            // Инициализируем переменную для поиска минимума значением первой строки целевого столбца
            int minVal = matrix[0, targetColumn];

            // Проходим циклом по всем строкам фиксированного второго столбца
            for (int i = 1; i < rows; i++)
            {
                if (matrix[i, targetColumn] < minVal)
                {
                    minVal = matrix[i, targetColumn];
                }
            }

            return minVal;
        }
    }
}
