using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovNS.Sprint3.Task3.V16.Lib;

namespace Tyuiu.MikhailovNS.Sprint3.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test()
        {
            DataService ds = new DataService();
            string value = "ice nice ice creamcc";
            char chr = 'c';
            int item = ds.GetCharCount(value, chr);
            int wait = 6;
            Assert.AreEqual(wait, item);
        }
    }
}
