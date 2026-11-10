using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint4.Task3.V24.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint4.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // Статическая матрица 
            int[,] testMatrix = new int[5, 5]
            {
                { 3, 6, 1, 7, 3 },
                { 2, 3, 7, 1, 1 },
                { 1, 2, 5, 5, 1 },
                { 7, 6, 7, 6, 2 },
                { 7, 6, 4, 5, 8 }
            };

            // Математически ожидаемый минимум во 2-м столбце равен 2
            int wait = 2;

            int res = ds.Calculate(testMatrix);

            Assert.AreEqual(wait, res, "Поиск минимального элемента во втором столбце матрицы выполнен неверно.");
        }
    }
}
