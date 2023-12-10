using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IlyinME.Sprint6.Task6.V21.Lib;
using System.IO;

namespace Tyuiu.IlyinME.Sprint6.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckedPath()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V21.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V21.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = "nXkwQYzgZ XcNHugFmbsRgVVfsgHNGuUC";
            Assert.AreEqual(wait, res);
        }
    }
}
