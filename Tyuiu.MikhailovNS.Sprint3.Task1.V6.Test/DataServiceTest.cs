using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovNS.Sprint3.Task1.V6.Lib;

namespace Tyuiu.MikhailovNS.Sprint3.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 4; 
            int startValue = 1; 
            int stopValue = 10;
            double res = ds.GetSumSeries(value, startValue, stopValue); ;
            double wait = -389102.25;
            Assert.AreEqual(wait, res);
        }
    }
}
