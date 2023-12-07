using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SolievAH.Sprint5.Task3.V28.Lib;

namespace Tyuiu.SolievAH.Sprint5.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\katag\source\repos\Tyuiu.SolievAH.Sprint5\Tyuiu.SolievAH.Sprint5.Task3.V28\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
