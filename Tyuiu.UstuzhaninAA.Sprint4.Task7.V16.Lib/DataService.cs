using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.UstuzhaninAA.Sprint4.Task7.V16.Lib
{
    public class DataService : ISprint4Task7V16
    {
        public int Calculate(int n, int m, string value)
        {
            // Создаем двумерный массив размером n на m (5 на 3)
            int[,] matrix = new int[n, m];

            // Заполняем матрицу цифрами из исходной строки
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // Вычисляем линейный индекс символа в строке (i * m + j)
                    matrix[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            // Инициализируем переменную произведения единицей
            int multEven = 1;

            // Проходим по всем элементам сформированной матрицы и перемножаем чётные
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        multEven *= matrix[i, j];
                    }
                }
            }

            return multEven;
        }
    }
}
