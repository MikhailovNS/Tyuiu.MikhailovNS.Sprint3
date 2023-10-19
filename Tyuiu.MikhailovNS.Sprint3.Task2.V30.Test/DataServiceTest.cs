using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovNS.Sprint3.Task2.V30.Lib;

namespace Tyuiu.MikhailovNS.Sprint3.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int stopValue = 11;
            int startValue = 1;
            double wait = 13051.34;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
