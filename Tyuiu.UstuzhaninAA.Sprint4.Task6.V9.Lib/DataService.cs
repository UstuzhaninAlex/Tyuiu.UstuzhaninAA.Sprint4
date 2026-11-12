using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.UstuzhaninAA.Sprint4.Task6.V9.Lib
{
    public class DataService : ISprint4Task6V9
    {
        public int Calculate(string[] array)
        {
            // Используем статический метод Array.FindAll для выборки всех строк,
            // длина которых строго меньше 7 символов
            string[] filteredArray = Array.FindAll(array, element => element.Length < 7);

            // Возвращаем количество найденных элементов
            return filteredArray.Length;
        }
    }
}
