using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint4.Task2.V19.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint4.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // Создаем фиксированный массив из 14 элементов в диапазоне 4-9 для теста
            int[] testArray = { 4, 5, 6, 7, 8, 9, 4, 5, 6, 7, 8, 9, 5, 5 };

            // Нечетные элементы: 5, 7, 9, 5, 7, 9, 5, 5. Сумма = 56
            int wait = 56;

            int res = ds.Calculate(testArray);

            Assert.AreEqual(wait, res, "Расчет суммы нечетных случайных элементов выполнен неверно.");
        }
    }
}
