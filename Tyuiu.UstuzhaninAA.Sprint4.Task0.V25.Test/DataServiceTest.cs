using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint4.Task0.V25.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint4.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            // Статический массив
            int[] numsArray = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };

            // Ожидаемый результат 42
            int wait = 42;

            int res = ds.GetSumEvenArrEl(numsArray);

            Assert.AreEqual(wait, res, "Расчет суммы четных элементов одномерного массива выполнен неверно.");
        }
    }
}
