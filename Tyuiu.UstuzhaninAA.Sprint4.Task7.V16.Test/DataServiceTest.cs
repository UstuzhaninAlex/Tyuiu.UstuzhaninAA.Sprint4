using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint4.Task7.V16.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint4.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // Исходные параметры из условия
            int rows = 5;
            int cols = 3;
            string str = "382976421897948";

            // Ожидаемое произведение всех чётных элементов = 196608
            int wait = 196608;

            int res = ds.Calculate(rows, cols, str);

            Assert.AreEqual(wait, res, "Произведение чётных элементов преобразованной матрицы вычислено неверно.");
        }
    }
}
