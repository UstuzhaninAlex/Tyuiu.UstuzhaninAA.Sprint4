using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint4.Task5.V7.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint4.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // Фиксированная тестовая матрица 5x5 со значениями -7 - 7
            int[,] testMatrix = new int[5, 5]
            {
                { -7,  0,  3, -2,  5 },
                {  4, -1,  7,  2, -6 },
                {  0,  1, -4,  6,  3 },
                { -5,  2,  0, -3,  7 },
                {  6, -2,  1,  4,  0 }
            };

            // В матрице ровно 8 отрицательных чисел
            int wait = 8;

            int res = ds.Calculate(testMatrix);

            Assert.AreEqual(wait, res, "Количество отрицательных элементов матрицы подсчитано неверно.");
        }
    }
}
