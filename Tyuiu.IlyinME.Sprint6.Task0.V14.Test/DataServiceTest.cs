using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IlyinME.Sprint6.Task0.V14.Lib;

namespace Tyuiu.IlyinME.Sprint6.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = -0.444;
            Assert.AreEqual(wait, res);
        }
    }
}
