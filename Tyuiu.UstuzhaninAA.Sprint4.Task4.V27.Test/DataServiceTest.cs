using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint4.Task4.V27.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint4.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // Контрольная матрица 5x5 
            int[,] testMatrix = new int[5, 5]
            {
                { 4, 3, 9, 2, 2 },
                { 8, 4, 1, 4, 3 },
                { 3, 9, 2, 2, 5 },
                { 4, 6, 8, 5, 6 },
                { 1, 5, 2, 2, 5 }
            };

            // Ожидаемая сумма нечётных элементов = 49
            int wait = 49;

            int res = ds.Calculate(testMatrix);

            Assert.AreEqual(wait, res, "Сумма нечётных элементов двумерного массива вычислена неверно.");
        }
    }
}
