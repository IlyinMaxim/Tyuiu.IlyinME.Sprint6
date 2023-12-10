using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.IlyinME.Sprint6.Task7.V11.Lib;

namespace Tyuiu.IlyinME.Sprint6.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckedMatrix()
        {
            string path = @"C:\Users\1\source\repos\Tyuiu.IlyinME.Sprint6\Tyuiu.IlyinME.Sprint6.Task7.V11\bin\Release\InPutFileTask7V11.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
