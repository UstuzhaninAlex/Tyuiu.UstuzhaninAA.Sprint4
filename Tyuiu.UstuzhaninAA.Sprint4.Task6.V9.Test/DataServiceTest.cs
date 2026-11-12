using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint4.Task6.V9.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint4.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // Исходный массив цветов радуги
            string[] colors = { "Красный", "Оранжевый", "Желтый", "Зеленый", "Синий", "Индиго", "Фиолетовый" };

            // Ожидаемое количество элементов с длиной < 7 = 3 
            int wait = 3;

            int res = ds.Calculate(colors);

            Assert.AreEqual(wait, res, "Количество строковых элементов с длиной меньше 7 подсчитано неверно.");
        }
    }
}
