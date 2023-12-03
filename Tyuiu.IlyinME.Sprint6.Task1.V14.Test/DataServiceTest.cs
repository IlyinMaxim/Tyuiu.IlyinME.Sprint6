using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IlyinME.Sprint6.Task1.V14.Lib;

namespace Tyuiu.IlyinME.Sprint6.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidChecked()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = -2.15;
            valueWaitArray[1] = -2.57;
            valueWaitArray[2] = -3.00;
            valueWaitArray[3] = -3.83;
            valueWaitArray[4] = -11.70;
            valueWaitArray[5] = 3.00;
            valueWaitArray[6] = 2.19;
            valueWaitArray[7] = 3.31;
            valueWaitArray[8] = 2.97;
            valueWaitArray[9] = 1.18;
            valueWaitArray[10] = 0.03;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
